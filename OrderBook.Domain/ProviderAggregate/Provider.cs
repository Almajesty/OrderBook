using OrderBook.Domain.Common.Models;
using OrderBook.Domain.ProviderAggregate.ValueObjects;

namespace OrderBook.Domain.ProviderAggregate;

public sealed class Provider : AggregateRoot<ProviderId>
{
    public string Name { get; set; }
}
