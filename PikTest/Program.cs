using System;
using System.Collections.Generic;

namespace PikTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var str = "А в ГК ПИК есть комната пик";
            var result = str.TryDivideByWordsWithCount();

            foreach (var item in result)
            {
                PrintToConsole(item);
            }

            Console.ReadKey();
        }

        private static void PrintToConsole<TKey, TValue>(KeyValuePair<TKey, TValue> item)
        {
            Console.WriteLine($"{item.Key}:{item.Value}");
        }
    }
}
