using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtherTypesExercise
{
    public class CustomList<T> 
        where T : IComparable<T>
    {
        private T[] array;

        private int capacity;

        private int index;


        public CustomList(int capacity = 16)
        {
            this.array = new T[16];
            this.index = 0;
            this.capacity = capacity;
        }


        public void AddElement(T element)
        {
            if (this.index == this.capacity)
            {
                this.Resize(this.index * 2);
            }
            this.array[index] = element;
            index++;
        }


        public void RemoveElement(T element)
        {
            int indexToRemove = this.IndexOf(element);

            for (int i = indexToRemove; i < this.index - 1; i++)
            {
                this.array[i] = this.array[i + 1];
            }
            this.array[this.index - 1] = default(T);
            this.index--;
        }


        public int IndexOf(T element)
        {
            for (int i = 0; i < this.index; i++)
            {
                if (element.CompareTo(array[i]) == 0)
                {
                    return i;
                }
            }
            return -1;
        }


        public T Min()
        {
            this.ListValidation();

            T min = this.array[0];
            for (int i = 1; i < this.index; i++)
            {
                if (this.array[i].CompareTo(min) == -1)
                {
                    min = array[i];
                }
            }
            return min;
        }


        public T Max()
        {
            this.ListValidation();

            T max = this.array[0];
            for (int i = 1; i < this.index; i++)
            {
                if (this.array[i].CompareTo(max) == 1)
                {
                    max = this.array[i];
                }
            }
            return max;
        }


        private void Resize(int newCapacity)
        {
            T[] newArray = new T[newCapacity];
            for (int i = 0; i < this.index; i++)
            {
                newArray[i] = array[i];   
            }
            this.capacity = newCapacity;
            this.array = newArray;
        }

        private void ListValidation()
        {
            if (this.index == 0)
            {
                throw new InvalidOperationException("List is empty.");
            }
        }

    }
}
