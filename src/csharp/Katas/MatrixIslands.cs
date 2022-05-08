using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Katas
{
    // In a matrix of 1 (land) and 0 (water), count the number of islands - adjacent `1`s   
    class MatrixIslands : IRunTests
    {
        public int GetNumberOfIslands(int[,] matrix)
        {
            var rowsCount = matrix.GetLength(0);
            var columnsCount = matrix.GetLength(1);

            var numberOfIslands = 0;
            for (int row = 0; row < rowsCount; row++)
            {
                for (int col = 0; col < columnsCount; col++)
                {
                    if (matrix[row, col] == 1)
                    {
                        numberOfIslands++;
                        //PrintMatrix(matrix);
                        MarkVisited(row, col, matrix, rowsCount, columnsCount);
                        //PrintMatrix(matrix);
                    }
                }
            }
                   
            return numberOfIslands;
        }

        private void MarkVisited(int row, int col, int[,] matrix, int rowsCount, int columnsCount)
        {
            if (row < 0 || row >= rowsCount || col < 0 || col >= columnsCount)
                return;

            if (matrix[row, col] == 1)
            {
                matrix[row, col] = 0;

                MarkVisited(row, col - 1, matrix, rowsCount, columnsCount); //left
                MarkVisited(row, col + 1, matrix, rowsCount, columnsCount); //right
                MarkVisited(row - 1, col, matrix, rowsCount, columnsCount); //top
                MarkVisited(row + 1, col, matrix, rowsCount, columnsCount); //bottom
            }
        }

        private void PrintMatrix(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {                    
                    Console.Write(matrix[row, col] + " ");                    
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        public void RunTests()
        {
            int[,] input1 = new int[,] {
                { 0, 1, 0 },
                { 0, 1, 1 },
                { 1, 0, 0 },
                { 1, 1, 1 }
            };

            var numOfIslands = GetNumberOfIslands(input1);
            //Console.WriteLine("Number of islands: " + numOfIslands);
            
            Debug.Assert(numOfIslands == 2);
        }
    }
}
