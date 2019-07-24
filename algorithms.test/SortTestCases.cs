using System.Collections;
using System.Collections.Generic;

namespace Algorithms.Test.Sorting
{
    public class SortTestCases : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[] { null };
            yield return new object[] { new int[] {9, 8, 7} };
            yield return new object[] { new int[] {7, 8, 9} };
            yield return new object[] { new int[] {10, 7, -7, 7, 8, 9} };
            yield return new object[] { new int[] {10, 9, 8, 7, 6, 4, 5, 3, 1, 2} };
            yield return new object[] { new int[] {9} };
            yield return new object[] { new int[] {2,1} };
            yield return new object[] { new int[] {3,4,2} };
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}