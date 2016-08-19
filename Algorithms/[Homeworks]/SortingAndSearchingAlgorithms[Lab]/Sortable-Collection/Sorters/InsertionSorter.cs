namespace Sortable_Collection.Sorters
{
    using System;
    using System.Collections.Generic;

    using Sortable_Collection.Contracts;

    public class InsertionSorter<T> : ISorter<T> where T : IComparable<T>
    {
        public void Sort(List<T> collection)
        {
            for (int index = 1; index < collection.Count; index++)
            {
                int targetIndex = index;
                while (targetIndex > 0 && collection[targetIndex - 1].CompareTo(collection[targetIndex]) == 1)
                {
                    Swap(collection, targetIndex);
                    targetIndex--;
                }
            }

            #region first implementation
            //for (int index = 1; index < collection.Count; index++)
            //{
            //    int targetIndex = index;
            //    while (targetIndex > 0 && collection[targetIndex - 1].CompareTo(collection[index]) == 1)
            //    {
            //        targetIndex--;
            //    }

            //    if (targetIndex < index)
            //    {
            //        T item = collection[index];
            //        collection.RemoveAt(index);
            //        collection.Insert(targetIndex, item);
            //    }
            //}
            #endregion
        }

        private static void Swap(List<T> collection, int index)
        {
            T old = collection[index - 1];
            collection[index - 1] = collection[index];
            collection[index] = old;
        }
    }
}
