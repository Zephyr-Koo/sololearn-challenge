using System;
using System.Collections.Generic;
using System.Linq;

// https://www.sololearn.com/Discuss/704469/?ref=app

namespace SoloLearn
{
    class Program
    {
        static readonly Dictionary<char, string> DICTIONARY = new Dictionary<char, string>
        {
            { 'p', "pP"  },
            { 'a', "aA@" },
            { 's', "sS5" },
            { 'w', "wW"  },
            { 'o', "oO0" },
            { 'r', "rR"  },
            { 'd', "dD"  }
        };
        
        static void Main(string[] zephyr_koo)
        {
            var p = DICTIONARY.Single(c => c.Key == 'p').Value.ToCharArray();
            var a = DICTIONARY.Single(c => c.Key == 'a').Value.ToCharArray();
            var s = DICTIONARY.Single(c => c.Key == 's').Value.ToCharArray();
            var w = DICTIONARY.Single(c => c.Key == 'w').Value.ToCharArray();
            var o = DICTIONARY.Single(c => c.Key == 'o').Value.ToCharArray();
            var r = DICTIONARY.Single(c => c.Key == 'r').Value.ToCharArray();
            var d = DICTIONARY.Single(c => c.Key == 'd').Value.ToCharArray();
            
            var result_QuerySyntax = from c1 in p
                                     from c2 in a
                                     from c3 in s
                                     from c4 in s
                                     from c5 in w
                                     from c6 in o
                                     from c7 in r
                                     from c8 in d
                                     select new string(new char[] { c1, c2, c3, c4, c5, c6, c7, c8 });
                                     
            // Look how ugly the method syntax is =(
            var result_MethodSyntax = p.SelectMany(
                                        c1 => a.SelectMany(
                                        c2 => s.SelectMany(
                                        c3 => s.SelectMany(
                                        c4 => w.SelectMany(
                                        c5 => o.SelectMany(
                                        c6 => r.SelectMany(
                                        c7 => d.Select(
                                        c8 => new string(new char[] { c1, c2, c3, c4, c5, c6, c7, c8 })
                                      ))))))));
                                     
            Console.WriteLine($"Result count (Query)  : { result_QuerySyntax.Count() }");
            Console.WriteLine($"Result count (Method) : { result_MethodSyntax.Count() }");
            //Print(result_QuerySyntax); // Time limit exceeded at Line 400+
            //Print(result_MethodSyntax); // Time limit exceeded at Line 400+
        }
        
        static void Print(IEnumerable<string> strList)
        {
            Console.WriteLine(string.Join(Environment.NewLine, strList));
        }
    }
}
