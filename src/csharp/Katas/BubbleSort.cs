using System.Diagnostics;
using System.Linq;

namespace Katas
{
    public class BubbleSort : IRunTests
    {
        public int[] Sort(int[] arr)
        {
            int n = arr.Length;
            bool swapped;
            for (int i = 0; i < n - 1; i++)
            {
                swapped = false;
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                        swapped = true;
                    }
                }

                if (swapped == false) // if no two elements were swapped by inner loop, then finished
                    break;
            }

            return arr;
        }

        public void RunTests()
        {
            Debug.Assert(Enumerable.SequenceEqual(new int[] { 1 }, Sort(new int[] { 1 })));
            Debug.Assert(Enumerable.SequenceEqual(new int[] { 1, 2 }, Sort(new int[] { 2, 1 })));
            Debug.Assert(Enumerable.SequenceEqual(new int[] { 1, 2, 3, 6, 8 }, Sort(new int[] { 8, 3, 2, 6, 1 })));
        }
    }
}