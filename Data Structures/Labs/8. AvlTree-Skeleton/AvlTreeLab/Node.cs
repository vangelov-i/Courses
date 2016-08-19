namespace AvlTreeLab
{
    using System;
    using System.Runtime.CompilerServices;

    public class Node<T> where T : IComparable<T>
    {
        private Node<T> leftChild;
        private Node<T> rightChild;
         
        private int childrenCount;

        public Node(T value)
        {
            this.Value = value;
            this.childrenCount = -1;
            this.Count = 1;
        }

        public int Count { get; set; }

        public T Value { get; set; }

        public int BalanceFactor { get; set; }

        public Node<T> Parent { get; set; }

        public Node<T> Left
        {
            get
            {
                return this.leftChild;
            }

            set
            {
                if (value != null)
                {
                    value.Parent = this;
                }

                this.leftChild = value;
            }
        }

        public Node<T> Right
        {
            get
            {
                return this.rightChild;
            }

            set
            {
                if (value != null)
                {
                    value.Parent = this;
                }

                this.rightChild = value;
            }
        }


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