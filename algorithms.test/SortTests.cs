using Xunit;
using System;

using Algorithms.Sorting;

namespace Algorithms.Test.Sorting
{
    public abstract class SortTests
    {
        private int[] ExpectedSort(int[] values)
        {
            if (values == null)
                return null;

            int[] sortedValues = (int[]) values.Clone();
            Array.Sort(sortedValues);
            return sortedValues;
        }

        protected void SortAlgorithm_ReturnsSortedValues(Action<int[]> sort, int[] values)
        {
            int[] expected = ExpectedSort(values);

            int[] sorted = values;
            sort(sorted);

            Assert.Equal(expected, sorted);
        }
    }
}
