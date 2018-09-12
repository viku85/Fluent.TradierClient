namespace Fluent.TradierClient.RequestBuilder.Market.OptionStrikes.Interface
{
    /// <summary>
    /// Auto expiry builder.
    /// </summary>
    public interface IAutoExpiryLimitBuilder
    {
        /// <summary>
        /// Specify limit for Auto expiry date selections.
        /// </summary>
        /// <param name="limit">The Auto expiry days range limit selection.</param>
        /// <returns>Tradier Option strike builder.</returns>
        TradierOptionStrikeBuilder WithAutoExpiryLimit(int limit);
    }
}