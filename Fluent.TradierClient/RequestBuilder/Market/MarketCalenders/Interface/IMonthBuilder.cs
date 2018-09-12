using Fluent.TradierClient.RequestBuilder.Market.MarketCalenders.Commands;

namespace Fluent.TradierClient.RequestBuilder.Market.MarketCalenders.Interface
{
    /// <summary>
    /// Market calendar month builder.
    /// </summary>
    /// <seealso cref="IBuild" />
    public interface IMonthBuilder
        : IBuild
    {
        /// <summary>
        /// Specifies the month for Calendar query.
        /// </summary>
        /// <param name="month">The month.</param>
        /// <returns>Builder for Market calendar.</returns>
        IBuild WithMonth(Month month);
    }
}