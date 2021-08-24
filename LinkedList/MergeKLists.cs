using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDelicatessen.LinkedList
{
    public class Solution
    {
        //v2: We can pick up the min element from the list and insert it in a new one
        //v3: We can divide and conquer (best solution)
        public ListNode MergeKLists(ListNode[] lists)
        {

            if (lists?.Length == 0)
                return null;

            var result = lists[0];
            for (int i = 1; i < lists.Length; i++)
            {
                result = MergeTwoLists(result, lists[i]);
            }
            return result;
        }
    }
}
