using System;
using System.Collections.Generic;

// https://www.sololearn.com/Discuss/711001/?ref=app

namespace SoloLearn
{
    class Program
    {
        static Dictionary<char, char> BRACKET_PAIRS = new Dictionary<char, char>
        {
            { '<', '>' },
            { '(', ')' },
            { '[', ']' }
        };
        
        static void Main(string[] zephyr_koo)
        {
            int degree;
            
            foreach (var pattern in new string[]
            {
                "(()<<[]>>)",
                "<<>>()",
                "()<>[]",
                "[[<<(())>>]]",
                "((<>>[])",
                "(><)",
                "(<)>",
                "))(("
            })
            {
                Console.WriteLine(IsValidWrapping(pattern, out degree) ?
                    $"Yes!  ^_^ { pattern } with degree { degree }" :
                    $"Nope! -_- { pattern } "
                );
                Console.WriteLine(Environment.NewLine);
            }
        }
        
        static bool IsValidWrapping(string pattern, out int degree)
        {
            degree = 0;

            var stackOfBrackets = new Stack<char>();

            foreach (var bracket in pattern)
            {
                if (BRACKET_PAIRS.ContainsKey(bracket)) // is open bracket?
                {
                    stackOfBrackets.Push(bracket);
                }
                else if (stackOfBrackets.Count > 0)
                {
                    var previousBracket = stackOfBrackets.Pop();

                    if (BRACKET_PAIRS[previousBracket] != bracket) // is bracket match?
                        return false;
                }
                else  // begin with closing bracket
                {
                    return false;
                }

                if (stackOfBrackets.Count > degree) degree = stackOfBrackets.Count - 1;
            }

            return stackOfBrackets.Count == 0;
        }
    }
}
