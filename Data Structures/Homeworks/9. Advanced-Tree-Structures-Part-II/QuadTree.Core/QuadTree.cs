namespace QuadTree.Core
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class QuadTree<T> where T : IBoundable
    {
        public const int DefaultMaxDepth = 5;

        public readonly int MaxDepth;

        private Node<T> root;

        public QuadTree(int width, int height, int maxDepth = DefaultMaxDepth)
        {
            this.root = new Node<T>(0, 0, width, height);
            this.Bounds = this.root.Bounds;
            this.MaxDepth = maxDepth;
        }

        public int Count { get; private set; }

        public Rectangle Bounds { get; private set; }

        public bool Insert(T item)
        {
            if (!item.Bounds.IsInside(this.root.Bounds))
            {
                return false;
            }

            int depth = 1;
            var currentNode = this.root;
            while (currentNode.Children != null)
            {
                int quadrant = this.GetQuadrant(currentNode, item.Bounds);
                if (quadrant == -1)
                {
                    break;
                }

                depth++;
                currentNode = currentNode.Children[quadrant];
            }

            currentNode.Items.Add(item);
            this.Split(currentNode, depth);
            this.Count++;

            return true;
        }

        public List<T> Report(Rectangle bounds)
        {
            var collisionCandidates = new List<T>();

            this.GetCollisionCandidates(this.root, bounds, collisionCandidates);

            return collisionCandidates;
        }

        public void ForEachDfs(Action<List<T>, int, int> action)
        {
            this.ForEachDfs(this.root, action);
        }

        private void ForEachDfs(Node<T> node, Action<List<T>, int, int> action, int depth = 1, int quadrant = 0)
        {
            if (node == null)
            {
                return;
            }

            if (node.Items.Any())
            {
                action(node.Items, depth, quadrant);
            }

            if (node.Children == null)
            {
                return;
            }

            for(int i = 0; i < node.Children.Length; i++)
            {
                var child = node.Children[i];
                this.ForEachDfs(child, action, depth + 1, i);
            }
        }

        private int GetQuadrant(Node<T> node, Rectangle bounds)
        {
            int verticalMidpoint = node.Bounds.MidX;
            int horizontalMidpoint = node.Bounds.MidY;

            bool inTopQuadrant = node.Bounds.Y1 <= bounds.Y1 && bounds.Y2 <= horizontalMidpoint;
            bool inBottomQuadrant = horizontalMidpoint <= bounds.Y1 && bounds.Y2 <= node.Bounds.Y2;
            bool inLeftQuadrant = node.Bounds.X1 <= bounds.X1 && bounds.X2 <= verticalMidpoint;
            bool inRightQuadrant = verticalMidpoint <= bounds.X1 && bounds.X2 <= node.Bounds.X2;

            if (inTopQuadrant)
            {
                if (inRightQuadrant)
                {
                    return 0;
                }
                if (inLeftQuadrant)
                {
                    return 1;
                }
            }
            else if (inBottomQuadrant)
            {
                if (inLeftQuadrant)
                {
                    return 2;
                }
                if (inRightQuadrant)
                {
                    return 3;
                }
            }

            return -1;
        }

        private void Split(Node<T> node, int depth)
        {
            if (!node.ShouldSplit || depth >= this.MaxDepth)
            {
                return;
            }

            node.Children = new Node<T>[4];
            this.InitializeChildren(node);
            this.MoveItemsToChildren(node, depth);
        }

        private void InitializeChildren(Node<T> node)
        {
            int leftWidth = node.Bounds.Width / 2;
            int rightWidth = node.Bounds.Width - leftWidth;
            int topHeight = node.Bounds.Height / 2;
            int bottomHeight = node.Bounds.Height - topHeight;

            node.Children[0] = new Node<T>(
                node.Bounds.MidX,
                node.Bounds.Y1,
                rightWidth,
                topHeight);

            node.Children[1] = new Node<T>(
                node.Bounds.X1,
                node.Bounds.Y1,
                leftWidth,
                topHeight);

            node.Children[2] = new Node<T>(
                node.Bounds.X1,
                node.Bounds.MidY,
                leftWidth,
                bottomHeight);

            node.Children[3] = new Node<T>(
                node.Bounds.MidX,
                node.Bounds.MidY,
                rightWidth,
                bottomHeight);
        }

        private void MoveItemsToChildren(Node<T> node, int depth)
        {
            var nodeRemainingItems = new List<T>();

            for (int i = 0; i < node.Items.Count; i++)
            {
                var item = node.Items[i];
                bool itemMovedToChild = false;
                foreach (var childNode in node.Children)
                {
                    if (item.Bounds.IsInside(childNode.Bounds))
                    {
                        childNode.Items.Add(item);
                        itemMovedToChild = true;
                        break;
                    }
                }

                if (! itemMovedToChild)
                {
                    nodeRemainingItems.Add(item);
                }
            }

            node.Items = nodeRemainingItems;

            foreach (var child in node.Children)
            {
                this.Split(child, depth + 1);
            }
        }

        private void GetCollisionCandidates(Node<T> node, Rectangle bounds, List<T> results)
        {
            int quadrant = this.GetQuadrant(node, bounds);
            if (quadrant == -1)
            {
                this.GetSubtreeContents(node, bounds, results);
            }
            else
            {
                if (node.Children != null)
                {
                    this.GetCollisionCandidates(node.Children[quadrant], bounds, results);
                }

                results.AddRange(node.Items);
            }
        }

        private void GetSubtreeContents(Node<T> node, Rectangle bounds, List<T> results)
        {
            if (node.Children != null)
            {
                foreach (var child in node.Children)
                {
                    if (child.Bounds.Intersects(bounds))
                    {
                        this.GetSubtreeContents(child, bounds, results);
                    }
                }
            }

            results.AddRange(node.Items);
        }
    }
}