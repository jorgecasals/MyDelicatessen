namespace MyDelicatessen.ArrayProblems
{
    //merge sorted arrays ([0,3,4,31], [4, 6, 30]) -> [0, 3, 4, 4, 6, 30, 31]
    //questions: Can the arrays contains a type different from numbers? Do they come from memory or from stream?
    /*description:
        Create one array with the length of both arrays, then save value by value from the minor value between two arrays increasing the index of each array per array selected.
    */
    public class MergeSortedArrayProblem
    {
        public class Solution1
        {
            public int[] MergeSortedArray(int[] array1, int[] array2)
            {
                int totalLength = array1.Length + array2.Length;
                int[] mergedValues = new int[totalLength];

                int index1 = 0;
                int index2 = 0;

                while (index1 + index2 < totalLength)
                {
                    int valueToInsert = 0;
                    if (index1 == array1.Length)
                    {
                        valueToInsert = array2[index2++];
                    }
                    else if (index2 == array2.Length)
                    {
                        valueToInsert = array1[index1++];
                    }
                    else
                    {
                        valueToInsert = array1[index1] < array2[index2] ? array1[index1++] : array2[index2++];
                    }
                }

                return mergedValues;
            }
        }

        public class Solution2
        {
            public int[] MergeSortedArray(int[] array1, int[] array2)
            {
                int totalLength = array1.Length + array2.Length;
                int[] mergedValues = new int[totalLength];

                int index1 = 0;
                int index2 = 0;
                int valuesIndex = 0;

                while (index1 < array1.Length && index2 < array2.Length)
                {
                    mergedValues[valuesIndex++] = array1[index1] < array2[index2] ? array1[index1++] : array2[index2++];
                }
                while (index1 < array1.Length)
                {
                    mergedValues[valuesIndex++] = array1[index1++];
                }
                while (index2 < array2.Length)
                {
                    mergedValues[valuesIndex++] = array2[index2++];
                }

                return mergedValues;
            }
        }
    }
}
