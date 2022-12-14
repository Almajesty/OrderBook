using MediatR;

using OrderBook.Domain.OrderAggregate;

namespace OrderBook.Application.OrderFeature.Commands.CreateOrder;

public class CreateOrderCommand : IRequest<Order>
{
    public string Number { get; set; }
    public DateTime Date { get; set; }
}
