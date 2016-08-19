namespace Sortable_Collection.Sorters
{
    using System;
    using System.Collections.Generic;

    using Sortable_Collection.Contracts;

    public class Quicksorter<T> : ISorter<T> where T : IComparable<T>
    {
        public void Sort(List<T> collection)
        {
            this.QuickSort(collection, 0, collection.Count - 1);
        }

        private void QuickSort(List<T> collection, int low, int high)
        {
            if (low >= high)
            {
                return;
            }

            int pivot = this.Partition(collection, low, high);
            this.QuickSort(collection, low, pivot);
            this.QuickSort(collection, pivot + 1, high);
        }

        private int Partition(List<T> collection, int low, int high)
        {
            #region Hoare

            T pivot = collection[low];
            int left = low - 1;
            int right = high + 1;

            // 7, 4, 9, 22, 1

            // 1, 4, 9, 22, 7
            while (true)
            {
                do
                {
                    right--;
                }
                while (collection[right].CompareTo(pivot) == 1);

                do
                {
                    left++;
                }
                while (collection[left].CompareTo(pivot) == -1);

                if (right <= left)
                {
                    return right;
                }

                Swap(collection, left, right);
            }

            #endregion

            #region lomuto

            //int pivot = low;
            //int store = low + 1;

            //for (int i = store; i <= high; i++)
            //{
            //    if (collection[i].CompareTo(collection[pivot]) != 1)
            //    {
            //        this.Swap(collection, store, i);
            //        store++;
            //    }
            //}

            //store--;
            //this.Swap(collection, pivot, store);

            //return store;

            #endregion
        }

        private void Swap(List<T> collection, int store, int i)
        {
            T old = collection[i];
            collection[i] = collection[store];
            collection[store] = old;
        }
    }
}