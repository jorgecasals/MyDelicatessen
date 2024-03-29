namespace MyDelicatessen.SortingAlgorithms
{
	public class InsertionSortAlgorithm
	{
		//InsertionSort
		public void InsertionSort(int[] numbers)
		{
			for (int i = 1; i < numbers.Length; i++)
			{
				int currentIndex = i;
				int current = numbers[currentIndex];
				while (currentIndex > 0 && current < numbers[currentIndex - 1])
				{
					numbers[currentIndex] = numbers[currentIndex - 1];
					currentIndex--;
				}
				numbers[currentIndex] = current;
			}
		}
	}
}