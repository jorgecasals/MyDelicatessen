using System.Collections.Generic;

namespace MyDelicatessen.DynamicProgramming
{
    public class HouseRobberSolution
    {
        Dictionary<int, int> cache = new Dictionary<int, int>();

        public int Rob(int[] nums)
        {
            return Rob(nums, 0);
        }

        private int Rob(int[] nums, int index)
        {

            if (cache.HasKey(index))
            {
                return cache[key];
            }

            if (index >= nums.Length)
            {
                return 0;
            }

            int resultIncludingIndex = nums[index] + Rob(nums, index + 2);
            int resultExcudingIndex = Rob(index + 1);
            int maximumResult = Math.Max(resultIncludingIndex, resultExcludingIndex);
            cache.Add(index, maximumResult);
            return maximumResult;
        }
    }
}
