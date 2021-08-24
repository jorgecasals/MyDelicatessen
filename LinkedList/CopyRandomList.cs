using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDelicatessen.LinkedList
{
    /*
// Definition for a Node.
public class Node {
    public int val;
    public Node next;
    public Node random;
    
    public Node(int _val) {
        val = _val;
        next = null;
        random = null;
    }
}
*/

    public class Solution
    {
        public Node CopyRandomList(Node head)
        {
            if (head == null) return null;

            Dictionary<Node, Node> oldToNew = new Dictionary<Node, Node>();
            Node current = head;
            while (current != null)
            {
                oldToNew[current] = new Node(current.val);
                current = current.next;
            }
            current = head;
            while (current != null)
            {
                oldToNew[current].next = current.next == null ? null : oldToNew[current.next];
                oldToNew[current].random = current.random == null ? null : oldToNew[current.random];
                current = current.next;
            }

            return oldToNew[head];
        }
    }
}
