using System;

namespace Fluent.TradierClient.RequestBuilder.Market.OptionChains.Interface
{
    /// <summary>
    /// Expiration option chain builder.
    /// </summary>
    public interface IExpiryBuilder
    {
        /// <summary>
        /// Specify expiration date for option chain.
        /// </summary>
        /// <param name="dateTime">The expiration date.</param>
        /// <returns>Option chain builder.</returns>
        IBuild<TradierOptionChainCommand> WithExpirationDate(DateTime dateTime);
    }
}