using Microsoft.Extensions.DependencyInjection;
using OrderBook.Application.Common.Persistance;
using OrderBook.Persistence.Context;
using OrderBook.Persistence.Repositories;

namespace OrderBook.Persistence;

public static class DependencyInjection
{
    public static IServiceCollection AddPersistence(this IServiceCollection service)
    {
        service.AddEntityFrameworkSqlite().AddDbContext<ApplicationContext>();

        service.AddTransient<IOrderRepository, OrderRepository>();
        IServiceCollection serviceCollection = service.AddTransient<IUnitOfWork, EFUnitOfWork>();
        return serviceCollection;
    }
}
