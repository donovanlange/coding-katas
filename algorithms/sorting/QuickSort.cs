using System;

using Algorithms.Extensions;

namespace Algorithms.Sorting
{
    public static class QuickSort
    {
        public static void Sort<T>(T[] values) where T: IComparable
        {
            if (values == null)
                return;

            Sort(values, 0, values.Length);
        }

        public static void Sort<T>(T[] values, int iRangeBegin, int iRangeEnd) where T: IComparable
        {
            if (iRangeEnd - iRangeBegin < 2)
                return;

            // Choose a pivot.
            int iPivotValue = iRangeEnd - 1;
            T pivotValue = values[iPivotValue];

            // Walk from the beginning of the left range, and backwards from the end of the right range
            int iLeftRange = iRangeBegin;
            int iRightRange = iPivotValue - 1;

            // Swap all elements that are out of place relative to the pivot.
            while (iLeftRange <= iRightRange)
            {
                while (iLeftRange <= iRightRange && values[iLeftRange].CompareTo(pivotValue) < 0)
                {
                    iLeftRange++;
                }

                while (iLeftRange <= iRightRange && values[iRightRange].CompareTo(pivotValue) > 0)
                {
                    iRightRange--;
                }

                if (iLeftRange <= iRightRange)
                {
                    values.Swap(iLeftRange++, iRightRange--);
                }
            }

            // Move the pivot into place.
            values.Swap(iPivotValue, iLeftRange);

            // Recurse on the two sub-ranges.
            Sort(values, iRangeBegin, iLeftRange);
            Sort(values, iLeftRange + 1, iRangeEnd);
        }
    }
}