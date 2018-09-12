using System;
using System.Runtime.Serialization;

namespace Fluent.TradierClient.Exceptions
{
    /// <summary>
    /// Tradier request exception.
    /// </summary>
    /// <seealso cref="ApplicationException" />
    [Serializable]
    public class TradierRequestException
        : ApplicationException
    {
        /// <summary>
        /// The exception details
        /// </summary>
        public readonly AppExceptionModel ExceptionDetails;

        /// <summary>
        /// Initializes a new instance of the <see cref="TradierRequestException"/> class.
        /// </summary>
        /// <param name="typeOfError">The type of error.</param>
        /// <param name="url">The URL.</param>
        /// <param name="errorDetails">The error details.</param>
        public TradierRequestException(string typeOfError, Uri url, string errorDetails)
            : base(errorDetails)
        {
            ExceptionDetails = new AppExceptionModel(typeOfError, url);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TradierRequestException"/> class.
        /// </summary>
        /// <param name="info">The object that holds the serialized object data.</param>
        /// <param name="context">The contextual information about the source or destination.</param>
        protected TradierRequestException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }
    }
}