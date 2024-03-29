namespace MyDelicatessen.SortingAlgorithms
{
	public class SelectionSortAlgorithm
	{
		//Seletion sort
		public void SelectionSort(int[] numbers)
		{
			for (int i = 0; i < numbers.Length - 1; i++)
			{
				int minimumIndex = i;
				for (int j = i + 1; j < numbers.Length; j++)
				{
					if (numbers[minimumIndex] > numbers[j])
					{
						minimumIndex = j;
					}
				}
				int temp = numbers[i];
				numbers[i] = numbers[minimumIndex];
				numbers[minimumIndex] = temp;
			}
		}
	}
}