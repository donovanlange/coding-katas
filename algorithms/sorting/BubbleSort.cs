namespace Algorithms.Sorting
{
    public static class BubbleSort
    {
        /// <summary>
        /// Swaps two elements in an array of values.
        /// </summary>
        private static void Swap(this int[] values, int indexToSwap, int indexToSwapTo)
        {
            int temp = values[indexToSwapTo];
            values[indexToSwapTo] = values[indexToSwap];
            values[indexToSwap] = temp;
        }

        /// <summary>
        /// Sorts the given array of numbers using a BubbleSort algorithm.
        /// </summary>
        /// <param name="values">The unordered values to be sorted.</param>
        /// <returns>The sorted values.</returns>
        public static void Sort(int[] values)
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
                    if (values[iValue - 1] > values[iValue])
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