using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Code
{
    public class GenerateParentheses
    {
        public IList<string> GenerateParenthesis(int n)
        {
            var openParentheses = 0;
            var closeParentheses = 0;
            var stringBuilder = new StringBuilder(new string(' ', n * 2));
            var flags = new bool?[n * 2];

            var result = new List<string>();

            var index = 0;
            var end = n * 2;
            while (index >= 0)
            {
                switch(flags[index])
                {
                    case null:
                        if (openParentheses == n)
                            goto case true;
                        
                        flags[index] = true;
                        stringBuilder[index++] = '(';
                        openParentheses++;
                        break;

                    case true:
                        if (flags[index] ?? false)
                            openParentheses--;

                        if (openParentheses == closeParentheses)
                            goto default;

                        flags[index] = false;
                        stringBuilder[index++] = ')';
                        closeParentheses++;
                        break;

                    case false:
                        closeParentheses--;
                        goto default;
                    default:
                        flags[index--] = null;
                        break;
                }

                if (index == end)
                {
                    result.Add(stringBuilder.ToString());
                    index--;
                }
            }

            return result;
        }
    }
}
