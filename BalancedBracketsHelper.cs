using System;
using System.Collections.Generic;

namespace IrisExercise
{
    internal static class BalancedBracketsHelper
    {
        internal static bool IsBalanced(string exp)
        {
            Dictionary<char, char> bracketPairs = new()
            {
                {')', '('},
                {'}', '{'},
                {']', '['}
            };

            Stack<char> stack = new();

            foreach (char c in exp)
            {
                if (bracketPairs.ContainsValue(c))
                {
                    stack.Push(c);
                }
                else if (bracketPairs.ContainsKey(c))
                {
                    if (stack.Count == 0 || stack.Pop() != bracketPairs[c])
                    {
                        return false;
                    }
                }
            }

            return stack.Count == 0;
        }
    }
}
