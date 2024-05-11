
namespace IrisExercise
{
    internal static class SingleNumberHelper
    {
        internal static int GetUniqueNumberLinq(int[] numbers)
        {
            return numbers.GroupBy(x => x).Where(g => g.Count() == 1).Select(g => g.Key).FirstOrDefault();
        }

        internal static int GetUniqueNumber(int[] numbers)
        {
            HashSet<int> uniqueNumbers = [];
            foreach (int n in numbers)
            {
                if (uniqueNumbers.Contains(n))
                {
                    uniqueNumbers.Remove(n);
                }
                else
                {
                    uniqueNumbers.Add(n);
                }
            }
            return uniqueNumbers.FirstOrDefault();
        }
    }
}
