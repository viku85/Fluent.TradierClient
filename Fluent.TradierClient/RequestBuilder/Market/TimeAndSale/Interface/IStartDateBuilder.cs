using System;

namespace Fluent.TradierClient.RequestBuilder.Market.TimeAndSale.Interface
{
    /// <summary>
    /// Start date builder for time and sales.
    /// </summary>
    /// <seealso cref="Fluent.TradierClient.RequestBuilder.Market.TimeAndSale.Interface.IBuild" />
    public interface IStartDateBuilder
        : IBuild
    {
        /// <summary>
        /// Specify Start datetime for timesales range.
        /// </summary>
        /// <param name="startDate">The start date.</param>
        /// <returns>End date builder for time and sales.</returns>
        IEndDateBuilder WithStartDate(DateTime endDate);
    }
}