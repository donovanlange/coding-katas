using Xunit;
using System;

using Algorithms.Sorting;

namespace Algorithms.Test.Sorting
{
    public class BubbleSortTests
    {
        [Fact]
        public void Sort_WithNullValues_NoOps()
        {
            BubbleSort.Sort<int>(values: null);
        }

        private int[] ExpectedSort(int[] values)
        {
            int[] sortedValues = (int[]) values.Clone();
            Array.Sort(sortedValues);
            return sortedValues;
        }

        [Theory]
        [InlineData(new int[] {9, 8, 7})]
        [InlineData(new int[] {7, 8, 9})]
        [InlineData(new int[] {10, 7, 7, 7, 8, 9})]
        [InlineData(new int[] {10, 9, 8, 7, 6, 4, 5, 3, 1, 2})]
        [InlineData(new int[] {9})]
        public void Sort_ReturnsSortedValues(int[] values)
        {
            int[] expected = ExpectedSort(values);

            int[] sorted = values;
            BubbleSort.Sort(sorted);

            Assert.Equal(expected, sorted);
        }
    }
}
