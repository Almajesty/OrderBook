using FluentValidation;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using OrderBook.Application.Common.Behaviors;
using OrderBook.Application.OrderFeature.Interfaces;
using OrderBook.Application.OrderFeature.Services;
using System.Reflection;

namespace OrderBook.Application;

public static class DependencyInjection
{
    public static void AddApplication(this IServiceCollection service)
    {
        // add mediatR
        service.AddMediatR(Assembly.GetExecutingAssembly());

        // add validation
        service.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());
        service.AddTransient(typeof(IPipelineBehavior<,>), typeof(ValidationBehavior<,>));

        // add cache
        service.AddDistributedMemoryCache();
        service.AddTransient(typeof(IPipelineBehavior<,>), typeof(CachingBehavior<,>));

        // add services
        service.AddTransient<IOrderService, OrderService>();
    }
}
