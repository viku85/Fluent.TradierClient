using Fluent.TradierClient.RequestBuilder.Market.MarketCalenders.Commands;
using Fluent.TradierClient.RequestBuilder.Market.MarketCalenders.Interface;
using Fluent.TradierClient.RequestBuilder.Model;
using System;

namespace Fluent.TradierClient.RequestBuilder.Market.MarketCalenders
{
    /// <summary>
    /// Market calendar builder.
    /// </summary>
    /// <seealso cref="Builder{TradierMarketCalenderCommand}" />
    /// <seealso cref="IBuild" />
    /// <seealso cref="IDefaultCalendarBuilder" />
    /// <seealso cref="IMonthBuilder" />
    /// <seealso cref="IYearBuilder" />
    public class TradierMarketCalenderBuilder
        : Builder<TradierMarketCalenderCommand>, IBuild, IDefaultCalendarBuilder, IMonthBuilder, IYearBuilder
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TradierMarketCalenderBuilder"/> class.
        /// </summary>
        /// <param name="requestModel">The request model.</param>
        internal TradierMarketCalenderBuilder(AuthToken requestModel)
        {
            Command = new TradierMarketCalenderCommand(requestModel);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TradierMarketCalenderBuilder"/> class.
        /// </summary>
        /// <param name="command">The command.</param>
        private TradierMarketCalenderBuilder(TradierMarketCalenderCommand command)
            : base(command)
        {
        }

        /// <summary>
        /// Specifies the month for Calendar query.
        /// </summary>
        /// <param name="month">The month.</param>
        /// <returns>Builder for Market calendar.</returns>
        public IBuild WithMonth(Month month) => Build(cmd => cmd.Month = month);

        /// <summary>
        /// Specifies year for Stock Calendar to look into.
        /// </summary>
        /// <param name="year">The year.</param>
        /// <returns>Month builder.</returns>
        public IMonthBuilder WithYear(int year) => Build(cmd => cmd.Year = year);

        /// <summary>
        /// Builds the specified command composer.
        /// </summary>
        /// <param name="commandComposer">The command composer.</param>
        /// <returns>Instance of <see cref=""/> with new command requested.</returns>
        protected TradierMarketCalenderBuilder Build(Action<TradierMarketCalenderCommand> commandComposer) =>
                                    new TradierMarketCalenderBuilder(Clone(commandComposer));

        /// <summary>
        /// Creates a completely new instance of passed <paramref name="cmd" />.
        /// </summary>
        /// <param name="cmd">The existing command.</param>
        /// <returns>
        /// New <see name="TradierMarketCalenderCommand" />.
        /// </returns>
        protected override TradierMarketCalenderCommand Clone(TradierMarketCalenderCommand cmd) =>
            new TradierMarketCalenderCommand(cmd)
            {
                Month = cmd.Month,
                Year = cmd.Year
            };
    }
}