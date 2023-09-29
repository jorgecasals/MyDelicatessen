using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDelicatessen.Arrays
{
    public class RemoveElementProblem
    {
        public int RemoveElement(int[] nums, int val)
        {
            int index = Array.IndexOf(nums, val);
            if (index < 0)
                return nums.Length;

            for (int runner = index + 1; runner < nums.Length; runner++)
            {
                if (nums[runner] != val)
                {
                    nums[index++] = nums[runner];
                }
            }
            return index;
        }
    }
}
