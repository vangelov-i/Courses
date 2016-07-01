namespace Hierarchy.Core
{
    using System;
    using System.Collections.Generic;
    using System.Collections;
    using System.Collections.Specialized;
    using System.Linq;

    using Wintellect.PowerCollections;

    public class Hierarchy<T> : IHierarchy<T>
    {
        private T root;

        private Dictionary<T, T> elementsParents;
        private Dictionary<T, OrderedDictionary<int, T>> elementsChildren;
        private Dictionary<T, int> elementsChildrenIndices;
        private Dictionary<T, int> elementsIndexInParentsChildren;

        public Hierarchy(T root)
        {
            this.elementsParents = new Dictionary<T, T>();
            this.elementsChildren = new Dictionary<T, OrderedDictionary<int, T>>();
            this.elementsChildrenIndices = new Dictionary<T, int>();
            this.elementsIndexInParentsChildren = new Dictionary<T, int>();

            this.root = root;

            this.elementsParents.Add(root, default(T));
            this.elementsChildren.Add(root, new OrderedDictionary<int, T>());
            this.elementsChildrenIndices[root] = 0;
        }

        public int Count => this.elementsParents.Count;

        public void Add(T element, T child)
        {
            if (!this.elementsParents.ContainsKey(element) || 
                this.elementsParents.ContainsKey(child))
            {
                throw new ArgumentException("Element does not exist.");
            }

            this.InitializeChild(element, child);

            this.elementsChildren[element].Add(this.elementsChildrenIndices[element], child);
            this.elementsIndexInParentsChildren[child] = this.elementsChildrenIndices[element];

            this.elementsChildrenIndices[element]++;
        }

        public void Remove(T element)
        {
            if (element.Equals(this.root))
            {
                throw new InvalidOperationException("The parent to remove cannot be the root.");
            }

            if (!this.elementsParents.ContainsKey(element))
            {
                throw new ArgumentException("Element does not exist.");
            }

            var parent = this.elementsParents[element];
            foreach (var child in this.elementsChildren[element].Values)
            {
                this.TransferChild(parent, child);
            }

            var elementIndexInParentChildren = this.elementsIndexInParentsChildren[element];

            this.elementsParents.Remove(element);
            this.elementsChildren[parent].Remove(elementIndexInParentChildren);
            this.elementsChildrenIndices.Remove(element);
            this.elementsIndexInParentsChildren.Remove(element);
        }


        public IEnumerable<T> GetChildren(T item)
        {
            if (!this.elementsParents.ContainsKey(item))
            {
                throw new ArgumentException("The given parent does not exist");
            }

            return this.elementsChildren[item].Values;
        }

        public T GetParent(T item)
        {
            if (!this.elementsParents.ContainsKey(item))
            {
                throw new ArgumentException("The given parent does not exist");
            }

            return this.elementsParents[item];
        }

        public bool Contains(T value)
        {
            return this.elementsParents.ContainsKey(value);
        }

        public IEnumerable<T> GetCommonElements(Hierarchy<T> other)
        {
            var result = other.elementsParents.Keys.Intersect(this.elementsParents.Keys).Reverse();

            return result;
        }

        public IEnumerator<T> GetEnumerator()
        {
            var bfsQueue = new Queue<T>();
            T currentElement = this.root;
            bfsQueue.Enqueue(currentElement);

            while (bfsQueue.Count > 0)
            {
                currentElement = bfsQueue.Dequeue();
                yield return currentElement;

                foreach (var child in this.elementsChildren[currentElement].Values)
                {
                    bfsQueue.Enqueue(child);
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        private void InitializeChild(T parent, T child)
        {
            this.elementsParents.Add(child, parent);
            this.elementsChildren[child] = new OrderedDictionary<int, T>();
            this.elementsChildrenIndices[child] = 0;
        }

        private void TransferChild(T parent, T child)
        {
            this.elementsParents[child] = parent;
            this.elementsChildren[parent].Add(this.elementsChildrenIndices[parent], child);
            this.elementsIndexInParentsChildren[child] = this.elementsChildrenIndices[parent];

            this.elementsChildrenIndices[parent]++;
        }
    }
}