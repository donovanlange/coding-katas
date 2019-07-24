using System;

using Algorithms.Extensions;

namespace Algorithms.Sorting
{
    public static class InsertionSort
    {
        public static void Sort<T>(T[] values) where T: IComparable
        {
            if (values == null)
                return;

            for (int iUnsortedValue = 1; iUnsortedValue < values.Length; iUnsortedValue++)
            {
                int iSortedValue = iUnsortedValue - 1;
                while (iSortedValue >= 0 && values[iSortedValue].CompareTo(values[iSortedValue + 1]) > 0)
                {
                    values.Swap(iSortedValue, iSortedValue + 1);
                    iSortedValue--;
                }
            }
        }
    }
}