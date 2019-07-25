using System;

using Algorithms.Extensions;

namespace Algorithms.Sorting
{
    public static class MergeSort
    {
        public static void Sort<T>(T[] values) where T: IComparable
        {
            if (values == null)
                return;

            Sort(values, iValueBegin: 0, iValueEnd: values.Length);
        }

        public static void Sort<T>(T[] values, int iValueBegin, int iValueEnd) where T: IComparable
        {
            // Single values are by definition sorted.
            if (iValueEnd - iValueBegin == 1)
                return;

            int iValueMidpoint = iValueBegin + (iValueEnd - iValueBegin) / 2;
            Sort(values, iValueBegin, iValueMidpoint);
            Sort(values, iValueMidpoint, iValueEnd);

            T[] merged = Merge(values, iValueBegin, iValueMidpoint, iValueEnd);
            Array.Copy(merged, 0, values, iValueBegin, merged.Length);
        }

        public static T[] Merge<T>(T[] values, int iValueBegin, int iValueMidpoint, int iValueEnd) where T: IComparable
        {
            T[] merged = new T[iValueEnd - iValueBegin];
            int iMerged = 0;

            int iValue2Begin = iValueMidpoint;
            while (iValueMidpoint - iValueBegin > 0 && iValueEnd - iValue2Begin > 0)
            {
                if (values[iValueBegin].CompareTo(values[iValue2Begin]) <= 0)
                {
                    merged[iMerged++] = values[iValueBegin++];
                }
                else
                {
                    merged[iMerged++] = values[iValue2Begin++];
                }
            }

            while (iValueMidpoint - iValueBegin > 0)
                merged[iMerged++] = values[iValueBegin++];

            while (iValueEnd - iValue2Begin > 0)
                merged[iMerged++] = values[iValue2Begin++];

            return merged;
        }
    }
}