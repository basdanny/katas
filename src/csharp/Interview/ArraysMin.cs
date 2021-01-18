using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview
{
    /*
     *  Given two arrays, return the index of the minimal value present in both arrays, or -1 if non exists
     */
    class ArraysMin
    {
        public static int GetMinimalValueOfSharedElement(int[] arr1, int[] arr2)
        {
            int n = arr1.Length;
            int m = arr2.Length;

            Array.Sort(arr1);
            Array.Sort(arr2);

            int i = 0;
            int k = 0;
            while (i<n && k<m)
            {
                if (arr1[i] == arr1[k])
                    return arr1[i];
                else if (arr1[i] < arr2[k])
                    i++;
                else
                    k++;
            }

            return -1;
        }

        /// <summary>
        /// You are given two arrays A and B each containing n, integers. 
        /// You need to choose exactly one number from A and exactly one number from B such that the index of the two 
        /// chosen numbers is not same and the sum of the 2 chosen values is minimum.
        /// </summary>        
        public static int MinSumOfTwoArrays(int[] arr1, int[] arr2)
        {
            Tuple<int, int> smallest1 = new Tuple<int, int>(-1, int.MaxValue);
            Tuple<int, int> secondsmall1 = new Tuple<int, int>(-1, int.MaxValue);

            for (int i = 0; i < arr1.Length; i++)
            {
                if (arr1[i] < smallest1.Item2)
                {
                    secondsmall1 = new Tuple<int, int>(smallest1.Item1, smallest1.Item2);
                    smallest1 = new Tuple<int, int>(i, arr1[i]);
                }
                else if (arr1[i] < secondsmall1.Item2 && arr1[i] != smallest1.Item2)
                    secondsmall1 = new Tuple<int, int>(i, arr1[i]);
            }

            Tuple<int, int> smallest2 = new Tuple<int, int>(-1, int.MaxValue);
            Tuple<int, int> secondsmall2 = new Tuple<int, int>(-1, int.MaxValue);
            for (int i = 0; i < arr2.Length; i++)
            {
                if (arr2[i] < smallest2.Item2)
                {
                    secondsmall2 = new Tuple<int, int>(smallest2.Item1, smallest2.Item2);
                    smallest2 = new Tuple<int, int>(i, arr2[i]);
                }
                else if (arr2[i] < secondsmall2.Item2 && arr2[i] != smallest2.Item2)
                    secondsmall2 = new Tuple<int, int>(i, arr2[i]);
            }

            Console.WriteLine($"Smallest index:{smallest1.Item1} value: {smallest1.Item2}");
            Console.WriteLine($"Second small index:{secondsmall1.Item1} value: {secondsmall1.Item2}");
            Console.WriteLine($"Smallest index:{smallest2.Item1} value: {smallest2.Item2}");
            Console.WriteLine($"Second small index:{secondsmall2.Item1} value: {secondsmall2.Item2}");

            if (smallest1.Item1 != smallest2.Item1)
                return (smallest1.Item2 + smallest2.Item2);
            else
                return Math.Min((smallest1.Item2 + secondsmall2.Item2), (secondsmall1.Item2 + smallest2.Item2));


        }
    }
}
