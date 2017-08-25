using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// https://www.sololearn.com/Discuss/625282/?ref=app

namespace SoloLearn
{
    class Program
    {
        const int NUMBER_BASE = 256;
        
        static void Main(string[] zephyr_koo)
        {
            //var input = Console.ReadLine();
            Console.WriteLine(GetBaseNRepresentation(NUMBER_BASE, "hi"));
            Console.WriteLine(GetReverseBaseNRepresentation(NUMBER_BASE, 1701013870));
            
            Console.WriteLine(GetReverseRepresentation(1701013870)); // inspired by VcC
        }
        
        static double GetBaseNRepresentation(int baseNum, string input)
        {
            return Enumerable.Range(1, input.Length).Sum(n => input[n - 1] * Math.Pow(baseNum, n - 1));
        }
        
        static string GetReverseBaseNRepresentation(int baseNum, int input)
        {
            var sb = new StringBuilder();
            
            while(input > 0)
            {
                int quotient = input / baseNum;
                
                sb.Append((char)(input - (quotient * baseNum)));
                
                input = quotient;
            }
            
            return sb.ToString();
        }
        
        static string GetReverseRepresentation(int input)
        {
            var sb = new StringBuilder();
            
            while (input > 0)
            {
                sb.Append((char)(input & 255));
                input >>= 8;
            }
            
            return sb.ToString();
        }
    }
}
