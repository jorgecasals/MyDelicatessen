using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDelicatessen.LinkedList
{
    public class Solution1
    {
        public ListNode ReverseList(ListNode head)
        {
            if (head == null) return null;
            var next = head;
            var prev = next.next;
            next.next = null;

            while (prev != null)
            {
                var temp = prev.next;
                prev.next = next;
                next = prev;
                prev = temp;
            }

            return next;
        }
    }

    public class Solution2
    {
        public ListNode ReverseList(ListNode head)
        {//recursive (lost my solution)
            return null;
        }
    }
}
