using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview
{
    /*
     *  Largest Square of 1's in A Matrix
     */
    public class MatrixLargestSquare
    {
        int[,] _matrix;

        public MatrixLargestSquare()
        {
            _matrix = new int[,] {
                { 0, 0, 0, 0 },
                { 1, 1, 1 ,1 },
                { 1, 1, 1, 1 },
                { 0, 1, 1, 1 }
            };
        }

        public int GetLargestSquare()
        {
            int rowsCount = _matrix.GetLength(0);
            int columnsCount = _matrix.GetLength(0);
            int[,] resultMatrix = (int[,])_matrix.Clone();
            int maxSize = 0;

            for (int i = 0; i < rowsCount; i++)
            {
                for (int j = 0; j < columnsCount; j++)
                {
                    if (i != 0 && j != 0) //first row and first column can't get bigger
                    {
                        if (resultMatrix[i, j] == 1)
                            resultMatrix[i, j] = 1 + Math.Min(resultMatrix[i - 1, j], Math.Min(resultMatrix[i - 1, j - 1], resultMatrix[i, j - 1])); //minimum of (up, up-left, left) + me
                    }

                    maxSize = Math.Max(maxSize, resultMatrix[i, j]);
                }
            }

            return maxSize;
        }

        public int GetLargestSquareRecursive()
        {
            int[,] resultMatrix = (int[,])_matrix.Clone();
            int maxSize = 0;
            GetLargestSquareRecursive(ref maxSize, resultMatrix);
            return maxSize;
        }

        private int GetLargestSquareRecursive(ref int maxSize, int[,] resultMatrix, int i = 0, int j = 0)
        {
            int rowsCount = _matrix.GetLength(0);
            int columnsCount = _matrix.GetLength(0);

            if (i >= rowsCount)
                return 0;
            if (j >= columnsCount)
                return 0;

            int right = GetLargestSquareRecursive(ref maxSize, resultMatrix, i, j + 1);
            int rightDown = GetLargestSquareRecursive(ref maxSize, resultMatrix, i + 1, j + 1);
            int down = GetLargestSquareRecursive(ref maxSize, resultMatrix, i + 1, j);

            int neighboursMin = Math.Min(right, Math.Min(rightDown, down));
            resultMatrix[i, j] = resultMatrix[i, j] == 0 ? 0 : 1 + neighboursMin;

            maxSize = Math.Max(resultMatrix[i, j], Math.Max(right, Math.Max(rightDown, down)));

            return resultMatrix[i, j];
        }

    }
}