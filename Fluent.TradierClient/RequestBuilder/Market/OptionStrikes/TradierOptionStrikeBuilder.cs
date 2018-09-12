using Fluent.TradierClient.RequestBuilder.Market.OptionStrikes.Interface;
using Fluent.TradierClient.RequestBuilder.Model;
using System;

namespace Fluent.TradierClient.RequestBuilder.Market.OptionStrikes
{
    /// <summary>
    /// Tradier option strike builder.
    /// </summary>
    /// <seealso cref="Builder{TradierOptionStrikeCommand}" />
    /// <seealso cref="IOptionStrikeExpiryBuilder" />
    /// <seealso cref="IDefaultExpiryOptionBuilder" />
    public class TradierOptionStrikeBuilder
        : Builder<TradierOptionStrikeCommand>, IDefaultExpiryOptionBuilder
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TradierOptionStrikeBuilder"/> class.
        /// </summary>
        /// <param name="token">The token.</param>
        /// <param name="symbol">The symbol.</param>
        internal TradierOptionStrikeBuilder(AuthToken token, string symbol)
        {
            Command = new TradierOptionStrikeCommand(token)
            {
                Symbol = symbol
            };
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TradierOptionStrikeBuilder"/> class.
        /// </summary>
        /// <param name="command">The command.</param>
        protected TradierOptionStrikeBuilder(TradierOptionStrikeCommand command)
            : base(command)
        {
        }

        /// <summary>
        /// Specify limit for Auto expiry date selections.
        /// </summary>
        /// <param name="limit">The Auto expiry days range limit selection.</param>
        /// <returns>Tradier Option strike builder.</returns>
        public TradierOptionStrikeBuilder WithAutoExpiryLimit(int limit) =>
            Build(cmd => cmd.ExpiryDateRangeLimit = limit);

        /// <summary>
        /// Specify the expiration date to obtain strikes.
        /// </summary>
        /// <param name="expiryTime">The expiration date for strikes.</param>
        /// <returns>Builder for option strike.</returns>
        public IBuild<TradierOptionStrikeCommand> WithExpiry(DateTime expiryTime) =>
            Build(cmd => cmd.ExpirationDate = expiryTime);

        /// <summary>
        /// Creates a completely new instance of passed <paramref name="cmd" />.
        /// </summary>
        /// <param name="cmd">The existing command.</param>
        /// <returns>
        /// New <see name="TradierOptionStrikeCommand" />.
        /// </returns>
        protected override TradierOptionStrikeCommand Clone(TradierOptionStrikeCommand cmd) =>
            new TradierOptionStrikeCommand(cmd)
            {
                ExpirationDate = cmd.ExpirationDate,
                Symbol = cmd.Symbol,
                ExpiryDateRangeLimit = cmd.ExpiryDateRangeLimit
            };

        /// <summary>
        /// Builds the specified command composer.
        /// </summary>
        /// <param name="commandComposer">The command composer.</param>
        /// <returns>Instance of <see cref="TradierOptionStrikeBuilder"/>.</returns>
        private TradierOptionStrikeBuilder Build(Action<TradierOptionStrikeCommand> commandComposer)
                        => new TradierOptionStrikeBuilder(Clone(commandComposer));
    }
}