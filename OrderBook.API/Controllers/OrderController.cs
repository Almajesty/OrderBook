using MediatR;
using Microsoft.AspNetCore.Mvc;

using OrderBook.Application.OrderFeature.Commands.CreateOrder;
using OrderBook.Application.OrderFeature.Queries.GetAllOrders;

namespace OrderBook.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class OrderController : ControllerBase
{
    private IMediator _mediator;

    public OrderController(IMediator mediator)
    {
        _mediator = mediator;
    }

    /// <summary>
    /// Gets all Orders.
    /// </summary>
    /// <returns></returns>
    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        return Ok(await _mediator.Send(new GetAllOrdersQuery()));
    }

    /// <summary>
    /// Creates a New Order.
    /// </summary>
    /// <param name="command"></param>
    /// <returns></returns>
    [HttpPost]
    public async Task<IActionResult> Create(CreateOrderCommand command)
    {
        return Ok(await _mediator.Send(command));
    }
}
