namespace MyDelicatessen.RecursiveProblems
{
	public class FibonnaciAlgorithm
	{
		public int FibonnaciIterative(int n)
		{
			int first = second = 1;

			while (n-- > 2)
			{
				int next = first + second;

				first = second;

				second = next;
			}

			return second;
		}

		public int FibonnaciRecursive(int n)
		{

			if (n <= 2)
				return 1;

			return FibonnaciRecursive(n - 1) + FibonnaciRecursive(n - 2);
		}
	}
}