using Fluent.TradierClient.RequestBuilder.Model;

namespace Fluent.TradierClient.RequestBuilder.Market.StreamSession
{
    /// <summary>
    /// Tradier authentication token.
    /// </summary>
    /// <seealso cref="AuthToken" />
    public class TradierStreamSessionCommand
        : AuthToken
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TradierStreamSessionCommand"/> class.
        /// </summary>
        /// <param name="url">The URL.</param>
        /// <param name="accessKey">The access key.</param>
        public TradierStreamSessionCommand(string url, string accessKey)
            : base(url, accessKey)
        {
        }
    }
}