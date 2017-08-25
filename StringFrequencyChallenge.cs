using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// https://www.sololearn.com/Discuss/654194/?ref=app

namespace SoloLearn
{
    class Program
	{
		static void Main(string[] zephyr_koo)
		{
			var input = "PROGRAMMING"; // Console.ReadLine();

            DisplayCharacterFrequency(input);
		}
		
		static void DisplayCharacterFrequency(string str)
        {
            foreach (var character in str.Distinct())
            {
                Console.WriteLine($"{ character } = { str.Count(c => c == character) }");
            }
        }
	}
}
