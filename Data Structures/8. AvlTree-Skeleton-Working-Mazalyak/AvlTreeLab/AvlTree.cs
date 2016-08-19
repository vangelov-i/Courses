namespace AvlTreeLab
{
    using System;

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

        public bool Contains(T item)
        {
            //throw new Exception();
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

        public void ForeachDfs(Action<int, T> action)
        {
            this.ForeachInOrderDfs(action, 1, this.root);
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

        private void Retrace(Node<T> node)
        {
            bool shouldRebalance = false;

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

                shouldRebalance = Math.Abs(parent.BalanceFactor) == 2;
                if (shouldRebalance)
                {
                    this.Rotate(parent);
                    return;
                }

                if (parent.BalanceFactor == 0)
                {
                    return;
                }

                node = parent;
                parent = node.Parent;
            }
        }

        private void Rotate(Node<T> parent)
        {
            if (parent.BalanceFactor == 2)
            {
                this.RotateLeft(parent);
            }
            else
            {
                this.RotateRight(parent);
            }
        }

        private void RotateLeft(Node<T> parent)
        {
            var grandpa = parent.Parent;
            var child = parent.Left;
            Node<T> grandChild;
            if (child.Left != null)
            {
                // left-left
                if (child.Right != null)
                {
                    parent.Left = child.Right;
                    child.Right.Parent = parent;
                }
                else
                {
                    parent.Left = null;
                }

                child.Right = parent;
                //parent.Left = null;
                parent.Parent = child;

                parent.BalanceFactor = 0;
                child.BalanceFactor = 0;
                child.Parent = null;
                if (grandpa != null && child.Value.CompareTo(grandpa.Value) == -1)
                {
                    grandpa.Left = child;
                    child.Parent = grandpa;
                }
                else if (grandpa != null)
                {
                    grandpa.Right = child;
                    child.Parent = grandpa;
                }
                else
                {
                    this.root = child;
                }

                return;
            }

            // left-right
            grandChild = child.Right;

            grandChild.Left = child;
            parent.Left = grandChild;
            grandChild.Parent = parent;
            child.Right = null;

            grandChild.Right = parent;
            child.Parent = grandChild;
            parent.Left = null;
            parent.Parent = grandChild;

            parent.BalanceFactor = 0;
            child.BalanceFactor = 0;

            grandChild.Parent = null;
            if (grandpa != null && grandChild.Value.CompareTo(grandpa.Value) == -1)
            {
                grandpa.Left = grandChild;
                grandChild.Parent = grandpa;
            }
            else if (grandpa != null)
            {
                grandpa.Right = grandChild;
                grandChild.Parent = grandpa;
            }
            else
            {
                this.root = grandChild;
            }
        }

        private void RotateRight(Node<T> parent)
        {
            var grandpa = parent.Parent;
            var child = parent.Right;
            Node<T> grandChild;
            if (child.Right != null)
            {
                // right-right
                if (child.Left != null)
                {
                    parent.Right = child.Left;
                    child.Left.Parent = parent;
                }
                else
                {
                    parent.Right = null;
                }

                child.Left = parent;
                parent.Parent = child;
                parent.BalanceFactor = 0;
                child.BalanceFactor = 0;
                child.Parent = null;
                if (grandpa != null && child.Value.CompareTo(grandpa.Value) == -1)
                {
                    grandpa.Left = child;
                    child.Parent = grandpa;
                }
                else if (grandpa != null)
                {
                    grandpa.Right = child;
                    child.Parent = grandpa;
                }
                else
                {
                    this.root = child;
                }

                return;
            }

            // right-left
            grandChild = child.Left;

            grandChild.Right = child;
            grandChild.Left = parent;
            grandChild.Parent = parent;
            child.Left = null;
            child.Parent = grandChild;
            parent.Right = null;
            parent.Parent = grandChild;

            parent.BalanceFactor = 0;
            child.BalanceFactor = 0;

            grandChild.Parent = null;
            if (grandpa != null && grandChild.Value.CompareTo(grandpa.Value) == -1)
            {
                grandpa.Left = grandChild;
                grandChild.Parent = grandpa;
            }
            else if (grandpa != null)
            {
                grandpa.Right = grandChild;
                grandChild.Parent = grandpa;
            }
            else
            {
                this.root = grandChild;
            }
        }
    }
}
