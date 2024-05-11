using IrisExercise;

string exp1 = "[()]{}{[()()]()}";
string exp2 = "[(])";

Console.WriteLine("Expression " + exp1 + " is " + (BalancedBracketsNoStackHelper.IsBalanced(exp1) ? "Balanced" : "Not Balanced"));
Console.WriteLine("Expression " + exp2 + " is " + (BalancedBracketsNoStackHelper.IsBalanced(exp2) ? "Balanced" : "Not Balanced"));


int[] set1 = [2, 2, 1];
int[] set2 = [4, 1, 2, 1, 2];
int[] set3 = [1];

Console.WriteLine("Unique number in set: [" + string.Join(", ", set1) + "] is " + SingleNumberHelper.GetUniqueNumberLinq(set1));
Console.WriteLine("Unique number in set: [" + string.Join(", ", set2) + "] is " + SingleNumberHelper.GetUniqueNumberLinq(set2));
Console.WriteLine("Unique number in set: [" + string.Join(", ", set3) + "] is " + SingleNumberHelper.GetUniqueNumberLinq(set3));

Console.WriteLine("Unique number in set: [" + string.Join(", ", set1) + "] is " + SingleNumberHelper.GetUniqueNumber(set1));
Console.WriteLine("Unique number in set: [" + string.Join(", ", set2) + "] is " + SingleNumberHelper.GetUniqueNumber(set2));
Console.WriteLine("Unique number in set: [" + string.Join(", ", set3) + "] is " + SingleNumberHelper.GetUniqueNumber(set3));

Console.ReadLine();
