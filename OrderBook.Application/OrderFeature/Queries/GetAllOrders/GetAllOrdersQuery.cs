using MediatR;
using OrderBook.Application.Common.Interfaces;
using OrderBook.Domain.OrderAggregate;

namespace OrderBook.Application.OrderFeature.Queries.GetAllOrders;

public class GetAllOrdersQuery : IRequest<IEnumerable<Order>>, ICacheableMediatrQuery
{
    public IEnumerable<Order> Orders { get; set; }

    public bool BypassCache { get; set; }
    public string CacheKey => $"Orders";
    public TimeSpan? SlidingExpiration { get; set; }
}
