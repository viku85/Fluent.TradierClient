using Fluent.TradierClient.RequestBuilder.Model;

namespace Fluent.TradierClient.RequestBuilder.Market.InterDayStatues
{
    /// <summary>
    /// Tradier market inter-day status builder.
    /// </summary>
    /// <seealso cref="Builder{TradierInterDayCommand}" />
    public class TradierInterdayStatusBuilder
        : Builder<TradierInterDayCommand>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TradierInterdayStatusBuilder"/> class.
        /// </summary>
        /// <param name="token">The token.</param>
        internal TradierInterdayStatusBuilder(AuthToken token)
        {
            Command = new TradierInterDayCommand(token?.BaseUrl, token?.AccessKey);
        }

        /// <summary>
        /// Creates a completely new instance of passed <paramref name="cmd" />.
        /// </summary>
        /// <param name="cmd">The existing command.</param>
        /// <returns>
        /// New <see name="AuthToken" />.
        /// </returns>
        protected override TradierInterDayCommand Clone(TradierInterDayCommand cmd)
            => new TradierInterDayCommand(cmd?.BaseUrl, cmd?.AccessKey);
    }
}