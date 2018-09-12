namespace Fluent.TradierClient.RequestBuilder.Market.TimeAndSale
{
    /// <summary>
    /// The session conditions
    /// </summary>
    public enum SessionFilter
    {
        /// <summary>
        /// Available data points (default)
        /// </summary>
        All,

        /// <summary>
        /// Data points within open market hours only
        /// </summary>
        Open
    }
}