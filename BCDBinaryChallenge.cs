using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// https://www.sololearn.com/Discuss/653982/?ref=app

namespace SoloLearn
{
    class Program
    {
        static void Main(string[] zephyr_koo)
        {
            var input = Console.ReadLine();

            int limit;

            if (int.TryParse(input, out limit))
            {
                foreach (var number in Enumerable.Range(10, limit))
                {
                    var strNumBinary = Convert.ToString(number, 2);
                    var strNumBCD    = GetBCDString(number);

                    var strNumBCDLength = strNumBCD.Length;

                    var strNumTrimmedBCD = strNumBCD.Substring(strNumBCDLength - strNumBinary.Length);

                    if (strNumBinary.Count(c => c == '1') == strNumTrimmedBCD.Count(c => c == '1'))
                    {
                        Console.WriteLine($"Number : { number.ToString().PadLeft(strNumBCDLength, ' ') }");
                        Console.WriteLine($"Binary : { strNumBinary.PadLeft(strNumBCDLength, ' ') }");
                        Console.WriteLine($"BCD    : { strNumBCD } { Environment.NewLine }");
                    }
                }
            }
        }
        
        static string GetBCDString(int number)
        {
            var stack = new Stack<string>();

            while (number > 0)
            {
                stack.Push(Convert.ToString(number % 10, 2).PadLeft(4, '0'));

                number /= 10;
            }

            return string.Join(string.Empty, stack);
        }
    }
}
