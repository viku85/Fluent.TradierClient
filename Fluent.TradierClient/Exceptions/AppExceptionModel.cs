using System;

namespace Fluent.TradierClient.Exceptions
{
    /// <summary>
    /// Application exception model.
    /// </summary>
    [Serializable]
    public class AppExceptionModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AppExceptionModel"/> class.
        /// </summary>
        /// <param name="typeOfError">The type of error.</param>
        /// <param name="url">The URL.</param>
        public AppExceptionModel(string typeOfError, Uri url)
        {
            ErrorType = typeOfError;
            Url = url;
        }

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
        /// Gets or sets the error message.
        /// </summary>
        /// <value>
        /// The error message.
        /// </value>
        public string Message { get; set; }
    }
}