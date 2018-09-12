using Fluent.TradierClient.RequestBuilder.Market.HistoricalPricings.Interface;
using Fluent.TradierClient.RequestBuilder.Market.HistoricalPricings.Model;
using Fluent.TradierClient.RequestBuilder.Model;
using System;

namespace Fluent.TradierClient.RequestBuilder.Market.HistoricalPricings
{
    /// <summary>
    /// Tradier historical command builder.
    /// </summary>
    /// <seealso cref="Builder{TradierHistoricalPricingCommand}" />
    /// <seealso cref="IDefaultOptionBuilder" />
    /// <seealso cref="IIntervalBuilder" />
    /// <seealso cref="IStartDateBuilder" />
    /// <seealso cref="IIntervalNextOptionBuilder" />
    /// <seealso cref="IEndDateNextBuilder" />
    /// <seealso cref="IBuild" />
    public class TradierHistoricalPricingBuilder
        : Builder<TradierHistoricalPricingCommand>, IDefaultOptionBuilder, IIntervalBuilder, IStartDateBuilder, IIntervalNextOptionBuilder, IEndDateNextBuilder, IBuild
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TradierHistoricalPricingBuilder"/> class.
        /// </summary>
        /// <param name="token">The token.</param>
        /// <param name="symbol">The symbol.</param>
        internal TradierHistoricalPricingBuilder(AuthToken token, string symbol)
        {
            Command = new TradierHistoricalPricingCommand(token)
            {
                Symbol = symbol
            };
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TradierHistoricalPricingBuilder"/> class.
        /// </summary>
        /// <param name="cmd">The command.</param>
        private TradierHistoricalPricingBuilder(TradierHistoricalPricingCommand cmd)
              : base(cmd) { }

        /// <summary>
        /// Specifies end date for history range.
        /// </summary>
        /// <param name="endDate">The end date.</param>
        /// <returns>Historical command builder.</returns>
        public IBuild WithEndDate(DateTime endDate) =>
            Build(cmd => cmd.EndDate = endDate);

        /// <summary>
        /// Specifies the interval of time for historical pricing
        /// </summary>
        /// <param name="intervalOption">The interval option.</param>
        /// <returns>Start date builder.</returns>
        public IIntervalNextOptionBuilder WithInterval(HistoryIntervalOption intervalOption) =>
                    Build(cmd => cmd.Interval = intervalOption);

        /// <summary>
        /// Specifies start date for history range.
        /// </summary>
        /// <param name="startDate">The start date.</param>
        /// <returns>End date builder.</returns>
        public IEndDateNextBuilder WithStartDate(DateTime startDate) =>
            Build(cmd => cmd.StartDate = startDate);

        /// <summary>
        /// Builds the specified command composer.
        /// </summary>
        /// <param name="commandComposer">The command composer.</param>
        /// <returns></returns>
        protected TradierHistoricalPricingBuilder Build(Action<TradierHistoricalPricingCommand> commandComposer) =>
           new TradierHistoricalPricingBuilder(Clone(commandComposer));

        /// <summary>
        /// Creates a completely new instance of passed <paramref name="cmd" />.
        /// </summary>
        /// <param name="cmd">The existing command.</param>
        /// <returns>
        /// New <see name="TradierHistoricalPricingCommand" />.
        /// </returns>
        protected override TradierHistoricalPricingCommand Clone(TradierHistoricalPricingCommand cmd) =>
            new TradierHistoricalPricingCommand(cmd)
            {
                Symbol = cmd.Symbol,
                Interval = cmd.Interval,
                StartDate = cmd.StartDate,
                EndDate = cmd.EndDate
            };
    }
}