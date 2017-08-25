using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// https://www.sololearn.com/Discuss/626739/?ref=app

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
                Console.WriteLine($"{ GetNthFlynNumber(number) } is the no. { number } flyn number. ^_^");
            }
        }
        
        static int GetNthFlynNumber(int nth)
        {
            int count = 0, num = 0;

            while (count != nth)
            {
                num++;

                if (IsFlynNumber(num))
                    count++;
            }

            return num;
        }

        static bool IsFlynNumber(int num)
        {
            return GetDigitSum(num) == GetDigitSum(num * num / 3);
        }

        static double GetDigitSum(int num)
        {
            return num.ToString().Sum(d => char.GetNumericValue(d));
        }
    }
}
