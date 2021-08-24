using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDelicatessen.LinkedList
{
    public class Solution
    {
        public ListNode GetIntersectionNode(ListNode headA, ListNode headB)
        {
            int countA = Count(headA);
            int countB = Count(headB);

            if (countA > countB)
            {
                while (countA > countB)
                {
                    headA = headA.next;
                    countA--;
                }
            }

            if (countB > countA)
            {
                while (countB > countA)
                {
                    headB = headB.next;
                    countB--;
                }
            }

            while (headA != headB)
            {

                headA = headA.next;
                headB = headB.next;
            }

            return headA == null ? headA : headB;
        }

        public int Count(ListNode head)
        {
            int count = 0;

            while (head != null)
            {
                head = head.next;
                count++;
            }

            return count;
        }

    }
}
