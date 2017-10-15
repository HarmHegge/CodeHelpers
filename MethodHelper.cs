using System;

namespace CodeHelpers
{
    public static class MethodHelper
    {
        public static void ThrowIfNull<T>(T value, string valueName) where T:class
        {
            if(value == null)
            {
                throw new ArgumentNullException(valueName);
            }
        }

        public static void NotNull<T>(this T value, string valueName)
        {
            if (value == null)
            {
                throw new ArgumentNullException(valueName);
            }
        }
    }
}
