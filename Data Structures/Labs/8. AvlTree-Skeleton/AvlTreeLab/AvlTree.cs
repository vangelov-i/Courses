namespace AvlTreeLab
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    public class AvlTree<T> where T : IComparable<T>
    {
        private Node<T> root;

        public int Count { get; private set; }

        public void Add(T item)
        {
            bool inserted = true;
            if (this.root == null)
            {
                this.root = new Node<T>(item);
                this.Count++;
                return;
            }

            inserted = this.InsertInternal(item);

            if (inserted)
            {
                this.Count++;
            }
        }

        public bool Contains(T item)
        {
            var currentNode = this.root;
            while (currentNode != null)
            {
                if (currentNode.Value.CompareTo(item) == 0)
                {
                    return true;
                }

                if (currentNode.Value.CompareTo(item) == 1)
                {
                    currentNode = currentNode.Left;
                }
                else
                {
                    currentNode = currentNode.Right;
                }
            }

            return false;
        }

        public AvlTree<T> Find(T item)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> Range(T start, T end)
        {
            var result = new List<T>();

            Predicate<T> predicate = v => v.CompareTo(start) >= 0 && v.CompareTo(end) <= 0;
            Action<T> action = a => result.Add(a);

            this.GetRangeDfs(start, end, action, this.root);

            return result;
        }

        public void ForeachDfs(Action<int, T> action)
        {
            this.ForeachInOrderDfs(action, 1, this.root);
        }

        private bool InsertInternal(T item)
        {
            bool shouldRetrace = false;
            var currentNode = this.root;
            while (true)
            {
                if (item.CompareTo(currentNode.Value) == -1)
                {
                    if (currentNode.Left == null)
                    {
                        currentNode.Left = new Node<T>(item) { Parent = currentNode };

                        currentNode.BalanceFactor++;
                        shouldRetrace = currentNode.BalanceFactor != 0;
                        break;
                    }

                    currentNode = currentNode.Left;
                }
                else if (item.CompareTo(currentNode.Value) == 1)
                {
                    if (currentNode.Right == null)
                    {
                        currentNode.Right = new Node<T>(item) { Parent = currentNode };

                        currentNode.BalanceFactor--;
                        shouldRetrace = currentNode.BalanceFactor != 0;

                        break;
                    }

                    currentNode = currentNode.Right;
                }
                else
                {
                    return false;
                }
            }

            if (shouldRetrace)
            {
                this.Retrace(currentNode);
            }

            return true;
        }

        private void Retrace(Node<T> node)
        {
            var parent = node.Parent;
            while (parent != null)
            {
                if (node.IsLeftChild)
                {
                    parent.BalanceFactor++;
                }
                else if (node.IsRightChild)
                {
                    parent.BalanceFactor--;
                }

                if (parent.BalanceFactor == 2)
                {
                    if (node.BalanceFactor == -1)
                    {
                        this.RotateLeft(node);
                    }

                    this.RotateRight(parent);
                    break;
                }

                if (parent.BalanceFactor == -2)
                {
                    if (node.BalanceFactor == 1)
                    {
                        this.RotateRight(node);
                    }

                    this.RotateLeft(parent);
                    break;
                }

                if (parent.BalanceFactor == 0)
                {
                    return;
                }

                node = parent;
                parent = node.Parent;
            }
        }

        private void RotateLeft(Node<T> node)
        {
            var parent = node.Parent;
            var child = node.Right;
            if (parent != null)
            {
                if (node.IsRightChild)
                {
                    parent.Right = child;
                }
                else
                {
                    parent.Left = child;
                }
            }
            else
            {
                child.Parent = null;
                this.root = child;
            }

            node.Right = child.Left;
            child.Left = node;

            node.BalanceFactor += 1 - Math.Min(child.BalanceFactor, 0);
            child.BalanceFactor += 1 + Math.Max(node.BalanceFactor, 0);
        }

        private void RotateRight(Node<T> node)
        {
            var parent = node.Parent;
            var child = node.Left;
            if (parent != null)
            {
                if (node.IsRightChild)
                {
                    parent.Right = child;
                }
                else
                {
                    parent.Left = child;
                }
            }
            else
            {
                child.Parent = null;
                this.root = child;
            }

            node.Left = child.Right;
            child.Right = node;

            node.BalanceFactor -= 1 + Math.Max(child.BalanceFactor, 0);
            child.BalanceFactor -= 1 - Math.Min(node.BalanceFactor, 0);
        }

        private void ForeachInOrderDfs(Action<int, T> action, int depth, Node<T> node)
        {
            if (node.Left != null)
            {
                this.ForeachInOrderDfs(action, depth + 1, node.Left);
            }

            action(depth, node.Value);

            if (node.Right != null)
            {
                this.ForeachInOrderDfs(action, depth + 1, node.Right);
            }
        }

        public int getRangeCounter; // for analyzing purposes

        private void GetRangeDfs(T start, T end, Action<T> action, Node<T> node)
        {
            this.getRangeCounter++;
            if (node.Left != null && node.Left.Value.CompareTo(start) >= 0)
            {
                GetRangeDfs(start, end, action, node.Left);
            }
            else
            {
                if (node.Left?.Right != null)
                {
                    this.GetRangeDfs(start, end, action, node.Left.Right);
                }
            }

            if (node.Value.CompareTo(start) >= 0 && node.Value.CompareTo(end) <= 0)
            {
                action(node.Value);
            }

            if (node.Right != null && node.Right.Value.CompareTo(end) <= 0)
            {
                GetRangeDfs(start, end, action, node.Right);
            }
            else
            {
                if (node.Right?.Left != null)
                {
                    this.GetRangeDfs(start, end, action, node.Right.Left);
                }
            }
        }
    }
}
