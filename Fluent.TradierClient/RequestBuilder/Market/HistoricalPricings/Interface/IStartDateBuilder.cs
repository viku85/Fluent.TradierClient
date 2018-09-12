using System;

namespace Fluent.TradierClient.RequestBuilder.Market.HistoricalPricings.Interface
{
    /// <summary>
    /// Tradier historical start date builder.
    /// </summary>
    public interface IStartDateBuilder
    {
        /// <summary>
        /// Specifies start date for history range.
        /// </summary>
        /// <param name="startDate">The start date.</param>
        /// <returns>End date builder.</returns>
        IEndDateNextBuilder WithStartDate(DateTime startDate);
    }
}