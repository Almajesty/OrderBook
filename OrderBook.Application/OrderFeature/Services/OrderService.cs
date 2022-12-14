using OrderBook.Application.OrderFeature.Interfaces;
using OrderBook.Domain.OrderAggregate;

namespace OrderBook.Application.OrderFeature.Services;

public class OrderService : IOrderService
{
    public IEnumerable<Order> GetAll()
    {
        throw new NotImplementedException();
    }
}
