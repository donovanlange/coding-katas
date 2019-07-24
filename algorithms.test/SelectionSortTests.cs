using System;
using Xunit;

using Algorithms.Sorting;

namespace Algorithms.Test.Sorting
{
    public class SelectionSortTests : SortTests
    {
        [Theory]
        [InlineData(null)]
        [InlineData(new int[] {9, 8, 7})]
        [InlineData(new int[] {7, 8, 9})]
        [InlineData(new int[] {10, 7, 7, 7, 8, 9})]
        [InlineData(new int[] {10, 9, 8, 7, 6, 4, 5, 3, 1, 2})]
        [InlineData(new int[] {9})]
        [InlineData(new int[] {2,1})]
        [InlineData(new int[] {3,4,2})]
        public void Sort_ReturnsSortedValues(int[] values)
        {
            SortAlgorithm_ReturnsSortedValues(SelectionSort.Sort, values);
        }
    }
}