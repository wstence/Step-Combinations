using System;
//Adapted from recursion example in Cracking the Coding Interview v6. Originally in Java.
namespace Step_Combo
{
	public class CalculateSteps {
		public static int Steps(int m){
			int[] memo = new int[m + 1];
			for (int i = 0; i < m + 1; i++) {
				memo [i] = -1;
			}
			return Steps(m, memo);
		}
		public static int Steps(int m, int []memo)
		{
			if (m < 0)
				return 0;
			else if (m == 0)
				return 1;
			else if (memo [m] > -1)
				return memo [m];
			else {
				memo [m] = Steps (m - 1, memo) + Steps (m - 2, memo) + Steps (m - 3, memo);
				return memo [m];
			}
		}
	}
	class MainClass
	{
		public static void Main (string[] args)
		{
			int result;
			int n = 5;
			//CalculateSteps s1 = new CalculateSteps (n);
			result = CalculateSteps.Steps (n);
			Console.WriteLine ("Result: {0}", result);
		}
	}
}