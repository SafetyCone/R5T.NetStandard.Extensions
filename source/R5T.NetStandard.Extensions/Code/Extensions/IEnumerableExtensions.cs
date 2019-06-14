﻿using System;
using System.Collections.Generic;


namespace R5T.NetStandard
{
    public static class IEnumerableExtensions
    {
    }
}


namespace R5T.NetStandard.Extensions
{
    public static class IEnumerableExtensions
    {
        /// <summary>
        /// Allows adding a few extra items to an enumerable.
        /// </summary>
        public static IEnumerable<T> And<T>(this IEnumerable<T> enumerable, params T[] extras)
        {
            foreach (var item in enumerable)
            {
                yield return item;
            }

            foreach (var item in extras)
            {
                yield return item;
            }
        }

        /// <summary>
        /// Performs the specified action on each element of an enumerable.
        /// </summary>
        public static void ForEach<T>(this IEnumerable<T> source, Action<T> action)
        {
            foreach (T element in source)
            {
                action(element);
            }
        }
    }
}