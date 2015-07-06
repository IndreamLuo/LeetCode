using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Code
{
    public class LetterCombinationsOfAPhoneNumber
    {
        static Dictionary<char, string> digitLetters = new Dictionary<char, string>
        {
            { '2', "abc" }
            , { '3', "def" }
            , { '4', "ghi" }
            , { '5', "jkl" }
            , { '6', "mno" }
            , { '7', "pqrs" }
            , { '8', "tuv" }
            , { '9', "wxyz" }
            , { '0', " " }
        };

        public IList<string> LetterCombinations(string digits)
        {
            var digitLetters = LetterCombinationsOfAPhoneNumber.digitLetters;

            var stringBuilder = new StringBuilder(digits.Length);
            var indexes = new int[digits.Length];
            var letters = digits.Select(digit => digitLetters[digit]).ToList();
            for (var index = 0; index < digits.Length; index++)
                stringBuilder.Append(letters[index][0]);

            var currentIndex = 0;
            var result = new List<string>();
            while (currentIndex < digits.Length)
            {
                result.Add(stringBuilder.ToString());

                indexes[currentIndex]++;
                if (indexes[currentIndex] == letters[currentIndex].Length)
                {
                    do
                        currentIndex++;
                    while (currentIndex < digits.Length
                        && indexes[currentIndex] >= letters[currentIndex].Length - 1);

                    if (currentIndex == digits.Length)
                        continue;

                    indexes[currentIndex]++;
                    stringBuilder[currentIndex] = letters[currentIndex][indexes[currentIndex]];
                    for (var clearIndex = 0; clearIndex < currentIndex; clearIndex++)
                    {
                        indexes[clearIndex] = 0;
                        stringBuilder[clearIndex] = letters[clearIndex][0];
                    }

                    currentIndex = 0;
                }
                else
                    stringBuilder[currentIndex] = letters[currentIndex][indexes[currentIndex]];
            }

            return result;
        }
    }
}
