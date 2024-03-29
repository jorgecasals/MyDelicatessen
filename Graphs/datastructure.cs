using System;
using System.Collections.Generic;

namespace MyDelicatessen.Graphs
{
    ////Edge list
    //int[,] graph = new int[n, 2] { };

    ////Adjancent list
    //int[][] graph = new int[n][m]

    ////Adjancent matrix
    //bool[][] graph = new bool[n][m]

    public class Graph
    {
        private int numberOfNodes;
        private Dictionary<int, List<int>> adjacentList;



        public Graph()
        {
            this.numberOfNodes = 0;
            this.adjacentList = new Dictionary<int, List<int>>();
        }

        public void AddVertex(int node)
        {
            this.adjacentList.Add(node, new List<int>());
            this.numberOfNodes++;
        }

        public void AddEdge(int node1, int node2)
        {
            this.adjacentList[node1].Add(node2);
            this.adjacentList[node2].Add(node1);
        }

        public void ConsoleLogConnections()
        {
            var keys = this.adjacentList.Keys;
            foreach (var key in keys)
            {
                Console.WriteLine($"{key} -> {SerializeList(this.adjacentList[key])}");
            }
        }

        public string SerializeList(List<int> list)
        {
            return $"[{string.Join(',', list)}]";
        }


    }
}