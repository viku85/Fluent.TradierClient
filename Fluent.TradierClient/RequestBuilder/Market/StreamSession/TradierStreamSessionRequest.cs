using Fluent.TradierClient.RequestBuilder.Market.StreamSession.Model;
using Fluent.TradierClient.RequestBuilder.Model;
using Newtonsoft.Json.Linq;
using System;
using System.Threading.Tasks;

namespace Fluent.TradierClient.RequestBuilder.Market.StreamSession
{
    /// <summary>
    /// Tradier stream session new request
    /// </summary>
    /// <seealso cref="TradierWebRequest{TradierStreamSessionResult}" />
    public class TradierStreamSessionRequest
        : TradierWebRequest<TradierStreamSessionResult>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TradierStreamSessionRequest"/> class.
        /// </summary>
        /// <param name="token">The token.</param>
        internal TradierStreamSessionRequest(AuthToken token)
            : base(token?.BaseUrl, token?.AccessKey)
        {
        }

        /// <summary>
        /// Creates the session asynchronous.
        /// </summary>
        /// <param name="commandBuilder">The command builder.</param>
        /// <returns>Instance of <see cref="TradierStreamSessionRequest"/>.</returns>
        public static async Task<TradierStreamSessionResult> CreateSessionAsync(Func<TradierStreamSessionCommand> commandBuilder) =>
            await new TradierStreamSessionRequest(commandBuilder?.Invoke()).GetAsync();

        /// <summary>
        /// Deserializes the JSON token for Tradier result.
        /// </summary>
        /// <param name="jToken">The JSON token.</param>
        /// <returns>The new stream session.</returns>
        protected override TradierStreamSessionResult Deserialize(JToken jToken) =>
                    jToken?.SelectToken("stream")?.ToObject<TradierStreamSessionResult>();

        /// <summary>
        /// Relative URL to make Tradier request.
        /// </summary>
        /// <returns>New session URL.</returns>
        protected override string RelativeUrl() => "markets/events/session";
    }
}