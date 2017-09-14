using System;
using System.Collections.Generic;
using System.Linq;

// https://www.sololearn.com/Discuss/696268/?ref=app

namespace SoloLearn
{
    class Program
    {
        const int MAX = 4;
        
        static void Main(string[] zephyr_koo)
        {
            Enumerable.Range(1, MAX)
                .SelectMany(n => Enumerable.Repeat(n, n)).ToList()
                .ForEach(n => Console.Write(n));
        }
    }
}
