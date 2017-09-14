using System;
using System.Collections.Generic;
using System.Linq;

// https://www.sololearn.com/Discuss/687526/?ref=app

namespace SoloLearn
{
    class Program
    {
        static readonly int[] CODE_SHEET      = new int[] { 11, 13, 8, 10, 12, 16 };
        static readonly int[] KNOWN_SAFE_PASS = new int[] { 4, 6, 8 };
            
        static void Main(string[] zephyr_koo)
        {
            int csCursor         = 0;
            int ksCursor         = 0;
            int matchCount       = 1;
            int commonDifference = CODE_SHEET[csCursor++] - KNOWN_SAFE_PASS[ksCursor++];
            
            do
            {
                int currentDifference = CODE_SHEET[csCursor] - KNOWN_SAFE_PASS[ksCursor];

                if (currentDifference == commonDifference)
                {
                    ksCursor++;
                    matchCount++;
                }
                else
                {
                    matchCount = 1;
                    csCursor  -= ksCursor - 1;
                    ksCursor   = 0;

                    commonDifference = CODE_SHEET[csCursor] - KNOWN_SAFE_PASS[ksCursor++];
                }

                if (matchCount == KNOWN_SAFE_PASS.Length) break;

                csCursor++;
                
            } while (csCursor < CODE_SHEET.Length);
            
            Console.WriteLine($"Yay! The safe pass is { string.Join(" ", CODE_SHEET.Select(p => p - commonDifference)) } with offset { commonDifference }.");
        }
    }
}
