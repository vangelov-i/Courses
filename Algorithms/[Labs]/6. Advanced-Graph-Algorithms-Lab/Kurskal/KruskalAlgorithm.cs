namespace Kurskal
{
    using System;
    using System.Collections.Generic;

    public class KruskalAlgorithm
    {
        private static List<Edge> primTree;
        private static List<Tuple<int, int>>[] spanningTreeVerticies;

        public static List<Edge> Kruskal(int numberOfVertices, List<Edge> edges)
        {
            //throw new NotImplementedException();
            var vertecies = new List<Tuple<int, int>>[numberOfVertices];
            for (int i = 0; i < edges.Count; i++)
            {
                var currentEdge = edges[i];
                if (vertecies[currentEdge.StartNode] == null)
                {
                    vertecies[currentEdge.StartNode] = new List<Tuple<int, int>>();
                }

                vertecies[currentEdge.StartNode]
                    .Add(new Tuple<int, int>(currentEdge.EndNode, currentEdge.Weight));
            }

            spanningTreeVerticies = new List<Tuple<int, int>>[numberOfVertices];

            primTree = new List<Edge>();
            for (int i = 0; i < vertecies.Length; i++)
            {
                var currentVertex = vertecies[i];
                if (spanningTreeVerticies[i] == null)
                {
                    Prim(currentVertex, i);
                }
            }

            return primTree;
        }

        private static void Prim(List<Tuple<int, int>> vertex, int index)
        {
            spanningTreeVerticies[index] = vertex;
            // Heap needed for priority queue
        }

        public static int FindRoot(int node, int[] parent)
        {
            return 0;
            //throw new NotImplementedException();
        }
    }
}
