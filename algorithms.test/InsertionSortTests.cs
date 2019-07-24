using Xunit;
using System;

using Algorithms.Sorting;

namespace Algorithms.Test.Sorting
{
    public class InsertionSortTests : SortTests
    {
        [Theory]
        [ClassData(typeof(SortTestCases))]
        public void Sort_ReturnsSortedValues(int[] values)
        {
            SortAlgorithm_ReturnsSortedValues(InsertionSort.Sort, values);
        }
    }
}
