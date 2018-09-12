namespace Fluent.TradierClient.RequestBuilder.Market.MarketCalenders.Interface
{
    /// <summary>
    /// Calendar month builder.
    /// </summary>
    /// <seealso cref="IBuild" />
    public interface IYearBuilder
        : IBuild
    {
        /// <summary>
        /// Specifies year for Stock Calendar to look into.
        /// </summary>
        /// <param name="year">The year.</param>
        /// <returns>Month builder.</returns>
        IMonthBuilder WithYear(int year);
    }
}