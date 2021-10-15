using System;
using System.Diagnostics;

namespace Interview
{
    public class BinarySearch
    {
        /// <summary>
        /// A binary chop method that takes an integer search target and a sorted array of integers. 
        /// It should return the integer index of the target in the array, or -1 if the target is not in the array.
        /// </summary>
        public static int Chop(int number, int[] array)
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

        public static int Chop2(int number, int[] array)
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

        public static int ChopRecursive(int number, int[] array)
        {
            if (array.Length <= 0)
                return -1;

            int startIndex = 0;
            int endIndex = array.Length - 1;
            return ChopRecursive(number, array, startIndex, endIndex);
        }

        private static int ChopRecursive(int number, int[] array, int startIndex, int endIndex)
        {
            if (startIndex <= endIndex)
            {

                int splitIndex = startIndex + ((endIndex - startIndex) / 2);

                if (array[splitIndex] == number)
                    return splitIndex;
                else if (array[splitIndex] >= number)
                    return ChopRecursive(number, array, startIndex, splitIndex-1);
                else
                    return ChopRecursive(number, array, splitIndex+1, endIndex);
            }

            return -1;
        }


        public static void Test(Func<int, int[], int> chop)
        {
            Debug.Assert(-1 == chop(3, new int[] { }));
            Debug.Assert(-1 == chop(3, new int[] { 1 }));
            Debug.Assert(0 == chop(1, new int[] { 1 }));

            Debug.Assert(0 == chop(1, new int[] { 1, 3, 5 }));
            Debug.Assert(1 == chop(3, new int[] { 1, 3, 5 }));
            Debug.Assert(2 == chop(5, new int[] { 1, 3, 5 }));
            Debug.Assert(-1 == chop(0, new int[] { 1, 3, 5 }));
            Debug.Assert(-1 == chop(2, new int[] { 1, 3, 5 }));
            Debug.Assert(-1 == chop(4, new int[] { 1, 3, 5 }));
            Debug.Assert(-1 == chop(6, new int[] { 1, 3, 5 }));

            Debug.Assert(0 == chop(1, new int[] { 1, 3, 5, 7 }));
            Debug.Assert(1 == chop(3, new int[] { 1, 3, 5, 7 }));
            Debug.Assert(2 == chop(5, new int[] { 1, 3, 5, 7 }));
            Debug.Assert(3 == chop(7, new int[] { 1, 3, 5, 7 }));
            Debug.Assert(-1 == chop(0, new int[] { 1, 3, 5, 7 }));
            Debug.Assert(-1 == chop(2, new int[] { 1, 3, 5, 7 }));
            Debug.Assert(-1 == chop(4, new int[] { 1, 3, 5, 7 }));
            Debug.Assert(-1 == chop(6, new int[] { 1, 3, 5, 7 }));
            Debug.Assert(-1 == chop(8, new int[] { 1, 3, 5, 7 }));
        }
    }
}
