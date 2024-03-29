namespace MyDelicatessen.SortingAlgorithms
{
    public class BubbleSortAlgorithm
    {
        public int[] MergeSort(int[] numbers)
        {
            return MergeSort(numbers, 0, numbers.Length - 1);
        }

        private int[] MergeSort(int[] numbers, int initial, int final)
        {
            if (initial == final) return numbers;

            int middle = (initial + final) / 2;
            int[] firstPart = MergeSort(numbers, 0, middle);
            int[] secondPart = MergeSort(numbers, middle + 1, final);
            int[] result = new int[final - initial + 1];

            int firstIndex = 0;
            int secondIndex = 0;
            for (int i = 0; i < result.Length; i++)
            {
                if (firstIndex == firstPart.Length)
                {
                    result[i] = secondPart[secondIndex++];
                }
                else if (secondIndex == secondPart.Length || firstPart[firstIndex] <= secondPart[secondIndex])
                {
                    result[i] = firstPart[firstIndex++];
                }

                else
                {
                    result[i] = secondPart[secondIndex++];
                }
            }

            return result;
        }
    }
}