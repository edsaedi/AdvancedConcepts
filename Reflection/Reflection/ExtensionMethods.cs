using System;
using System.Collections.Generic;
using System.Text;

namespace Reflection
{
    static class ExtensionMethods
    {
        public static string Reverse(this string input)
        {
            var chars = input.ToCharArray();
            Array.Reverse(chars);
            return new string(chars);
        }

        public static string ToMrTTime(this DateTime time)
        {
            return "I pity the foo at " + time.ToString();
        }
    }
}
