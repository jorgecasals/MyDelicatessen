using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDelicatessen.LinkedList
{
    public class Solution
    {
        public bool HasCycle(ListNode head)
        {

            var slow = head;
            var fast = head;
            while (fast != null && fast.next != null)
            {

                fast = fast.next.next;

                slow = slow.next;

                if (fast == slow)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
