using OrderBook.Application.Common.Persistance;
using OrderBook.Domain.OrderAggregate;
using OrderBook.Persistence.Context;

namespace OrderBook.Persistence.Repositories;

public class EFUnitOfWork : IUnitOfWork
{
    private ApplicationContext _context;

    private IGenericRepository<Order> _orders;

    public EFUnitOfWork(ApplicationContext context)
    {
        _context = context;

    }

    public IGenericRepository<Order> Orders
    {
        get
        {
            if (_orders == null)
            {
                _orders = new EFGenericRepository<Order>(_context);
            }

            return _orders;
        }
    }

    public void Save()
    {
        _context.SaveChanges();
    }
}
