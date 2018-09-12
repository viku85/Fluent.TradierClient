using Fluent.TradierClient.RequestBuilder.Market;
using Fluent.TradierClient.RequestBuilder.Model;
using System;

namespace Fluent.TradierClient.RequestBuilder
{
    /// <summary>
    /// Tradier request builder to make
    /// </summary>
    public class TradierBuilder
    {
        /// <summary>
        /// The live account Uri
        /// </summary>
        private const string Live = "https://api.tradier.com/v1/";

        /// <summary>
        /// The streaming Uri
        /// </summary>
        private const string Streaming = "https://stream.tradier.com/v1/";

        /// <summary>
        /// The sandbox Uri
        /// </summary>
        private const string Test = "https://sandbox.tradier.com/v1/";

        /// <summary>
        /// Gets or sets the authentication token.
        /// </summary>
        /// <value>
        /// The authentication token.
        /// </value>
        private AuthToken AuthToken { get; set; }

        /// <summary>
        /// Authentication token building.
        /// </summary>
        /// <param name="account">The account.</param>
        /// <param name="accessKey">The access key.</param>
        /// <returns><see cref="TradierBuilder"/> with authentication token.</returns>
        public static TradierBuilder WithAccount(AccountType account, string accessKey) =>
            new TradierBuilder().BuildAuthToken(GetUrl(account), accessKey);

        /// <summary>
        /// Live account authentication building.
        /// </summary>
        /// <param name="accessKey">The access key.</param>
        /// <returns><see cref="TradierBuilder"/> with authentication token.</returns>
        public static TradierBuilder WithLiveAccount(string accessKey) =>
            new TradierBuilder().BuildAuthToken(Live, accessKey);

        /// <summary>
        /// Sandbox account authentication building.
        /// </summary>
        /// <param name="accessKey">The access key.</param>
        /// <returns><see cref="TradierBuilder"/> with authentication token.</returns>
        public static TradierBuilder WithSandboxAccount(string accessKey) =>
                            new TradierBuilder().BuildAuthToken(Test, accessKey);

        /// <summary>
        /// Market request builder.
        /// </summary>
        /// <returns>Market request builder.</returns>
        public TradierMarketBuilder ForMarket() => new TradierMarketBuilder(AuthToken);

        /// <summary>
        /// Gets the URL based on supplied account.
        /// </summary>
        /// <param name="account">The account.</param>
        /// <returns>The account URL.</returns>
        /// <exception cref="NotSupportedException">AccountType</exception>
        private static string GetUrl(AccountType account)
        {
            switch (account)
            {
                case AccountType.Live:
                    return Live;

                case AccountType.Sandbox:
                    return Test;

                default:
                    throw new NotSupportedException($"{nameof(AccountType)} not supported.");
            }
        }

        /// <summary>
        /// Builds the authentication token.
        /// </summary>
        /// <param name="url">The URL.</param>
        /// <param name="accessKey">The access key.</param>
        /// <returns>Builds the authentication token.</returns>
        private TradierBuilder BuildAuthToken(string url, string accessKey) =>
            new TradierBuilder
            {
                AuthToken = new AuthToken(url, accessKey)
            };
    }
}