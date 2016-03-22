using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01CustomLINqExtensionMethods
{
    public static class Extention
    {
        public static IEnumerable<T> WhereNot<T>(this IEnumerable<T> collection, Predicate<T> predicate)
        {
            var list = new List<T>();
            foreach (var item in collection)
            {
                if (!predicate(item))
                {
                    list.Add(item);
                }
            }
            return list;
        }


        public static TSelector Max<TSource, TSelector>(this IEnumerable<TSource> collection, Func<TSource, TSelector> func)
            where TSelector : IComparable<TSelector>
        {
            var list = new List<TSelector>();

            foreach (var item in collection)
            {
                list.Add(func(item));
            }

            TSelector max = list[0];
            foreach (var item in list)
            {
                if (item.CompareTo(max) == 1)
                {
                    max = item;
                }
            }

            return max;
        }


    }
}
