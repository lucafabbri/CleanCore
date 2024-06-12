using CleanCore.Domain.Common;
using CleanCore.Examples.CounterWebApp.Domain;

namespace CleanCore.Examples.CounterWebApp.DTO
{
    /// <summary>
    /// The counter dto class
    /// </summary>
    /// <seealso cref="EntityDto{int, Counter, CounterDto}"/>
    public class CounterDto : EntityDto<int, Counter, CounterDto>
    {

        /// <summary>
        /// Gets or sets the value of the counter type
        /// </summary>
        public CounterType CounterType { get; set; }

        /// <summary>
        /// Gets or sets the value of the value
        /// </summary>
        public int Value { get; set; }

        /// <summary>
        /// Returns the entity
        /// </summary>
        /// <returns>The counter</returns>
        public override Counter ToEntity()
        {
            return new Counter { Id = Id, Value = Value, CounterType = CounterType };
        }
    }

    /// <summary>
    /// The elastic counter dto class
    /// </summary>
    /// <seealso cref="EntityDto{string, ElasticCounter, ElasticCounterDto}"/>
    public class ElasticCounterDto : EntityDto<string, ElasticCounter, ElasticCounterDto>
    {

        /// <summary>
        /// Gets or sets the value of the counter type
        /// </summary>
        public CounterType CounterType { get; set; }

        /// <summary>
        /// Gets or sets the value of the value
        /// </summary>
        public int Value { get; set; }

        /// <summary>
        /// Returns the entity
        /// </summary>
        /// <returns>The counter</returns>
        public override ElasticCounter ToEntity()
        {
            return new ElasticCounter(Id, CounterType, Value);
        }
    }
}
