using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDelicatessen.LinkedList
{
    public class Solution
    {
        public ListNode AddTwoNumbers1(ListNode l1, ListNode l2)
        {
            ListNode result = new ListNode();
            int taken = 0;
            var resultIter = result;
            while (l1 != null || l2 != null)
            {
                resultIter.next = new ListNode();
                resultIter = resultIter.next;
                int sum = taken + (l1?.val ?? 0) + (l2?.val ?? 0);
                resultIter.val = sum % 10;
                taken = sum / 10;
                l1 = l1?.next;
                l2 = l2?.next;
            }
            if (taken == 1)
            {
                resultIter.next = new ListNode() { val = 1 };
            }

            return result.next;
        }
    }
}
