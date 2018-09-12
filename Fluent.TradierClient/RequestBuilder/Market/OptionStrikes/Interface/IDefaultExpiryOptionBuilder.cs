namespace Fluent.TradierClient.RequestBuilder.Market.OptionStrikes.Interface
{
    /// <summary>
    /// Default options for Option expiry.
    /// </summary>
    /// <seealso cref="IOptionStrikeExpiryBuilder" />
    /// <seealso cref="IAutoExpiryLimitBuilder" />
    public interface IDefaultExpiryOptionBuilder
        : IOptionStrikeExpiryBuilder, IAutoExpiryLimitBuilder
    {
    }
}