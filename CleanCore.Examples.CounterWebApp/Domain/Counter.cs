using CleanCore.Domain.Common;
using CleanCore.Examples.CounterWebApp.DTO;
using ErrorOr;

namespace CleanCore.Examples.CounterWebApp.Domain;

/// <summary>
/// The counter class
/// </summary>
/// <seealso cref="BaseIntEntity{Counter}"/>
public class Counter : BaseIntEntity<Counter, CounterDto>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="Counter"/> class
    /// </summary>
    public Counter() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="Counter"/> class
    /// </summary>
    /// <param name="value">The value</param>
    public Counter(int value)
    {
        CounterType = CounterType.Counter;
        Value = value;
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="Counter"/> class
    /// </summary>
    /// <param name="id">The id</param>
    /// <param name="value">The value</param>
    public Counter(int id, int value) : base(id)
    {
        CounterType = CounterType.Counter;
        Value = value;
    }

    /// <summary>
    /// Gets or sets the value of the counter type
    /// </summary>
    public CounterType CounterType { get; set; }

    /// <summary>
    /// Gets or sets the value of the value
    /// </summary>
    public int Value { get; set; }

    /// <summary>
    /// Returns the dto
    /// </summary>
    /// <returns>The counter dto</returns>
    public override CounterDto ToDto()
    {
        return new CounterDto { 
            Id = Id,
            Value = Value,
            CounterType = CounterType,
            CreatedBy = CreatedBy,
            CreatedAt = CreatedAt,
            DeletedAt = DeletedAt,
            DeletedBy = DeletedBy,
            LastModifiedAt = LastModifiedAt,    
            LastModifiedBy = LastModifiedBy
        };
    }

    /// <summary>
    /// Validates this instance
    /// </summary>
    /// <returns>An error or of counter</returns>
    public override ErrorOr<Counter> Validate()
    {
        return this.ToErrorOr().FailIf(counter => counter.Value < 0, Error.Validation(description: $"{Value} < 0"));
    }

    /// <summary>
    /// Inners the update using the specified entity
    /// </summary>
    /// <param name="entity">The entity</param>
    /// <returns>An error or of counter</returns>
    protected override ErrorOr<Counter> InnerUpdate(Counter entity)
    {
        Value = entity.Value;
        return this;
    }
}
