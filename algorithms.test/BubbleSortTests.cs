using Xunit;
using System;

using Algorithms.Sorting;

namespace Algorithms.Test.Sorting
{
    public class BubbleSortTests : SortTests
    {
        [Theory]
        [InlineData(null)]
        [InlineData(new int[] {9, 8, 7})]
        [InlineData(new int[] {7, 8, 9})]
        [InlineData(new int[] {10, 7, 7, 7, 8, 9})]
        [InlineData(new int[] {10, 9, 8, 7, 6, 4, 5, 3, 1, 2})]
        [InlineData(new int[] {9})]
        public void Sort_ReturnsSortedValues(int[] values)
        {
            SortAlgorithm_ReturnsSortedValues(BubbleSort.Sort, values);
        }
    }
}
