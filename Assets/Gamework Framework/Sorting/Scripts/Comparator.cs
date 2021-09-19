using System.Collections.Generic;

namespace GameworkFramework.Sorting
{
    /// <summary>
    /// Comparator to be used for sorting an array
    /// </summary>
    public class Comparator : IComparer<int>
    {
        /// <summary>
        /// Compares 2 ints and returns either -1, 0, or 1
        /// </summary>
        /// <param name="x">The first number to be compared</param>
        /// <param name="y">The other number to be compared</param>
        /// <returns>Returns either -1, 0 or 1</returns>
        public int Compare(int x, int y)
        {
            int compareInt = x.CompareTo(y);
            return compareInt;
        }
    }
}
