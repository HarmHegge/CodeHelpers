using System;

namespace HHE.CodeHelpers
{
    /// <summary>
    /// Helper functions for verifying null-ness of parameters
    /// </summary>
    public static class MethodHelper
    {
        /// <summary>
        /// Checks the passed in value for <c>null</c>. Throws if it is <c>null</c>.
        /// </summary>
        /// <typeparam name="T">Type of the value</typeparam>
        /// <param name="value">Value to check.</param>
        /// <param name="valueName">Name of the value, used in the exception message</param>
        /// <exception cref="ArgumentNullException">
        /// Thrown if the passed in value is null.
        /// </exception>
        public static void ThrowIfNull<T>(T value, string valueName) where T : class
        {
            if (value == null)
            {
                throw new ArgumentNullException(valueName);
            }
        }

        /// <summary>
        /// Checks the passed in value for <c>null</c>. Throws if it is <c>null</c>.
        /// </summary>
        /// <typeparam name="T">Type of the value</typeparam>
        /// <param name="value">Value to check.</param>
        /// <param name="valueName">Name of the value, used in the exception message</param>
        /// <returns>the passed in value</returns>
        /// <exception cref="ArgumentNullException">
        /// Thrown if the passed in value is null.
        /// </exception>
        public static T NotNull<T>(this T value, string valueName) where T : class
        {
            ThrowIfNull(value, valueName);

            return value;
        }
    }
}
