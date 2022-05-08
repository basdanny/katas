using System;
using System.Collections.Generic;

namespace Katas
{

    /*
       Two dimensional board (matrix) consisting of 0 and 1
       need to find path between origin and destination when you can go only on '1'
    */

    public class MatrixPath
    {
        public static string GetPath(int[,] matrix, int row, int col, Tuple<int, int> dest, HashSet<string> setUsed = null, string path = "")
        {
            if (setUsed == null)
                setUsed = new HashSet<string>();

            if (row < 0 || row > matrix.GetLength(0) - 1 || col < 0 || col > matrix.GetLength(1) - 1 //out of bounds of array
                || matrix[row, col] == 0 //cant walk on 0
                || setUsed.Contains(row + "," + col)) //already walked here
                return null;

            PrintMatrix(matrix, row, col); //for visualization only

            if (row == dest.Item1 && col == dest.Item2)
                return path;

            setUsed.Add(row + "," + col); //add current step


            string route = GetPath(matrix, row, col - 1, dest, setUsed, path + " Left ");
            if (!string.IsNullOrEmpty(route)) return route;
            route = GetPath(matrix, row - 1, col, dest, setUsed, path + " Up ");
            if (!string.IsNullOrEmpty(route)) return route;
            route = GetPath(matrix, row, col + 1, dest, setUsed, path + " Right ");
            if (!string.IsNullOrEmpty(route)) return route;
            route = GetPath(matrix, row + 1, col, dest, setUsed, path + " Down ");
            if (!string.IsNullOrEmpty(route)) return route;

            return string.Empty;
        }

        public static int[,] InitMatrix()
        {
            int[,] matrix = new int[,] {
                { 0, 1, 0 },
                { 0, 1, 1 },
                { 0, 0, 1 },
                { 1, 1, 1 }
            };

            return matrix;
        }

        public static void PrintMatrix(int[,] matrix, int markRow = -1, int markColumn = -1)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (markRow >= 0 && row == markRow && col == markColumn)
                        Console.ForegroundColor = ConsoleColor.Red;

                    Console.Write(matrix[row, col] + " ");

                    Console.ResetColor();
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
