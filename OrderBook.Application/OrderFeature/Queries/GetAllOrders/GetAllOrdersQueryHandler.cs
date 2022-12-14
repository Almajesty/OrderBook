using MediatR;
using OrderBook.Application.Common.Persistance;
using OrderBook.Domain.OrderAggregate;

namespace OrderBook.Application.OrderFeature.Queries.GetAllOrders;

public class GetAllOrdersQueryHandler : IRequestHandler<GetAllOrdersQuery, IEnumerable<Order>>
{
    private readonly IOrderRepository _repository;

    public GetAllOrdersQueryHandler(IOrderRepository repository)
    {
        _repository = repository;
    }
    public async Task<IEnumerable<Order>> Handle(GetAllOrdersQuery request, CancellationToken cancellationToken)
    {
        return _repository.GetAll();
    }
}
