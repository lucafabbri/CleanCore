using Clean.Domain.Common;
using ErrorOr;

namespace Clean.Examples.CounterWebApp.Domain;

/// <summary>
/// The counter class
/// </summary>
/// <seealso cref="BaseIntEntityAndDto{Counter}"/>
public class Counter : BaseIntEntityAndDto<Counter>
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
        Value = value;
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="Counter"/> class
    /// </summary>
    /// <param name="id">The id</param>
    /// <param name="value">The value</param>
    public Counter(int id, int value) : base(id)
    {
        Value = value;
    }

    /// <summary>
    /// Gets or sets the value of the value
    /// </summary>
    public int Value { get; set; }

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
