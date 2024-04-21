using Clean.Domain.Common;
using ErrorOr;

namespace Clean.Examples.CounterWebApp.Domain;

public class Counter : BaseEntity<int, Counter, CounterDto>
{
    public Counter(int value)
    {
        Value = value;
    }

    public Counter(int id, int value) : base(id)
    {
        Value = value;
    }

    public int Value { get; set; }

    public override CounterDto ToDto()
    {
        return new CounterDto { Id = Id, Value = Value };
    }

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
public class CounterDto : EntityDto<int, Counter, CounterDto>
{
    public int Value { get; set; }
    public override Counter ToEntity()
    {
        return new Counter(Id, Value);
    }
}
public class CounterCreateDto : ICreateEntityDto<int, Counter, CounterDto>
{
    public int Value { get; set; }

    public Counter ToEntity()
    {
        return new Counter(Value);
    }
}
