using OrderBook.Application.Common.Persistance;

using OrderBook.Domain.OrderAggregate;
using OrderBook.Domain.OrderAggregate.Entities;

using OrderBook.Persistence.Context;

namespace OrderBook.Persistence.Repositories;

public class OrderRepository : IOrderRepository
{
    private ApplicationContext _context;

    public OrderRepository(ApplicationContext context)
    {
        _context = context;

        if (_context.Orders.ToList().Count == 0)
        {
            InitializeDefault();
        }
    }

    private void InitializeDefault()
    {
        IEnumerable<Order> OrderList = new List<Order>
        {
            new Order
            {   
                Id = 1, Number = "number1", Date = DateTime.Now, 
                OrderItems = new List<OrderItem>
                { 
                    new OrderItem(){ Id = 1, Name = "name1", Quantity = 123.23M, Unit = "unit1" },
                    new OrderItem(){ Id = 2, Name = "name2", Quantity = 532.23M, Unit = "unit2" },
                    new OrderItem(){ Id = 3, Name = "name3", Quantity = 42.32M, Unit = "unit3" }
                } 
            },
            new Order{ Id = 2, Number = "number2", Date = DateTime.Now.AddDays(1)},
            new Order{ Id = 3, Number = "number3", Date = DateTime.Now.AddDays(2)},
        };

        _context.Orders.AddRange(OrderList);
        _context.SaveChanges();
    }

    public void Create(Order item)
    {
        _context.Add(item);
    }

    public void Delete(int id)
    {
        throw new NotImplementedException();
    }

    public void Delete(Order item)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Order> GetAll()
    {
        return _context.Orders.ToList();
    }

    public Order GetItemById(int id)
    {
        throw new NotImplementedException();
    }

    public void Update(Order item)
    {
        throw new NotImplementedException();
    }
}