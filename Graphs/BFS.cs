//BFS: Space complexity: O(N),in DFS the Space complixity is O(1). But it could endup in cycles so we need to save an additional value per node. In infinity trees the DFS will go for branches and never comeback,
//so we would need to implement an additional check to until certain deep only.

using System.Collections.Generic;

namespace MyDelicatessen.Graphs
{
    public class Node { object Value; List<Node> Children; }
    //this is for trees. Not for graphs, will update it shortly.
    public void BFS(Node node)
    {
        Queue queue = new Queue();

        queue.Enqueue(node);

        while (!queue.IsEmpty)
        {
            Node current = queue.Dequeue();
            Console.WriteLine(current.Value);
            current.Children.Foreach(child => queue.Enqueue(child));
        }
    }
}