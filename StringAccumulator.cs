using System;
using System.Collections.Generic;
using System.Linq;

// https://www.sololearn.com/Discuss/687819/?ref=app

namespace SoloLearn
{
    class Program
    {
        static void Main(string[] zephyr_koo)
        {
            foreach (var str in new string[]
            {
                "abc", "ECxa", "XmkkucH", "SoloLearN", "QpYWffvYGGyaX"
            })
            {
                Console.WriteLine(str);
                Console.WriteLine(GetAccumulatedString(str) + Environment.NewLine);
            }
        }

        static string GetAccumulatedString(string str)
        {
            str = str.ToLower(); // optimize for repetitive usage of char.ToLower(c) in Enumerable.Repeat
            
            return string.Join("-", str.Select(
                    (c, i) => c.ToString().ToUpper() +
                              new string(Enumerable.Repeat(c, i).ToArray())
                   ));
        }
    }
}
