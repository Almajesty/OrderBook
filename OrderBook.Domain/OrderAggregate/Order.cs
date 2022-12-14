using OrderBook.Domain.Common.Models;
using OrderBook.Domain.OrderAggregate.Entities;
using OrderBook.Domain.OrderAggregate.ValueObjects;

namespace OrderBook.Domain.OrderAggregate;

public sealed class Order : AggregateRoot<OrderId>
{
    public int Id { get; set; }

    public string Number { get; set; }

    public DateTime Date { get; set; }

    public List<OrderItem> OrderItems { get; set; }
}
