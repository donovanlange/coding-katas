namespace Algorithms.Sorting
{
    public static class SelectionSort
    {
        private static void Swap(this int[] values, int iSource, int iDestination)
        {
            int destinationValue = values[iDestination];
            values[iDestination] = values[iSource];
            values[iSource] = destinationValue;
        }

        /// <summary>
        /// Sorts the given values using a SelectionSort algorithm.
        /// </summary>
        /// <param name="values">The values to be sorted.</param>
        public static void Sort(int[] values)
        {
            if (values == null)
                return;

            for (int iSortedList = values.Length - 1; iSortedList > 0; iSortedList--)
            {
                int maxUnsortedValue = values[0];
                int iMaxUnsortedValue = 0;
                for (int iUnsortedCandidates = 1; iUnsortedCandidates <= iSortedList; iUnsortedCandidates++)
                {
                    if (values[iUnsortedCandidates] > maxUnsortedValue)
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