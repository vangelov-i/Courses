namespace Kurskal
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class KruskalAlgorithm
    {
        public static List<Edge> Kruskal(int numberOfVertices, List<Edge> edges)
        {
            List<Edge> spanningTree = new List<Edge>();
            edges.Sort();

            // Initialize parents
            int[] parent = new int[numberOfVertices];
            for (int i = 0; i < numberOfVertices; i++)
            {
                parent[i] = i;
            }
            
            foreach (Edge edge in edges)
            {
                int startNodeRoot = FindRoot(edge.StartNode, parent);
                int endNodeRoot = FindRoot(edge.EndNode, parent);

                if (startNodeRoot != endNodeRoot)
                {
                    parent[startNodeRoot] = endNodeRoot;
                    spanningTree.Add(edge);
                }
            }

            return spanningTree;
        }

        static int FindRoot(int node, int[] parent)
        {
            // Find the root parent for the node
            int root = node;
            while (parent[root] != root)
            {
                root = parent[root];
            }

            // Optimize(compress) the path from node to root
            //while (node != root)
            //{
            //    var oldParent = parent[node];
            //    parent[node] = root;
            //    node = oldParent;
            //}

            return root;
        }
    }
}