namespace Fluent.TradierClient.RequestBuilder.Market.OptionChains.Interface
{
    /// <summary>
    /// Auto expiry limit builder.
    /// </summary>
    public interface IAutoExpiryLimitBuilder
    {
        /// <summary>
        /// Specify auto expiry limit.
        /// </summary>
        /// <param name="limit">The expiry limit range for retrieval.</param>
        /// <returns>Option chain Builder.</returns>
        TradierOptionChainBuilder AutoExpiryLimit(int limit);
    }
}