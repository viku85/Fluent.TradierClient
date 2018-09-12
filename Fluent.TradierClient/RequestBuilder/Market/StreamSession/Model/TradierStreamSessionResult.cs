using Newtonsoft.Json;

namespace Fluent.TradierClient.RequestBuilder.Market.StreamSession.Model
{
    /// <summary>
    /// Tradier create new session result.
    /// </summary>
    public class TradierStreamSessionResult
    {
        /// <summary>
        /// Gets or sets a unique session identifier for use with streaming.
        /// </summary>
        /// <value>
        /// The a unique session identifier for use with streaming.
        /// </value>
        [JsonProperty("sessionid")]
        public string SessionId { get; set; }

        /// <summary>
        /// Gets or sets the URL to access for streaming market data.
        /// </summary>
        /// <value>
        /// The URL to access for streaming market data.
        /// </value>
        [JsonProperty("url")]
        public string Url { get; set; }
    }
}