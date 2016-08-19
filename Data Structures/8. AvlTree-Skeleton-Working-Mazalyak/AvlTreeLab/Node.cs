namespace AvlTreeLab
{
    using System;
    using System.Runtime.CompilerServices;

    public class Node<T> where T : IComparable<T>
    {
        private int childrenCount;

        public Node(T value)
        {
            this.Value = value;
            this.childrenCount = -1;
        }

        public T Value { get; set; }

        public int BalanceFactor { get; set; }

        public Node<T> Parent { get; set; }

        public Node<T> Left { get; set; }

        public Node<T> Right { get; set; }

        public bool IsLeftChild =>
            this.Parent != null &&
            this.Value.CompareTo(this.Parent.Value) == -1;

        public bool IsRightChild =>
            this.Parent != null &&
            this.Value.CompareTo(this.Parent.Value) == 1;

        public int ChildrenCount
        {
            get
            {
                if (this.childrenCount != -1)
                {
                    return this.childrenCount;
                }

                if (this.Right == null && this.Left == null)
                {
                    this.childrenCount = 0;
                    return this.childrenCount;
                }

                if (this.Right != null)
                {
                    this.childrenCount += this.Right.ChildrenCount;
                }

                if (this.Left != null)
                {
                    this.childrenCount += this.Left.ChildrenCount;
                }

                return this.childrenCount;
            }
        }

        public override string ToString()
        {
            return this.Value.ToString();
        }
    }
}