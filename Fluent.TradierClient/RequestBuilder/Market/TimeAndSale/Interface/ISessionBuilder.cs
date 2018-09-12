namespace Fluent.TradierClient.RequestBuilder.Market.TimeAndSale.Interface
{
    /// <summary>
    /// Session builder for time and sales.
    /// </summary>
    /// <seealso cref="IBuild" />
    public interface ISessionBuilder
        : IBuild
    {
        /// <summary>
        /// Specify the symbol.
        /// </summary>
        /// <param name="symbol">The symbol.</param>
        /// <returns>Interval builder.</returns>
        IIntervalBuilder WithSession(SessionFilter sessionFilter);
    }
}