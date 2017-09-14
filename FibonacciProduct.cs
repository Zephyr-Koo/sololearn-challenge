using System;
using System.Collections.Generic;
using System.Linq;

// https://www.sololearn.com/Discuss/697164/?ref=app

namespace SoloLearn
{
    class Program
    {
        static void Main(string[] zephyr_koo)
        {
            var numberList = new List<ulong> { 1, 2 }; // starting case (ulong == UInt64)

            while (true)
            {
                var number = numberList[numberList.Count - 2] * numberList[numberList.Count - 1];

                if (number == ulong.MinValue) break; // overflow

                numberList.Add(number);
            }

            Console.WriteLine(string.Join(", ", numberList));
        }
    }
}
