using System;
using Xunit;

using Algorithms.Sorting;

namespace Algorithms.Test.Sorting
{
    public class SelectionSortTests : SortTests
    {
        [Theory]
        [ClassData(typeof(SortTestCases))]
        public void Sort_ReturnsSortedValues(int[] values)
        {
            SortAlgorithm_ReturnsSortedValues(SelectionSort.Sort, values);
        }
    }
}