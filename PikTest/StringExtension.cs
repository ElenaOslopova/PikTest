using System;
using System.Collections.Generic;
using System.Linq;
namespace PikTest
{
    public static class StringExtension
    {
        public static Dictionary<string, int> TryDivideByWordsWithCount(this string str, char separator = ' ')
        {
            if (string.IsNullOrWhiteSpace(str))
                return null;

            return str
                .ToLower()
                .Split(new[] { separator }, StringSplitOptions.RemoveEmptyEntries)
                .GroupBy(item => item)
                .ToDictionary(g => g.Key, g => g.Count());
        }
    }
}
