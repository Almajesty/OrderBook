using FluentValidation;

namespace OrderBook.Application.OrderFeature.Commands.CreateOrder;

public class CreateOrderCommandValidator : AbstractValidator<CreateOrderCommand>
{
    public CreateOrderCommandValidator()
    {
        var msg = "Ошибка в поле {PropertyName}: значение {PropertyValue}";

        _ = RuleFor(c => c.Number)
            .NotEmpty().WithMessage(msg)
            .Must(c => c.All(char.IsLetter)).WithMessage(msg);
    }
}
