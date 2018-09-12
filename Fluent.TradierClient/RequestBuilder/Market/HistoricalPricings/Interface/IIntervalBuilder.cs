using Fluent.TradierClient.RequestBuilder.Market.HistoricalPricings.Model;

namespace Fluent.TradierClient.RequestBuilder.Market.HistoricalPricings.Interface
{
    /// <summary>
    /// Interval builder for historical data.
    /// </summary>
    public interface IIntervalBuilder
    {
        /// <summary>
        /// Specifies the interval of time for historical pricing
        /// </summary>
        /// <param name="intervalOption">The interval option.</param>
        /// <returns>Start date builder.</returns>
        IIntervalNextOptionBuilder WithInterval(HistoryIntervalOption intervalOption);
    }
}