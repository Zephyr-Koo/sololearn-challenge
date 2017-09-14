using System;
using System.Linq;

// https://www.sololearn.com/Discuss/698184/?ref=app

namespace SoloLearn
{
    class Program
    {
        static void Main(string[] zephyr_koo)
        {
            var input = "3"; //Console.ReadLine();
            int number;

            if (Int32.TryParse(input, out number))
            {
                DisplayMultiplicationTable(number);
            }
        }
        
        static void DisplayMultiplicationTable(int number)
        {
            foreach(var multiplier in Enumerable.Range(1, 10))
            {
                Console.WriteLine($"{ number } x { multiplier.ToString().PadLeft(2, ' ') } = { number * multiplier }");
            }
        }
    }
}
