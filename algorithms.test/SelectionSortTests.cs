using System;
using Xunit;

using Algorithms.Sorting;

namespace Algorithms.Test.Sorting
{
    public class SelectionSortTests
    {
        private int[] ExpectedSort(int[] values)
        {
            int[] sortedValues = (int[]) values.Clone();
            Array.Sort(sortedValues);
            return sortedValues;
        }

        [Fact]
        public void Sort_Null_NoOps()
        {
            SelectionSort.Sort<int>(null);
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
            SelectionSort.Sort(sorted);

            Assert.Equal(expected, sorted);
        }
    }
}