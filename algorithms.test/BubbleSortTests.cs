using Xunit;

namespace Algorithms.Sorting.Test
{
    public class BubbleSortTests
    {
        [Fact]
        public void Sort_WithNullValues_ReturnsNullValues()
        {
            Assert.Null(BubbleSort.Sort(values: null));
        }

        [Fact]
        public void Sort_ReturnsSortedValues()
        {
            Assert.Equal(new int[]{7, 8, 9}, BubbleSort.Sort(new int[] {9, 8, 7}));
        }

    }
}
