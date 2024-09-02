using System;
using System.Diagnostics;

namespace Katas
{
    public class BinarySearch : IRunTests
    {
        /// <summary>
        /// A binary chop method that takes an integer search target and a sorted array of integers. 
        /// It should return the integer index of the target in the array, or -1 if the target is not in the array.
        /// </summary>
        public int BinarySearch1(int number, int[] array)
        {
            if (array.Length <= 0)
                return -1;

            int startIndex = 0;
            int endIndex = array.Length - 1;

            while (startIndex <= endIndex)
            {
                int splitIndex = startIndex + ((endIndex - startIndex) / 2);
                if (array[splitIndex] > number)
                    endIndex = splitIndex - 1;
                else if (array[splitIndex] < number)
                    startIndex = splitIndex + 1;
                else if (array[splitIndex] == number)
                    return splitIndex;
            }

            return -1;
        }

        public int BinarySearch2(int number, int[] array)
        {
            if (array.Length <= 0)
                return -1;

            int startIndex = 0;
            int endIndex = array.Length - 1;

            while (startIndex < endIndex)
            {
                int splitIndex = startIndex + ((endIndex - startIndex) / 2);
                if (array[splitIndex] < number)
                    startIndex = splitIndex + 1;
                else
                    endIndex = splitIndex;
            }

            if (array[startIndex] == number)
                return startIndex;
            else
                return -1;
        }

        public int BinarySearchRecursive(int number, int[] array)
        {
            if (array.Length <= 0)
                return -1;

            int startIndex = 0;
            int endIndex = array.Length - 1;
            return BinarySearchRecursive(number, array, startIndex, endIndex);
        }

        private int BinarySearchRecursive(int number, int[] array, int startIndex, int endIndex)
        {
            if (startIndex <= endIndex)
            {

                int splitIndex = startIndex + ((endIndex - startIndex) / 2);

                if (array[splitIndex] == number)
                    return splitIndex;
                else if (array[splitIndex] >= number)
                    return BinarySearchRecursive(number, array, startIndex, splitIndex - 1);
                else
                    return BinarySearchRecursive(number, array, splitIndex + 1, endIndex);
            }

            return -1;
        }


        private void Test(Func<int, int[], int> binarySearch)
        {
            Debug.Assert(-1 == binarySearch(3, new int[] { }));
            Debug.Assert(-1 == binarySearch(3, new int[] { 1 }));
            Debug.Assert(0 == binarySearch(1, new int[] { 1 }));

            Debug.Assert(0 == binarySearch(1, new int[] { 1, 3, 5 }));
            Debug.Assert(1 == binarySearch(3, new int[] { 1, 3, 5 }));
            Debug.Assert(2 == binarySearch(5, new int[] { 1, 3, 5 }));
            Debug.Assert(-1 == binarySearch(0, new int[] { 1, 3, 5 }));
            Debug.Assert(-1 == binarySearch(2, new int[] { 1, 3, 5 }));
            Debug.Assert(-1 == binarySearch(4, new int[] { 1, 3, 5 }));
            Debug.Assert(-1 == binarySearch(6, new int[] { 1, 3, 5 }));

            Debug.Assert(0 == binarySearch(1, new int[] { 1, 3, 5, 7 }));
            Debug.Assert(1 == binarySearch(3, new int[] { 1, 3, 5, 7 }));
            Debug.Assert(2 == binarySearch(5, new int[] { 1, 3, 5, 7 }));
            Debug.Assert(3 == binarySearch(7, new int[] { 1, 3, 5, 7 }));
            Debug.Assert(-1 == binarySearch(0, new int[] { 1, 3, 5, 7 }));
            Debug.Assert(-1 == binarySearch(2, new int[] { 1, 3, 5, 7 }));
            Debug.Assert(-1 == binarySearch(4, new int[] { 1, 3, 5, 7 }));
            Debug.Assert(-1 == binarySearch(6, new int[] { 1, 3, 5, 7 }));
            Debug.Assert(-1 == binarySearch(8, new int[] { 1, 3, 5, 7 }));
        }

        public void RunTests()
        {
            Test(this.BinarySearch1);
            Test(this.BinarySearch2);
            Test(this.BinarySearchRecursive);
        }
    }
}
