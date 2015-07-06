using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Code
{
    public class RegularExpressionMatching
    {
        public bool IsMatch(string s, string p)
        {
            var autoMachineChars = new char[p.Length];
            var autoMachinePatterns = new bool[p.Length];
            var matchIndex = 0;
            var lastNotEmptyable = -1;
            for (var index = 0; index < p.Length; index++)
            {
                autoMachineChars[matchIndex] = p[index];
                autoMachinePatterns[matchIndex] = index + 1 == p.Length
                    ? (lastNotEmptyable = matchIndex) < 0
                    : (p[index + 1] == '*' && ++index > 0 || (lastNotEmptyable = matchIndex) < 0);

                for (var checkEnd = matchIndex - 1;
                    checkEnd >= 0
                    && matchIndex > 0
                    && autoMachinePatterns[checkEnd + 1];
                    checkEnd -= checkEnd > matchIndex
                        ? checkEnd - matchIndex + 1
                        : 1)
                {
                    var repeatIndex = matchIndex;
                    var checkIndex = checkEnd;

                    while (repeatIndex > checkEnd
                        && checkIndex >= 0)
                        if (autoMachinePatterns[checkIndex]
                            && (autoMachineChars[repeatIndex] == '.'
                                || autoMachineChars[repeatIndex] == autoMachineChars[checkIndex]))
                            checkIndex--;
                        else
                            repeatIndex--;

                    if (checkIndex < 0)
                        repeatIndex--;

                    if (repeatIndex == checkEnd
                        && checkIndex < checkEnd)
                    {
                        var replaceCount = matchIndex - repeatIndex;
                        var replacedEnd = checkIndex + replaceCount;
                        var replaceIndex = repeatIndex + 1;
                        for (var replacedIndex = checkIndex + 1
                            ; replacedIndex <= replacedEnd
                            ; replacedIndex++
                            , replaceIndex++)
                        {
                            autoMachineChars[replacedIndex] = autoMachineChars[replaceIndex];
                            autoMachinePatterns[replacedIndex] = autoMachinePatterns[replaceIndex];
                        }
                        matchIndex = replacedEnd;
                    }
                }

                for (var repeatEnd = 0;
                    repeatEnd < matchIndex
                    && repeatEnd >= 0
                    && autoMachinePatterns[repeatEnd];
                    repeatEnd++)
                {
                    var checkIndex = matchIndex;
                    var repeatIndex = repeatEnd;

                    while (repeatIndex >= 0
                        && checkIndex > repeatEnd)
                        if (autoMachinePatterns[checkIndex]
                            && (autoMachineChars[repeatIndex] == '.'
                                || autoMachineChars[repeatIndex] == autoMachineChars[checkIndex]))
                            checkIndex--;
                        else
                            repeatIndex--;

                    if (checkIndex == repeatEnd
                        && checkIndex < matchIndex)
                    {
                        matchIndex = repeatEnd;
                        break;
                    }
                }

                matchIndex++;
            }


            var matchIndexes = new List<int>() { -1 };

            foreach (var @char in s)
            {
                var newMatchIndexes = new List<int>();
                foreach (var index in matchIndexes)
                {
                    var freeIndex = index < 0
                        ? 0
                        : autoMachinePatterns[index]
                            ? index
                            : index + 1;

                    do
                        if (freeIndex < matchIndex
                            && (autoMachineChars[freeIndex] == '.'
                                || autoMachineChars[freeIndex] == @char))
                            newMatchIndexes.Add(freeIndex);
                    while (freeIndex < matchIndex
                        && autoMachinePatterns[freeIndex++]);
                }

                if (newMatchIndexes.Count == 0)
                    return false;

                matchIndexes = newMatchIndexes;
            }

            return matchIndexes
                .Any(index =>
                    index >= lastNotEmptyable);
        }
    }
}
