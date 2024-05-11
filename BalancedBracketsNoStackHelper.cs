namespace IrisExercise
{
    internal static class BalancedBracketsNoStackHelper
    {
        private static bool[] processed;
        private static int mostRecentOpeningIndex;

        internal static bool IsBalanced(string exp)
        {
            processed = Enumerable.Repeat(false, exp.Length).ToArray();
            mostRecentOpeningIndex = -1;

            for (int i = 0; i < exp.Length; i++)
            {
                char c = exp[i];
                if (IsOpeningBracket(c))
                {
                    mostRecentOpeningIndex = i;
                }
                else
                {
                    if (mostRecentOpeningIndex == -1 || !IsMatchingBracket(exp[mostRecentOpeningIndex], c))
                        return false;

                    processed[mostRecentOpeningIndex] = true;
                    mostRecentOpeningIndex = GetPreviousOpeningIndex(exp, mostRecentOpeningIndex);
                }
            }

            return mostRecentOpeningIndex == -1;
        }

        private static bool IsMatchingBracket(char openingBracket, char closingBracket)
        {
            switch (closingBracket)
            {
                case ')':
                    return openingBracket == '(';
                case '}':
                    return openingBracket == '{';
                case ']':
                    return openingBracket == '[';
                default:
                    return false;
            }
        }

        private static bool IsOpeningBracket(char c)
        {
            return c == '(' || c == '{' || c == '[';
        }

        private static int GetPreviousOpeningIndex(string exp, int currentIndex)
        {
            for (int i = currentIndex - 1; i >= 0; i--)
            {
                char c = exp[i];
                if (IsOpeningBracket(c) && !processed[i])
                {
                    return i;
                }
            }
            return -1;
        }
    }
}