using OrderBook.Domain.OrderAggregate;

namespace OrderBook.Application.Common.Persistance;

public interface IUnitOfWork
{
    IGenericRepository<Order> Orders { get; }

    void Save();
}
