using System;
using System.Linq;

// https://www.sololearn.com/Discuss/665964/?ref=app

namespace SoloLearn
{
    class Program
    {
        static void Main(string[] zephyr_koo)
        {
            var numberList       = { 2, 5, 7, 5, 6, 1, 3, 2, 6 };
            var uniqueNumberList = numberList.Distinct();

            Console.WriteLine($"Before : { string.Join(", ", numberList) }");
            Console.WriteLine($"After  : { string.Join(", ", uniqueNumberList) }");
        }
    }
}
