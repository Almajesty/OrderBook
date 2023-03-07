using OrderBook.Domain.Common.Models;

namespace OrderBook.Domain.OrderAggregate.ValObjects;

public class OrderItemId : ValueObject
{
    public override IEnumerable<object> GetEqualityComponents()
    {
        throw new NotImplementedException();
    }
}
