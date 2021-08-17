
using System;
using System.Collections.Generic;

namespace MyDelicatessen.Trees
{
    public class TreeDFS
    {
        public class Node { public object Value; public List<Node> Children; }

        //this is for trees. Not for graphs, will update it shortly.
        public void DFS(Node current)
        {
            if (current == null)
            {
                return;
            }

            Console.WriteLine(current.Value);

            current.Children.ForEach(child => DFS(current));
        }
    }
}