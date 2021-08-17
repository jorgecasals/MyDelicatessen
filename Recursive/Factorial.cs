namespace MyDelicatessen.RecursiveProblems
{
	public class FactorialAlgorithm
	{
		public int Factorial(int number)
		{
			if (number < 2)
				return 1;

			return number * FactorialRecursive(number - 1);
		}

		private int FactorialRecursive(int number)
		{
			int result = 1;
			while (number > 1)
			{
				result *= number--;
			}

			return result;
		}
	}
}