using System;
using System.Collections.Generic;
using System.Linq;

// https://www.sololearn.com/Discuss/666260/?ref=app

namespace SoloLearn
{
    class Program
    {
        static void Main(string[] zephyr_koo)
        {
            DisplayCircularSum(new int[] { 1, 3, 4 }, 5);      // Case 1
            DisplayCircularSum(new int[] { 1, 6, 7, 8 }, 3);   // Case 2
            DisplayCircularSum(new int[] { 4, 5 }, 5);         // Case 3
            DisplayCircularSum(new int[] { 2, -4, 6, -7 }, 5); // Case 4
        }

        static void DisplayCircularSum(int[] numList, int count)
        {
            var len = numList.Length;

            var sumArray = Enumerable.Range(0, len)
                            .Select(n =>
                                Enumerable.Range(n, count)
                                    .Sum(i => numList[i % len]));

            Console.WriteLine(string.Join(", ", sumArray));
        }

        /// <summary>
        ///     This alternative was used to demonstrate the idea for the
        ///     full LINQ solution above if you couldn't follow it.
        /// </summary>
        /// <param name="numList"></param>
        /// <param name="count"></param>
        static void DisplayCircularSum_PartialLINQ(int[] numList, int count)
        {
            var len      = numList.Length;
            var sumArray = new List<int>();

            for (int i = 0; i < len; i++)
            {
                var partialSum = Enumerable.Range(i, count)
                                    .Sum(n => numList[n % len]);

                sumArray.Add(partialSum);
            }

            Console.WriteLine(string.Join(", ", sumArray));
        }
    }
}
