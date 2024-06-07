using CleanCore.Domain.Common;
using CleanCore.Examples.CounterWebApp.Domain;

namespace CleanCore.Examples.CounterWebApp.DTO
{
    public class CounterDto : EntityDto<int, Counter, CounterDto>
    {

        /// <summary>
        /// Gets or sets the value of the value
        /// </summary>
        public int Value { get; set; }

        public override Counter ToEntity()
        {
            return new Counter { Id = Id, Value = Value };
        }
    }
}
