namespace MyDelicatessen.SortingAlgorithms
{
	public class BubbleSortAlgorithm
	{
		public void BubbleSort(int[] numbers)
		{
			for (int i = 0; i < numbers.Length - 1; i++)
			{
				for (int j = 0; j < numbers.Length - 1 - i; j++)
				{
					if (numbers[j] > numbers[j + 1])
					{
						int temp = numbers[j];
						numbers[j] = numbers[i];
						numbers[i] = temp;
					}
				}
			}
		}
	}
}