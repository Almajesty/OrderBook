using MediatR;
using OrderBook.Application.Common.Persistance;
using OrderBook.Domain.OrderAggregate;

namespace OrderBook.Application.OrderFeature.Commands.CreateOrder;

public class CreateOrderCommandHandler : IRequestHandler<CreateOrderCommand, Order>
{
    private readonly IOrderRepository _repository;
    private readonly IUnitOfWork _unitOfWork;

    public CreateOrderCommandHandler(IOrderRepository repository,
                                     IUnitOfWork unitOfWork)
    {
        _repository = repository;
        _unitOfWork = unitOfWork;
    }

    public async Task<Order> Handle(CreateOrderCommand request, CancellationToken cancellationToken)
    {
        Order order = new Order();

        order.Number = request.Number;
        order.Date = request.Date;

        _repository.Create(order);
        _unitOfWork.Save();

        return order;
    }
}
