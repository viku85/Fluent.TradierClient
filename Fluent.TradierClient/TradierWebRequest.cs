using Fluent.TradierClient.Exceptions;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using static System.String;

namespace Fluent.TradierClient
{
    /// <summary>
    /// Tradier web request.
    /// </summary>
    /// <typeparam name="TRes">The type of the resource.</typeparam>
    public abstract class TradierWebRequest<TRes>
        where TRes : class
    {
        /// <summary>
        /// The access key
        /// </summary>
        protected readonly string AccessKey;

        /// <summary>
        /// The base URL
        /// </summary>
        protected readonly Uri BaseUrl;

        /// <summary>
        /// Initializes a new instance of the <see cref="TradierWebRequest{TRes}"/> class.
        /// </summary>
        /// <param name="baseUrl">The base URL.</param>
        /// <param name="accessToken">The access token.</param>
        /// <exception cref="ArgumentException">baseUrl</exception>
        /// <exception cref="ArgumentNullException">accessToken</exception>
        protected TradierWebRequest(string baseUrl, string accessToken)
        {
            if (!Uri.TryCreate(baseUrl, UriKind.Absolute, out BaseUrl))
            {
                throw new ArgumentException(nameof(baseUrl));
            }
            if (IsNullOrEmpty(accessToken))
            {
                throw new ArgumentNullException(nameof(accessToken));
            }
            AccessKey = accessToken;
        }

        /// <summary>
        /// Composes the extra settings for Tradier request.
        /// </summary>
        /// <param name="client">The client.</param>
        protected virtual void ComposeHttp(HttpClient client) { }

        /// <summary>
        /// Deserializes the JSON token for Tradier result.
        /// </summary>
        /// <param name="jToken">The JSON token.</param>
        /// <returns>The <see name="TRes"/>.</returns>
        protected virtual TRes Deserialize(JToken jToken)
        {
            return jToken?.ToObject<TRes>();
        }

        /// <summary>
        /// Safely deserialize JSON token to List of <typeparamref name="T"/>.
        /// </summary>
        /// <typeparam name="T">Type of the object</typeparam>
        /// <param name="token">The token.</param>
        /// <param name="tokenPath">The token path.</param>
        /// <returns>List of deserialize <typeparamref name="T"/></returns>
        protected List<T> SafeListDeserialize<T>(JToken token, string tokenPath)
        {
            var selectedToken = token?.SelectToken(tokenPath);
            if (selectedToken == null)
            {
                return null;
            }
            return selectedToken is JArray ?
                selectedToken.ToObject<List<T>>() : new List<T>() { selectedToken.ToObject<T>() };
        }

        /// <summary>
        /// Gets the Tradier response asynchronous.
        /// </summary>
        /// <returns>Response from Tradier.</returns>
        /// <exception cref="TradierRequestException">
        /// Bad Request
        /// or
        /// Request failed
        /// </exception>
        internal async Task<TRes> GetAsync()
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = BaseUrl;
                client.Timeout = new TimeSpan(0, 1, 0);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", AccessKey);

                ComposeHttp(client);

                var message = await client.GetAsync(RelativeUrl());

                if (message.IsSuccessStatusCode)
                {
                    var result = await message.Content.ReadAsStringAsync();
                    return Deserialize(result);
                }
                else if (message.ReasonPhrase.ToUpper() == "BAD REQUEST")
                {
                    throw new TradierRequestException(
                        "Bad Request",
                        message.RequestMessage.RequestUri,
                        await message.Content.ReadAsStringAsync());
                }
                else
                {
                    throw new TradierRequestException("Request failed",
                        message.RequestMessage.RequestUri,
                        message.ReasonPhrase);
                }
            }
        }

        /// <summary>
        /// Relative URL to make Tradier request.
        /// </summary>
        /// <returns></returns>
        protected abstract string RelativeUrl();

        /// <summary>
        /// Deserializes the specified json string.
        /// </summary>
        /// <param name="jsonString">The json string.</param>
        /// <returns>Deserialized <typeparamref name="TRes"/> model.</returns>
        private TRes Deserialize(string jsonString)
        {
            if (IsNullOrEmpty(jsonString))
            {
                return default(TRes);
            }
            var jObject = JToken.Parse(jsonString);
            return Deserialize(jObject);
        }
    }
}