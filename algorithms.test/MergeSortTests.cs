using System;
using Xunit;

using Algorithms.Sorting;

namespace Algorithms.Test.Sorting
{
    public class MergeSortTests : SortTests
    {
        [Theory]
        [ClassData(typeof(SortTestCases))]
        public void Sort_ReturnsSortedValues(int[] values)
        {
            SortAlgorithm_ReturnsSortedValues(MergeSort.Sort, values);
        }
    }
}