namespace AStarAlgorithm
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class AStar
    {
        private readonly char[,] map;
        private HashSet<Node> visited;
        private int[] endCoords = new int[2];

        public AStar(char[,] map)
        {
            this.visited = new HashSet<Node>();
            this.map = map;
        }

        public List<int[]> FindShortestPath(int[] startCoords, int[] endCoords)
        {
            this.endCoords = endCoords;
            var startNode = new Node(startCoords[0], startCoords[1]);
            startNode.Parent = startNode;
            startNode.GCost = 0;
            startNode.HCost = this.GetHCost(startNode.Row, startNode.Col);

            this.visited.Add(startNode);
            PriorityQueue<Node> priorityQueue = new PriorityQueue<Node>();
            priorityQueue.Enqueue(startNode);
            while (priorityQueue.Count > 0)
            {
                var currentNode = priorityQueue.ExtractMin();
                if (currentNode.Row == endCoords[0] && currentNode.Col == endCoords[1])
                {
                    break;
                }

                currentNode.Neighbours = this.GetNeighbours(currentNode);
                foreach (Node neighbour in currentNode.Neighbours)
                {
                    if (!this.visited.Contains(neighbour))
                    {
                        priorityQueue.Enqueue(neighbour);
                        this.visited.Add(neighbour);
                    }

                    int newGCost = Math.Abs(currentNode.Row - neighbour.Row) != 0 && Math.Abs(currentNode.Col - neighbour.Col) != 0 ? currentNode.GCost + 14 : currentNode.GCost + 10;

                    if (newGCost < neighbour.GCost)
                    {
                        neighbour.GCost = newGCost;
                        neighbour.Parent = currentNode;
                        priorityQueue.DecreaseKey(neighbour);
                    }
                }
            }

            Node current = this.visited.FirstOrDefault(n => n.Row == endCoords[0] && n.Col == endCoords[1]);
            if (current == null)
            {
                return null;
            }

            List<int[]> path = new List<int[]>();
            while (!current.Parent.Equals(current))
            {
                path.Add(new []{current.Row, current.Col});
                current = current.Parent;
            }

            path.Add(new [] {current.Row, current.Col});

            return path;
        }

        private List<Node> GetNeighbours(Node node)
        {
            var neighbours = new List<Node>();
            neighbours.Add(this.GetNeighbour(node, 1, -1));
            neighbours.Add(this.GetNeighbour(node, 1, 0));
            neighbours.Add(this.GetNeighbour(node, 1, 1));
            neighbours.Add(this.GetNeighbour(node, 0, 1));
            neighbours.Add(this.GetNeighbour(node, -1, 1));
            neighbours.Add(this.GetNeighbour(node, -1, 0));
            neighbours.Add(this.GetNeighbour(node, -1, -1));
            neighbours.Add(this.GetNeighbour(node, 0, -1));

            neighbours = neighbours.Where(n => n != null).ToList();

            return neighbours;
        }

        private Node GetNeighbour(Node node, int rowOffset, int colOffset)
        {
            Node result = null;

            int resultRow = node.Row + rowOffset;
            int resultCol = node.Col + colOffset;

            if (this.CellIsNode(resultRow, resultCol))
            {
                result = this.visited.FirstOrDefault(n => n.Row == resultRow && n.Col == resultCol);
                if (result == null)
                {
                    result = new Node(resultRow, resultCol);
                    result.GCost = rowOffset != 0 && colOffset != 0 ? node.GCost + 14 : node.GCost + 10;
                    result.HCost = GetHCost(resultRow, resultCol);
                    result.Parent = node;

                    return result;
                }
            }

            return result;
        }

        private bool CellIsNode(int row, int col)
        {
            bool rowIsInRange = row >= 0 && row < this.map.GetLength(0);
            bool colIsInRange = col >= 0 && col < this.map.GetLength(1);

            bool cellIsNode = rowIsInRange && colIsInRange && this.map[row, col] != 'W';

            return cellIsNode;
        }

        private int GetHCost(int startRow, int startCol)
        {
            int endRow = this.endCoords[0];
            int endCol = this.endCoords[1];

            int hCost = 0;

            int deltaX = Math.Abs(startRow - endRow);
            int deltaY = Math.Abs(startCol - endCol);
            if (deltaX > deltaY)
            {
                hCost = deltaY * 14 + (deltaX - deltaY) * 10;
            }
            else
            {
                hCost = deltaX * 14 + (deltaY - deltaX) * 10;
            }

            return hCost;
        }
    }
}