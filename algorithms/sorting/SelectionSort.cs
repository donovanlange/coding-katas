using System;

using Algorithms.Extensions;

namespace Algorithms.Sorting
{
    public static class SelectionSort
    {
        /// <summary>
        /// Sorts the given values using a SelectionSort algorithm.
        /// </summary>
        /// <param name="values">The values to be sorted.</param>
        public static void Sort<T>(T[] values) where T: IComparable
        {
            if (values == null)
                return;

            for (int iSortedList = values.Length - 1; iSortedList > 0; iSortedList--)
            {
                T maxUnsortedValue = values[0];
                int iMaxUnsortedValue = 0;
                for (int iUnsortedCandidates = 1; iUnsortedCandidates <= iSortedList; iUnsortedCandidates++)
                {
                    if (values[iUnsortedCandidates].CompareTo(maxUnsortedValue) > 0)
                    {
                        maxUnsortedValue = values[iUnsortedCandidates];
                        iMaxUnsortedValue = iUnsortedCandidates;
                    }
                }

                values.Swap(iMaxUnsortedValue, iSortedList);
            }
        }
    }
}