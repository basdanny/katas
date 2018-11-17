using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Interview
{
    class Program
    {
        static void Main(string[] args)
        {
            #region MatrixPath
            /*
            int[,] matrix = MatrixPath.InitMatrix();
            MatrixPath.PrintMatrix(matrix, 3, 0);            
            Console.WriteLine("\n"+ MatrixPath.GetPath(matrix, 3, 0, Tuple.Create(0, 1)));
            */
            #endregion



            #region CommonAncestor + TreeAmplitude
            /*
            Node<int> root = new Node<int>("A", 1);
            root.left = new Node<int>("B", 2);
            root.right = new Node<int>("C", 5);
            root.right.left = new Node<int>("D", 4);
            root.right.right = new Node<int>("E", 3);
            root.right.left.left = new Node<int>("F", 1);
            root.right.left.right = new Node<int>("G", 2);

            Node<int>.PrintLevelByLevel(root); //or Node<string>.PrintRecursive(root);
            Console.WriteLine("Common ancestor is: " +
                Node<int>.LeastCommonAncestor(root, root.right.left.left, root.right.right).name);


            Console.WriteLine(" TreeAmplitude: " +
                TreeAmplitude<int>.GetTreeAmplitude(root)
                );
            */
            #endregion

            #region AlmostSortedArray
            /*
            int[] array = { 10, 20, 60, 40, 50, 30 };
            Console.WriteLine("input: [{0}]", string.Join(", ", array));
            AlmostSortedArray.SortByOneSwap(array);
            Console.WriteLine("output: [{0}]", string.Join(", ", array));
            */
            #endregion

            #region AlmostSortedArray
            /*
            FizzBuzz.FizzBuzzPrint(30);
            */
            #endregion

            #region AlmostSortedArray
            /*
            Fibonacci.PrintFibonacciIterative(26);
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine(Fibonacci.FibonacciElementRecursive(26));
            */
            #endregion

            #region AlmostSortedArray
            /*
            int[] arr1 = { 3, 1, 4, 2 }; 
            int[] arr2 = { 6, 1, 2, 9 };

            Console.WriteLine("----------------------------\n" +
                ArraysMin.MinSumOfTwoArrays(arr1, arr2));

            
            int[] arr11 = { 3, 9, 10, 4, 7 };
            int[] arr22 = { 6, 3, 2, 10 };
            Console.WriteLine("Minimal shared element value: " + ArraysMin.GetMinimalValueOfSharedElement(arr11, arr22));            
            */
            #endregion


            #region SquareRoots
            //Console.WriteLine(SquareRoots.SquareDigits(9119));
            #endregion

            Console.WriteLine("\n");
            Console.ReadKey();            
        }


    }
}
