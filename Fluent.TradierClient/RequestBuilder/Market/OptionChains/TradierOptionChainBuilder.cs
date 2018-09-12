using Fluent.TradierClient.RequestBuilder.Market.OptionChains.Interface;
using Fluent.TradierClient.RequestBuilder.Model;
using System;

namespace Fluent.TradierClient.RequestBuilder.Market.OptionChains
{
    /// <summary>
    /// Tradier Option chain builder.
    /// </summary>
    /// <seealso cref="Builder{TradierOptionChainCommand}" />
    /// <seealso cref="IExpiryBuilder" />
    /// <seealso cref="IDefaultBuilder" />
    public class TradierOptionChainBuilder
        : Builder<TradierOptionChainCommand>, IExpiryBuilder, IDefaultBuilder
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TradierOptionChainBuilder"/> class.
        /// </summary>
        /// <param name="requestModel">The request model.</param>
        /// <param name="symbol">The symbol.</param>
        internal TradierOptionChainBuilder(AuthToken requestModel, string symbol)
        {
            Command = new TradierOptionChainCommand(requestModel) { Symbol = symbol, };
        }

        private TradierOptionChainBuilder(TradierOptionChainCommand cmd)
            : base(cmd) { }

        /// <summary>
        /// Specify auto expiry limit.
        /// </summary>
        /// <param name="limit">The expiry limit range for retrieval.</param>
        /// <returns>Option chain Builder.</returns>
        public TradierOptionChainBuilder AutoExpiryLimit(int limit) => Build(cmd => cmd.ExpiryDateRangeLimit = limit);

        /// <summary>
        /// Specify expiration date for option chain.
        /// </summary>
        /// <param name="dateTime">The expiration date.</param>
        /// <returns>Option chain builder.</returns>
        public IBuild<TradierOptionChainCommand> WithExpirationDate(DateTime expiryTime) => Build(cmd => cmd.Expiry = expiryTime);

        /// <summary>
        /// Builds the specified command composer.
        /// </summary>
        /// <param name="commandComposer">The command composer.</param>
        /// <returns>Newly composed <see cref="TradierOptionChainBuilder"/>.</returns>
        protected TradierOptionChainBuilder Build(Action<TradierOptionChainCommand> commandComposer) =>
            new TradierOptionChainBuilder(Clone(commandComposer));

        /// <summary>
        /// Creates a completely new instance of passed <paramref name="cmd" />.
        /// </summary>
        /// <param name="cmd">The existing command.</param>
        /// <returns>
        /// New <see name="OptionChainCommand" />.
        /// </returns>
        protected override TradierOptionChainCommand Clone(TradierOptionChainCommand cmd) =>
            new TradierOptionChainCommand(Command, Command.Symbol, Command.Expiry)
            {
                ExpiryDateRangeLimit = Command.ExpiryDateRangeLimit
            };

        /// <summary>
        /// Specifies symbol for option chain.
        /// </summary>
        /// <param name="symbol">The symbol.</param>
        /// <returns>Expiry builder.</returns>
        private IExpiryBuilder WithSymbol(string symbol) => Build(cmd => cmd.Symbol = symbol);
    }
}