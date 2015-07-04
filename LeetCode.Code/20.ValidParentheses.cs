using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Code
{
    public class ValidParentheses
    {
        public bool IsValid(string s)
        {
            var stack = new Stack<char>();

            char pairChar = ' ';
            foreach (var @char in s)
            {
                switch (@char)
                {
                    case '(':
                    case '[':
                    case '{':
                        stack.Push(@char);
                        break;

                    case ')':
                        pairChar = '(';
                        goto default;
                    case ']':
                        pairChar = '[';
                        goto default;

                    case '}':
                        pairChar = '{';
                        goto default;

                    default:
                        if (stack.Count == 0)
                            return false;

                        if (stack.Peek() != pairChar)
                            return false;

                        stack.Pop();
                        break;
                }
            }

            return stack.Count == 0;
        }
    }
}
