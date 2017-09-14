using System;
using System.Collections.Generic;
using System.Linq;

// https://www.sololearn.com/Discuss/691502/?ref=app

namespace SoloLearn
{
    class Program
    {
        static void Main(string[] zephyr_koo)
        {
            var upperCaseLetters = Enumerable.Range(0, 26).Select(n => (char)('A' + n));
            var lowerCaseLetters = Enumerable.Range(0, 26).Select(n => (char)('a' + n));

            Console.WriteLine("Before");
            Console.WriteLine();
            Console.WriteLine(string.Join(", ", upperCaseLetters));
            Console.WriteLine();
            Console.WriteLine(string.Join(", ", lowerCaseLetters));

            Console.WriteLine();

            Console.WriteLine("After");
            Console.WriteLine();
            Console.WriteLine(string.Join(", ", ToggleCase(upperCaseLetters)));
            Console.WriteLine();
            Console.WriteLine(string.Join(", ", ToggleCase(lowerCaseLetters)));
        }

        static IEnumerable<char> ToggleCase(IEnumerable<char> letters)
        {
            return letters.Select(l => (char)(l ^ 32));
        }
    }
}
