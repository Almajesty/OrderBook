using OrderBook.Domain.Common;

namespace OrderBook.Domain.OrderAggregate.Entities;

public class OrderItem : Entity
{
    public string Name { get; set; }

    public decimal Quantity { get; set; }

    public string Unit { get; set; }

    public int OrderId { get; set; }
}
