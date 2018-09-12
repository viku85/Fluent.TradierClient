using System;

namespace Fluent.TradierClient.RequestBuilder.Market.HistoricalPricings.Interface
{
    /// <summary>
    /// Tradier historical end date builder.
    /// </summary>
    public interface IEndDateNextBuilder
    {
        /// <summary>
        /// Specifies end date for history range.
        /// </summary>
        /// <param name="endDate">The end date.</param>
        /// <returns>Historical command builder.</returns>
        IBuild WithEndDate(DateTime endDate);
    }
}