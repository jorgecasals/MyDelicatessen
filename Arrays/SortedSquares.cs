using System;

namespace MyDelicatessen.ArrayProblems
{
    /// <summary>
    /// Contains solutions for the problem of:
    /// <para>
    /// Given an array sorted in non-decreasing order, return an array of the squares of the numbers sorted in non-decreasing order
    /// </para>
    /// </summary>
    public class SortedSquaresProblem
    {
        /// <summary>
        /// Squares and sorts an array in O(n + log.n) time
        /// </summary>
        public int[] Solution_Trivial(int[] nums)
        {
            var result = new int[nums.Length];

            for (int i = 0; i < nums.Length; i++)
            {
                result[i] = nums[i] * nums[i];
            }

            Array.Sort(result);

            return result;
        }

        /// <summary>
        /// Squares and sorts an array in O(n) time
        /// </summary>
        public int[] Solution_Efficient(int[] nums)
        {
            var result = new int[nums.Length];
            var resultPointer = nums.Length - 1;

            var startPointer = 0;
            var endPointer = nums.Length - 1;

            while (startPointer < endPointer)
            {
                var startValue = Math.Abs(nums[startPointer]);
                var endValue = Math.Abs(nums[endPointer]);

                if (endValue > startValue)
                {
                    result[resultPointer--] = endValue * endValue;
                    endPointer--;
                }
                else if (endValue == startValue)
                {
                    result[resultPointer--] = endValue * endValue;
                    endPointer--;

                    result[resultPointer--] = endValue * endValue;
                    startPointer++;
                }
                else
                {
                    result[resultPointer--] = startValue * startValue;
                    startPointer++;
                }
            }

            if (resultPointer > -1)
            {
                var lastValue = nums[startPointer];
                result[resultPointer] = lastValue * lastValue;
            }

            return result;
        }
    }
}
