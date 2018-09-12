using Fluent.TradierClient.RequestBuilder.Market.SymbolLookup.Interface;
using Fluent.TradierClient.RequestBuilder.Model;
using System;

namespace Fluent.TradierClient.RequestBuilder.Market.SymbolLookup
{
    /// <summary>
    /// Tradier symbol lookup builder.
    /// </summary>
    /// <seealso cref="Builder{TradierSymbolLookupCommand}" />
    /// <seealso cref="IDefaultSymbolLookupBuilder" />
    /// <seealso cref="IExchangeFilterBuilder" />
    /// <seealso cref="ISymbolQueryBuilder" />
    /// <seealso cref="ITypeFilterBuilder" />
    /// <seealso cref="Builder{TradierSymbolLookupCommand}" />
    public class TradierSymbolLookupBuilder
        : Builder<TradierSymbolLookupCommand>, IDefaultSymbolLookupBuilder, IExchangeFilterBuilder, ISymbolQueryBuilder, ITypeFilterBuilder
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TradierSymbolLookupBuilder" /> class.
        /// </summary>
        /// <param name="authToken">The authentication token.</param>
        internal TradierSymbolLookupBuilder(AuthToken authToken)
        {
            Command = new TradierSymbolLookupCommand(authToken) ?? throw new ArgumentNullException(nameof(authToken));
        }

        protected TradierSymbolLookupBuilder(TradierSymbolLookupCommand cmd)
            : base(cmd) { }

        /// <summary>
        /// Specify list of exchange codes to query.
        /// </summary>
        /// <param name="exchangeOption">The exchange option.</param>
        /// <returns></returns>
        public TradierSymbolLookupBuilder WithExchangeFilter(params string[] exchangeOption) =>
            BuildNew(cmd => cmd.Exchanges.AddRange(exchangeOption));

        /// <summary>
        /// Specify the symbol to query.
        /// </summary>
        /// <param name="symbolQuery">The symbol query.</param>
        /// <returns></returns>
        public TradierSymbolLookupBuilder WithSymbolQuery(string symbolQuery) => BuildNew(cmd => cmd.Query = symbolQuery);

        /// <summary>
        /// Specify list of security types to query.
        /// </summary>
        /// <param name="typeOptions">The type options.</param>
        /// <returns></returns>
        public TradierSymbolLookupBuilder WithTypeFilter(params string[] typeOptions) => BuildNew(cmd => cmd.Types.AddRange(typeOptions));

        /// <summary>
        /// Creates a completely new instance of passed <paramref name="cmd" />.
        /// </summary>
        /// <param name="cmd">The existing command.</param>
        /// <returns>
        /// New <see name="TradierSymbolLookupCommand" />.
        /// </returns>
        protected override TradierSymbolLookupCommand Clone(TradierSymbolLookupCommand cmd) =>
            new TradierSymbolLookupCommand(cmd)
            {
                Exchanges = cmd.Exchanges,
                Query = cmd.Query,
                Types = cmd.Types
            };

        /// <summary>
        /// Builds the new <see cref="TradierSymbolLookupBuilder"/>.
        /// </summary>
        /// <param name="commandComposer">The command composer.</param>
        /// <param name="condition">The condition.</param>
        /// <returns>Instance of <see cref="TradierSymbolLookupBuilder"/>.</returns>
        private TradierSymbolLookupBuilder BuildNew(Action<TradierSymbolLookupCommand> commandComposer,
                                            Func<TradierSymbolLookupCommand, bool> condition = null)
        {
            var command = Clone(commandComposer);
            if (condition == null || condition(command))
            {
                return new TradierSymbolLookupBuilder(command);
            }
            return this;
        }
    }
}