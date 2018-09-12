namespace Fluent.TradierClient.RequestBuilder
{
    /// <summary>
    /// Generic implementation of Builder.
    /// </summary>
    /// <typeparam name="TCmd">The type of the command.</typeparam>
    public interface IBuild<out TCmd>
    {
        /// <summary>
        /// Builds the new instance of command.
        /// </summary>
        /// <returns>New instance of command.</returns>
        TCmd Build();
    }
}