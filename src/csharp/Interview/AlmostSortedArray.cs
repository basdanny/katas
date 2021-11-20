using System.Diagnostics;
using System.Linq;

namespace Interview
{

    /// <summary>
    /// Sort an almost sorted array where only two elements are swapped 
    /// </summary>
    public class AlmostSortedArray : IRunTests
    {
        public static int[] SortByOneSwap(int[] arr)
        {
            for (int i = arr.Length - 1; i > 0; i--)
            {
                if (arr[i] < arr[i - 1])
                {
                    int j = i - 1;
                    while (j > 0 && arr[i] < arr[j])
                        j--;

                    //do the swap
                    int temp = arr[i];
                    int leftIndexOfSwap = (j == i - 1) ? j : j + 1; //check for adjucent swap
                    arr[i] = arr[leftIndexOfSwap];
                    arr[leftIndexOfSwap] = temp;

                    break;
                }
            }

            return arr;
        }

        public void RunTests()
        {
            Debug.Assert(Enumerable.SequenceEqual(new int[] { 1, 2, 4, 5 }, SortByOneSwap(new int[] { 1, 5, 4, 2 })));
            Debug.Assert(Enumerable.SequenceEqual(new int[] { 1, 2 }, SortByOneSwap(new int[] { 2, 1 })));
        }
    }
}
