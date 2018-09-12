using Fluent.TradierClient.RequestBuilder;
using Fluent.TradierClient.RequestBuilder.Model;
using System;

namespace Fluent.TradierClient
{
    /// <summary>
    /// Base builder class to compose Tradier request command.
    /// </summary>
    /// <typeparam name="TCmd">The type of the command.</typeparam>
    /// <seealso cref="IBuild{TCmd}" />
    public abstract class Builder<TCmd>
        : IBuild<TCmd>
        where TCmd : AuthToken
    {
        /// <summary>
        /// The command
        /// </summary>
        protected TCmd Command;

        /// <summary>
        /// Initializes a new instance of the <see cref="Builder{TCmd}"/> class.
        /// </summary>
        protected Builder()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Builder{TCmd}"/> class.
        /// </summary>
        /// <param name="cmd">The command.</param>
        /// <exception cref="ArgumentNullException">cmd</exception>
        protected Builder(TCmd cmd)
        {
            Command = cmd ?? throw new ArgumentNullException(nameof(cmd));
        }

        /// <summary>
        /// Gets a completely new <typeparamref name="TCmd"/>.
        /// </summary>
        /// <value>
        /// The a completely new <typeparamref name="TCmd"/>.
        /// </value>
        private Func<TCmd> DeepCopy => () => Clone(Command);

        /// <summary>
        /// Builds this <typeparamref name="TCmd"/>.
        /// </summary>
        /// <returns>New <typeparamref name="TCmd"/>.</returns>
        public TCmd Build() => DeepCopy();

        /// <summary>
        /// Creates a completely new instance of passed <paramref name="cmd"/>.
        /// </summary>
        /// <param name="cmd">The existing command.</param>
        /// <returns>New <see name="TCmd"/>.</returns>
        protected abstract TCmd Clone(TCmd cmd);

        /// <summary>
        /// Clones to the object based on specified command composer.
        /// </summary>
        /// <param name="commandComposer">The command composer.</param>
        /// <returns>New <typeparamref name="TCmd"/>.</returns>
        protected TCmd Clone(Action<TCmd> commandComposer)
        {
            var defaultObject = Clone(Command);
            commandComposer(defaultObject);
            return defaultObject;
        }
    }
}