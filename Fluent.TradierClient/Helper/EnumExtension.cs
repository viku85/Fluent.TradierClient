using System;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;

namespace Fluent.TradierClient.Helper
{
    /// <summary>
    /// Enum helper functions.
    /// </summary>
    internal static class EnumExtension
    {
        /// <summary>
        /// To the member value.
        /// </summary>
        /// <typeparam name="TEnum">The type of the enum.</typeparam>
        /// <param name="value">The value.</param>
        /// <returns><see cref="EnumMemberAttribute"/>'s value.</returns>
        public static string ToMemberValue<TEnum>(this TEnum value)
                where TEnum : struct, IConvertible =>
                typeof(TEnum)
                .GetTypeInfo()
                .DeclaredMembers
                .SingleOrDefault(x => x.Name == value.ToString())
                ?.GetCustomAttribute<EnumMemberAttribute>(false)
                ?.Value;
    }
}