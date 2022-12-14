using OrderBook.Domain.OrderAggregate;

namespace OrderBook.Application.OrderFeature.Interfaces;

public interface IOrderService
{
    IEnumerable<Order> GetAll();
}
