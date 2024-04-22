using Clean.Domain.Common;
using ErrorOr;

namespace Clean.Examples.CounterWebApp.Domain;

public class Counter : BaseIntEntityAndDto<Counter>
{
    public Counter() { }
    public Counter(int value)
    {
        Value = value;
    }

    public Counter(int id, int value) : base(id)
    {
        Value = value;
    }

    public int Value { get; set; }

    public override ErrorOr<Counter> Validate()
    {
        return this.ToErrorOr().FailIf(counter => counter.Value < 0, Error.Validation(description: $"{Value} < 0"));
    }

    protected override ErrorOr<Counter> InnerUpdate(Counter entity)
    {
        Value = entity.Value;
        return this;
    }
}
