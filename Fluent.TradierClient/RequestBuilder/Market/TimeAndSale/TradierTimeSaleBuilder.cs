using Fluent.TradierClient.RequestBuilder.Market.TimeAndSale.Interface;
using Fluent.TradierClient.RequestBuilder.Model;
using System;

namespace Fluent.TradierClient.RequestBuilder.Market.TimeAndSale
{
    /// <summary>
    /// Tradier Time sale builder.
    /// </summary>
    /// <seealso cref="Builder{TimeSaleCommand}" />
    /// <seealso cref="IStartDateBuilder" />
    /// <seealso cref="IEndDateBuilder" />
    /// <seealso cref="IDefaultTimeSaleBuilder" />
    /// <seealso cref="IIntervalBuilder" />
    /// <seealso cref="ISessionBuilder" />
    public class TradierTimeSaleBuilder
        : Builder<TradierTimeSaleCommand>, IStartDateBuilder, IEndDateBuilder, IDefaultTimeSaleBuilder, IIntervalBuilder, ISessionBuilder
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TradierTimeSaleBuilder"/> class.
        /// </summary>
        /// <param name="authToken">The authentication token.</param>
        /// <exception cref="ArgumentNullException">authToken</exception>
        internal TradierTimeSaleBuilder(AuthToken authToken)
        {
            Command = new TradierTimeSaleCommand(authToken) ?? throw new ArgumentNullException(nameof(authToken));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TradierTimeSaleBuilder"/> class.
        /// </summary>
        /// <param name="cmd">The command.</param>
        protected TradierTimeSaleBuilder(TradierTimeSaleCommand cmd)
            : base(cmd)
        {
        }

        /// <summary>
        /// Specify End date for timesales.
        /// </summary>
        /// <param name="endDate">The end date.</param>
        /// <returns>Composed TimeSale</returns>
        public TradierTimeSaleBuilder WithEndDate(DateTime endDate) => Build(cmd => cmd.EndDate = endDate);

        /// <summary>
        /// Specify the interval of time for timesales pricing
        /// </summary>
        /// <param name="interval">The interval.</param>
        /// <returns>Composed TimeSale</returns>
        public IStartDateBuilder WithInterval(TimeSalesInterval interval) => Build(cmd => cmd.Interval = interval);

        /// <summary>
        /// Specify The session conditions.
        /// </summary>
        /// <param name="sessionFilter">The session filter.</param>
        /// <returns>Composed TimeSale</returns>
        public IIntervalBuilder WithSession(SessionFilter sessionFilter) => Build(cmd => cmd.SessionFilter = sessionFilter);

        /// <summary>
        /// Specify Start datetime for timesales range.
        /// </summary>
        /// <param name="startDate">The start date.</param>
        /// <returns>Composed TimeSale</returns>
        public IEndDateBuilder WithStartDate(DateTime startDate) => Build(cmd => cmd.StartDate = startDate);

        /// <summary>
        /// Specify the symbol.
        /// </summary>
        /// <param name="symbol">The symbol.</param>
        /// <returns>Composed TimeSale</returns>
        public ISessionBuilder WithSymbol(string symbol) => Build(cmd => cmd.Symbol = symbol);

        /// <summary>
        /// Creates a completely new instance of passed <paramref name="cmd" />.
        /// </summary>
        /// <param name="cmd">The existing command.</param>
        /// <returns>
        /// New <see cref="TradierTimeSaleCommand"/>.
        /// </returns>
        protected override TradierTimeSaleCommand Clone(TradierTimeSaleCommand cmd) =>
            new TradierTimeSaleCommand(Command)
            {
                Symbol = Command.Symbol,
                EndDate = Command.EndDate,
                Interval = Command.Interval,
                SessionFilter = Command.SessionFilter,
                StartDate = Command.StartDate
            };

        /// <summary>
        /// Builds the specified command composer.
        /// </summary>
        /// <param name="commandComposer">The command composer.</param>
        /// <returns>Time sale builder.</returns>
        private TradierTimeSaleBuilder Build(Action<TradierTimeSaleCommand> commandComposer)
                    => new TradierTimeSaleBuilder(Clone(commandComposer));
    }
}