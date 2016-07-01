using System;
using System.Collections.Generic;
using System.Linq;

using Wintellect.PowerCollections;

public class FirstLastList<T> : IFirstLastList<T>
    where T : IComparable<T>
{
    private int index;

    private Dictionary<int, T> indexElement;
    private Dictionary<T, List<int>> elementIndeces;
    private OrderedBag<T> sortedElements;

    public FirstLastList()
    {
        this.indexElement = new Dictionary<int, T>();
        this.elementIndeces = new Dictionary<T, List<int>>();
        this.sortedElements = new OrderedBag<T>();
    }

    public int Count => this.sortedElements.Count;

    public void Add(T newElement)
    {
        if (!this.elementIndeces.ContainsKey(newElement))
        {
            this.elementIndeces[newElement] = new List<int>();
        }

        this.elementIndeces[newElement].Add(this.index);
        this.indexElement.Add(this.index, newElement);
        this.sortedElements.Add(newElement);

        this.index++;
    }

    public IEnumerable<T> First(int count)
    {
        if (count > this.Count)
        {
            throw new ArgumentOutOfRangeException("Count is bigger than collection size.");
        }

        int itemsReturnedCount = 0;
        for (int index = 0; index < this.index && itemsReturnedCount < count; index++)
        {
            if (this.indexElement.ContainsKey(index))
            {
                yield return this.indexElement[index];
                itemsReturnedCount++;
            }
        }
    }

    public IEnumerable<T> Last(int count)
    {
        if (count > this.Count)
        {
            throw new ArgumentOutOfRangeException(
                "Count is bigger than collection size.");
        }

        int elemetsReturnedCount = 0;
        for (int index = this.index; elemetsReturnedCount < count; index--)
        {
            if (this.indexElement.ContainsKey(index))
            {
                yield return this.indexElement[index];
                elemetsReturnedCount++;
            }
        }
    }

    public IEnumerable<T> Min(int count)
    {
        if (count > this.Count)
        {
            throw new ArgumentOutOfRangeException("Count is bigger than collection size.");
        }

        for (int index = 0; index < count; index++)
        {
            var element = this.sortedElements[index];
            yield return element;
        }
    }

    public IEnumerable<T> Max(int count)
    {
        if (count > this.Count)
        {
            throw new ArgumentOutOfRangeException("Count is bigger than collection size.");
        }

        int itemsReturned = 0;
        for (int index = this.Count - 1; itemsReturned < count; index--)
        {
            var element = this.sortedElements[index];

            int equalElementsCount = 1;
            while (index >= this.Count - count && index > 0 && element.CompareTo(this.sortedElements[index - 1]) == 0)
            {
                equalElementsCount++;
                index--;
            }

            if (equalElementsCount == 1)
            {
                yield return element;
                itemsReturned++;
                continue;
            }

            for (int i = 0; i < equalElementsCount && itemsReturned < count; i++)
            {
                yield return this.sortedElements[index + i];
                itemsReturned++;
            }
        }
    }

    public int RemoveAll(T element)
    {
        var equalElements = this.sortedElements
            .Range(element, true, element, true);

        if (!equalElements.Any())
        {
            return 0;
        }

        foreach (var equalElement in equalElements)
        {
            if (! this.elementIndeces.ContainsKey(equalElement))
            {
                continue;
            }

            foreach (var index in this.elementIndeces[equalElement])
            {
                this.indexElement.Remove(index);
            }

            this.elementIndeces.Remove(equalElement);
        }

        int removedElementsCount = this.sortedElements.RemoveAllCopies(element);

        return removedElementsCount;
    }

    public void Clear()
    {
        this.sortedElements.Clear();
        this.indexElement.Clear();
        this.elementIndeces.Clear();

        this.index = 0;
    }
}