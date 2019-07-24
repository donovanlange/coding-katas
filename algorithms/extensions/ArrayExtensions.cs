namespace Algorithms.Extensions
{
    public static class ArrayExtensions
    {
        /// <summary>
        /// Swaps two elements in an array of values.
        /// </summary>
        public static void Swap<T>(this T[] values, int iSource, int iDestination)
        {
            T destinationValue = values[iDestination];
            values[iDestination] = values[iSource];
            values[iSource] = destinationValue;
        }
    }
}