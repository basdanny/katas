using System;

namespace Interview
{
    class Program
    {
        static void Main(string[] args)
        {

            #region BubbleSort            
            new BubbleSort().RunTests();
            #endregion



            #region SearchBytesInFile
            new SearchBytesInFile().RunTests();
            #endregion


            #region BinarySearch            
            new BinarySearch().RunTests();            
            #endregion


            #region MatrixPath            
            /*int[,] matrix = MatrixPath.InitMatrix();
            Console.WriteLine("input: ");
            MatrixPath.PrintMatrix(matrix, 3, 0);
            Console.WriteLine("path: ");
            Console.WriteLine(MatrixPath.GetPath(matrix, 3, 0, Tuple.Create(0, 1)));*/
            #endregion


            #region CommonAncestor + TreeAmplitude
            // Node<int> root = new Node<int>("A", 1);
            // root.left = new Node<int>("B", 20);
            // root.right = new Node<int>("C", 100);
            // root.right.left = new Node<int>("D", 40);
            // root.right.right = new Node<int>("E", 30);
            // root.right.left.left = new Node<int>("F", 10);
            // root.right.left.right = new Node<int>("G", 20);

            // Node<int>.PrintLevelByLevel(root); //or Node<string>.PrintRecursive(root);
            // Console.WriteLine("Common ancestor is: " + Node<int>.LeastCommonAncestor(root, root.right.left.left, root.right.right).name);

            // Console.WriteLine(" TreeAmplitude: " + TreeAmplitude<int>.GetTreeAmplitude(root));
            #endregion


            #region AlmostSortedArray
            new AlmostSortedArray().RunTests();
            #endregion


            #region FizzBuzz
            //FizzBuzz.FizzBuzzPrint(30);
            #endregion


            #region Fibonacci            
            new Fibonacci().RunTests();
            #endregion


            #region ArraysMin            
            // int[] arr1 = { 3, 1, 4, 2 };
            // int[] arr2 = { 6, 1, 2, 9 };

            // Console.WriteLine("----------------------------\n" +
            //     ArraysMin.MinSumOfTwoArrays(arr1, arr2));


            // int[] arr11 = { 3, 9, 10, 4, 7 };
            // int[] arr22 = { 6, 3, 2, 10 };
            // Console.WriteLine("Minimal shared element index: " + ArraysMin.GetIndexOfMinimalValueOfSharedElement(arr11, arr22));
            #endregion


            #region SquareRoots
            // Console.WriteLine("9119 digits square roots are: " + SquareRoots.GetDigitsSquareRoots(9119));
            // Console.WriteLine("9119 digits square roots are: " + SquareRoots.GetDigitsSquareRoots2(9119));
            #endregion

            #region MatrixLargestSquare
            /*MatrixLargestSquare m = new MatrixLargestSquare();

            Console.WriteLine("largest square of 1's is: "+m.GetLargestSquare());
            Console.WriteLine("largest square recursive of 1's is: " + m.GetLargestSquareRecursive());*/
            #endregion

            #region CommonDivisor
            // Console.WriteLine("GCD " + CommonDivisor.GetGreatestCommonDivisor(4, 8));
            // Console.WriteLine("GCD " + CommonDivisor.GetGreatesCommonDivisorEuclidean(4, 8));

            // Console.WriteLine("LCM " + CommonDivisor.GetLeastCommonMultiple(10, 135));
            // Console.WriteLine("LCM " + CommonDivisor.GetLeastCommonMultiple2(10, 135));

            // Console.WriteLine("LCM " + CommonDivisor.GetLeastCommonMultiple(3, 4));
            // Console.WriteLine("LCM " + CommonDivisor.GetLeastCommonMultiple2(3, 4));
            #endregion

            #region Sets
            //Intersections.Do();
            #endregion

            #region AdjacencyMatrix                        
            // AdjacencyMatrix.Graph g = new AdjacencyMatrix.Graph(5, 4);
            // g.AddEdge(0, 1);
            // g.AddEdge(0, 2);
            // g.AddEdge(1, 3);

            // g.BFS(0);
            #endregion

            #region DataStructures
            //DataStructures.Play();
            #endregion

            #region Any
            new Any().RunTests();
            #endregion

            #region DataStructures
            new Anagram().RunTests();
            #endregion

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Tests completed!");
            Console.ForegroundColor = ConsoleColor.White;
            //Console.ReadKey();
        }
    }
}
