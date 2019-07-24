using Xunit;
using System;

using Algorithms.Sorting;

namespace Algorithms.Test.Sorting
{
    public class BubbleSortTests : SortTests
    {
        [Theory]
        [ClassData(typeof(SortTestCases))]
        public void Sort_ReturnsSortedValues(int[] values)
        {
            SortAlgorithm_ReturnsSortedValues(BubbleSort.Sort, values);
        }
    }
}
