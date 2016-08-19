namespace PermutationsWwithRepetition
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public static class PermutationsWithRepetition
    {
        public static void Main(string[] args)
        {
            int[] elements = Console.ReadLine().Split(
                new[] { ' ', ',', '=', 's', '{', '}' },
                StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).OrderBy(i => i).ToArray();
            //elements = new int[] { 1,2,3};
            Permutate(elements);
        }

        private static void Permutate(int[] elements, int index = 0)
        {
            if (index >= elements.Length)
            {
                PrintPermutation(elements);
                return;
            }

            ISet<int> swapped = new HashSet<int>();
            for (int i = index; i < elements.Length; i++)
            {
                //if (!swapped.Contains(elements[i]))
                //{
                    Swap(elements, index, i);
                    Permutate(elements, index + 1);
                    Swap(elements, index, i);

                    while (index < elements.Length - 1 && elements[index] == elements[index + 1])
                    {
                        index++;
                    }

                //    swapped.Add(elements[i]);
                //}
            }
        }

        private static void Swap(int[] elements, int index, int i)
        {
            int old = elements[index];
            elements[index] = elements[i];
            elements[i] = old;
        }

        private static void PrintPermutation(int[] elements)
        {
            Console.WriteLine(string.Join(", ", elements));
        }

        //public static void Main()
        //{
        //    //int[] elements = { 1, 0, 0, 0, 0, 0, 0 };

        //    int[] elements = Console.ReadLine().Split(
        //        new []{' ',',','=','s','{','}'}, 
        //        StringSplitOptions.RemoveEmptyEntries)
        //        .Select(int.Parse).ToArray();

        //    Permutate(elements, elements.Length - 1, 0);
        //}

        //private static void Permutate(int[] arr, int end, int start)
        //{
        //    Console.WriteLine("{{ {0} }}", string.Join(", ", arr));

        //    for (int left = end - 1; left >= start; left--)
        //    {
        //        for (int right = left + 1; right <= end; right++)
        //        {
        //            if (arr[left].CompareTo(arr[right]) != 0)
        //            {
        //                int old = arr[left];
        //                arr[left] = arr[right];
        //                arr[right] = old;

        //                Permutate(arr, end, left + 1);
        //            }
        //        }

        //        int firstElement = arr[left];

        //        for (int i = left; i <= end - 1; i++)
        //        {
        //            arr[i] = arr[i + 1];
        //        }

        //        arr[end] = firstElement;
        //    }
        //}
    }
}