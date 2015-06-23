using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Code
{
    public class IntegerToRoman
    {
        static char[] numberLetters = new char[] { 'I', 'V', 'X', 'L', 'C', 'D', 'M', '\0', '\0' };

        static int[][] numberMatchPaterns = new int[][]
        {
            null,
            new int[] { 1, 1, 0, 0 },
            new int[] { 1, 2, 0, 0 },
            new int[] { 1, 3, 0, 0 },
            new int[] { 1, 1, 1, 0 },
            new int[] { 1, 0, 1, 0 },
            new int[] { -1, 1, 1, 0 },
            new int[] { -1, 2, 1, 0 },
            new int[] { -1, 3, 1, 0 },
            new int[] { 1, 1, 0, 1 }
        };

        static Dictionary<int, int> numberMatches = new Dictionary<int, int>()
        {
            { 1, 0 },
            { 10, 2 },
            { 100, 4 },
            { 1000, 6 }
        };

        public string IntToRoman(int num)
        {
            int number = num;
            int checkBase = 1000;
            var romanBuilder = string.Empty;
            while (checkBase > 0)
            {
                var digit = number / checkBase;
                number %= checkBase;
                if (digit > 0)
                {
                    var matches = IntegerToRoman.numberMatchPaterns[digit];
                    var index = matches[0] < 0
                        ? 3
                        : 1;
                    while (index > 0 && index < 4)
                    {
                        var letterIndex = IntegerToRoman.numberMatches[checkBase] + index - 1;
                        var letter = IntegerToRoman.numberLetters[letterIndex];
                        for (var addIndex = 0; addIndex < matches[index]; addIndex++)
                            romanBuilder += letter;
                        index += matches[0];
                    }
                }
                checkBase /= 10;
            }

            return romanBuilder;
        }
    }
}
