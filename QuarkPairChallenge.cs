using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// https://www.sololearn.com/Discuss/622449/?ref=app

namespace SoloLearn
{
    class Program
    {
        static void Main(string[] zephyr_koo)
        {
           var input1 = Console.ReadLine();
           var input2 = Console.ReadLine();
           
           int num1, num2;
           
           if (Int32.TryParse(input1, out num1) && Int32.TryParse(input2, out num2) && IsQuarkPair(num1, num2))
           {
               Console.WriteLine("Yass we have found a Quark Pair! (^__^)Y");
           }
           else
           {
              Console.WriteLine("Nope. (x__x)");
           }
        }
        
        static bool IsQuarkPair(int num1, int num2)
        {
            return GetQuarkNumber(num1) == GetQuarkNumber(num2);
        }
        
        static int GetQuarkNumber(int num)
        {
            return num * GetCountOfTwo(num);
        }
        
        static int GetCountOfTwo(int num)
        {
            return Convert.ToString(num, 2).Count(c => c == '1');
            
            /*
            int count = 0;
            for (uint currentPow = 1; currentPow != 0; currentPow <<= 1)
            {
                if ((currentPow & num) != 0) count++;
            }
            
            return count;*/
        }
    }
}
