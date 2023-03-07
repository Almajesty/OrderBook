using OrderBook.Domain.Common.Models;

namespace OrderBook.Domain.OrderAggregate.ValObjects;

public class OrderSectionId : ValueObject
{
    public override IEnumerable<object> GetEqualityComponents()
    {
        throw new NotImplementedException();
    }
}
