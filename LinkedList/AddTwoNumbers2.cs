namespace MyDelicatessen.LinkedList
{
    public class Solution
    {
        public ListNode AddTwoNumbers2(ListNode l1, ListNode l2)
        {
            return ReverseList(AddTwoNumbers1(ReverseList(l1), ReverseList(l2)));
        }
    }
}
