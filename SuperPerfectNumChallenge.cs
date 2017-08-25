using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//https://www.sololearn.com/Discuss/646305/?ref=app

namespace SoloLearn
{
    class Program
    {
        static void Main(string[] zephyr_koo)
        {
            var input = Console.ReadLine();
            
            int number;
            
            if (Int32.TryParse(input, out number))
            {
                Console.WriteLine($"Superperfect number(s) within { number } : { string.Join(", ", GetSuperPerfectNumber(number)) }");
            }
        }
        
        static IEnumerable<int> GetSuperPerfectNumber(int limit)
        {
            var perfNumberList = new List<int>();

            for (int n = 1; n <= limit; n++)
            {
                if (GetSumOfFactors(GetSumOfFactors(n)) == n * 2)
                {
                    perfNumberList.Add(n);
                }
            }
            
            return perfNumberList;
        }

        static int GetSumOfFactors(int number)
        {
            var sqrt = Math.Sqrt(number);

            return Enumerable
                    .Range(1, (int)sqrt)
                    .Where(n => (number % n == 0))
                    .Sum(n => n + (number / n)) -
                    (Math.Ceiling(sqrt) == Math.Floor(sqrt) ? (int)sqrt : 0); // remove double count for perfect square
        }
    }
}
