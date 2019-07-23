using Xunit;

namespace Algorithms.Sorting.Test
{
    public class BubbleSortTests
    {
        [Fact]
        public void Sort_WithNullValues_ReturnsNullValues()
        {
            Assert.Null(BubbleSort.Sort(unordered: null));
        }
    }
}
