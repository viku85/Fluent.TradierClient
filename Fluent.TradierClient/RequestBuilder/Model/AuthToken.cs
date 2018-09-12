namespace Fluent.TradierClient.RequestBuilder.Model
{
    /// <summary>
    /// Authentication token for Tradier.
    /// </summary>
    public class AuthToken
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AuthToken"/> class.
        /// </summary>
        /// <param name="url">The URL.</param>
        /// <param name="accessKey">The access key.</param>
        public AuthToken(string url, string accessKey)
        {
            BaseUrl = url;
            AccessKey = accessKey;
        }

        /// <summary>
        /// Gets or sets the access key.
        /// </summary>
        /// <value>
        /// The access key.
        /// </value>
        public string AccessKey { get; set; }

        /// <summary>
        /// Gets or sets the base URL.
        /// </summary>
        /// <value>
        /// The base URL.
        /// </value>
        public string BaseUrl { get; set; }
    }
}