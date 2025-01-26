using FluentValidation;

namespace Shared.Models;

public sealed class CreatePaymentRequestValidator : AbstractValidator<CreatePaymentRequest>
{
    public CreatePaymentRequestValidator()
    {
        RuleFor(x => x.TransactionDate).NotEmpty();
        RuleFor(x => x.AccountId).NotEmpty();
        RuleForEach(x => x.LineItems).SetValidator(new CreateLineItemRequestValidator());
    }
}

internal sealed class CreateLineItemRequestValidator : AbstractValidator<CreateLineItemRequest>
{
    public CreateLineItemRequestValidator()
    {
        RuleFor(x => x.LineItemTypeId).NotEmpty();
        RuleFor(x => x.Amount).NotEmpty();
    }
}

public sealed class CreatePaymentRequest
{
    public DateTime TransactionDate { get; set; }
    public DateTime? PostedDate { get; set; }
    public int? PayeeId { get; set; }
    public int AccountId { get; set; }
    public string? Memo { get; set; }
    public List<CreateLineItemRequest> LineItems { get; set; } = [];
    public double Total => LineItems.Sum(x => x.Amount);
}

public sealed class CreateLineItemRequest
{
    public int LineItemTypeId { get; set; }
    public string? Details { get; set; }
    public double Amount { get; set; }
}
