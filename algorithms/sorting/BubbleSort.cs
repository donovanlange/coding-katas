using System;

using Algorithms.Extensions;

namespace Algorithms.Sorting
{
    public static class BubbleSort
    {
        /// <summary>
        /// Sorts the given array of numbers using a BubbleSort algorithm.
        /// </summary>
        /// <param name="values">The unordered values to be sorted.</param>
        /// <returns>The sorted values.</returns>
        public static void Sort<T>(T[] values) where T: IComparable
        {
            if (values == null)
                return;

            int countUnorderedValues = values.Length;

            bool valuesReordered = true;
            while (valuesReordered)
            {
                valuesReordered = false;
                for (int iValue = 1; iValue < countUnorderedValues; iValue++)
                {
                    if (values[iValue - 1].CompareTo(values[iValue]) > 0)
                    {
                        values.Swap(iValue - 1, iValue);
                        valuesReordered = true;
                    }
                }

                // Every pass will ensure that the end of the values array will have
                // stabilized:
                countUnorderedValues--;
            }
        }
    }
}