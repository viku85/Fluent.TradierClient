using Fluent.TradierClient.RequestBuilder.Model;

namespace Fluent.TradierClient.RequestBuilder.Market.InterDayStatues
{
    /// <summary>
    /// Tradier Inter-day command.
    /// </summary>
    /// <seealso cref="AuthToken" />
    public class TradierInterDayCommand
        : AuthToken
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TradierInterDayCommand"/> class.
        /// </summary>
        /// <param name="url">The URL.</param>
        /// <param name="accessKey">The access key.</param>
        public TradierInterDayCommand(string url, string accessKey)
            : base(url, accessKey)
        {
        }
    }
}