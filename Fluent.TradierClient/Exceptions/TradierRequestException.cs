using System;

namespace Fluent.TradierClient.Exceptions
{
    /// <summary>
    /// Tradier request exception.
    /// </summary>
    /// <seealso cref="ApplicationException" />
    public class TradierRequestException
        : ApplicationException
    {
        /// <summary>
        /// Gets the type of the error.
        /// </summary>
        /// <value>
        /// The type of the error.
        /// </value>
        public string ErrorType { get; private set; }

        /// <summary>
        /// Gets the URL.
        /// </summary>
        /// <value>
        /// The URL.
        /// </value>
        public Uri Url { get; private set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="TradierRequestException"/> class.
        /// </summary>
        /// <param name="typeOfError">The type of error.</param>
        /// <param name="url">The URL.</param>
        /// <param name="errorDetails">The error details.</param>
        public TradierRequestException(string typeOfError, Uri url, string errorDetails)
            : base(errorDetails)
        {
            ErrorType = typeOfError;
            Url = url;
        }
    }
}