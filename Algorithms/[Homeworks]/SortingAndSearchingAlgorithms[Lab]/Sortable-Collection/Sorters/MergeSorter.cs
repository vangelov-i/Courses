namespace Sortable_Collection.Sorters
{
    using System;
    using System.Collections.Generic;

    using Sortable_Collection.Contracts;

    public class MergeSorter<T> : ISorter<T> where T : IComparable<T>
    {
        public void Sort(List<T> collection)
        {
            this.MergeSort(collection, 0, collection.Count - 1);
        }

        private void MergeSort(List<T> collection, int start, int end)
        {
            if (start >= end)
            {
                return;
            }

            int mid = start + (end - start) / 2;
            MergeSort(collection, start, mid);
            MergeSort(collection, mid + 1, end);

            //List<T> sorted = new List<T>();
            T[] sorted = new T[end - start + 1];
            int leftIndex = start;
            int rightIndex = mid + 1;
            int sortedIndex = 0;

            while (leftIndex <= mid && rightIndex <= end)
            {
                if (collection[leftIndex].CompareTo(collection[rightIndex]) != 1)
                {
                    sorted[sortedIndex++] = collection[leftIndex++];
                }
                else
                {
                    sorted[sortedIndex++] = collection[rightIndex++];
                }
            }

            while (leftIndex <= mid)
            {
                sorted[sortedIndex++] = collection[leftIndex++];
            }

            while (rightIndex <= end)
            {
                sorted[sortedIndex++] = collection[rightIndex++];
            }

            for (int i = 0; i < sorted.Length; i++)
            {
                collection[start + i] = sorted[i];
            }

            //Array.Copy(sorted, 0, collection.ToArray(), start, sorted.Length);
        }
    }
}
