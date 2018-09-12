using System;

namespace Fluent.TradierClient.RequestBuilder.Market.OptionStrikes.Interface
{
    /// <summary>
    /// Option date strike.
    /// </summary>
    public interface IOptionStrikeExpiryBuilder
    {
        /// <summary>
        /// Specify the expiration date to obtain strikes.
        /// </summary>
        /// <param name="expiryTime">The expiration date for strikes.</param>
        /// <returns></returns>
        IBuild<TradierOptionStrikeCommand> WithExpiry(DateTime expiryTime);
    }
}