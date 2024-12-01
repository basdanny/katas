using System;
using System.Diagnostics;
using System.Linq;
using System.Reflection.Metadata.Ecma335;

namespace Katas
{
    class ClockwiseSpiral : IRunTests
    {
        public int[,] CreateSpiral(int N)
        {
            if (N < 1) return new int[0, 0];

            (int, int)[] directions = { (0, 1), (1, 0), (0, -1), (-1, 0) };
            var matrix = new int[N, N];
            int currentDirectionIndex = 0;
            int i = 0, j = 0;

            for (int currentNum = 1; currentNum <= N * N; currentNum++)
            {
                matrix[i, j] = currentNum;

                var (ii, jj) = (i + directions[currentDirectionIndex].Item1, j + directions[currentDirectionIndex].Item2);
                if (ii < 0 || ii >= N || jj < 0 || jj >= N || matrix[ii, jj] != 0)
                    currentDirectionIndex = (currentDirectionIndex + 1) % 4;

                (i, j) = (i + directions[currentDirectionIndex].Item1, j + directions[currentDirectionIndex].Item2);
            }

            return matrix;
        }

        public static int[,] CreateSpiral2(int N)
        {
            int[,] output = new int[N, N];
            int col = -1, row = 0, num = 1;
            for (int i = 0; i < N; i++)
            {
                while (col + 1 < N && output[row, col + 1] == 0) output[row, ++col] = num++;
                while (row + 1 < N && output[row + 1, col] == 0) output[++row, col] = num++;
                while (col > 0 && output[row, col - 1] == 0) output[row, --col] = num++;
                while (row > 0 && output[row - 1, col] == 0) output[--row, col] = num++;
            }
            return output;
        }

        public void RunTests()
        {
            var expected = new int[,] { { 1 } };
            Debug.Assert(AreEqual(expected, CreateSpiral(1)));

            expected = new int[,]
                {
                    {1, 2, 3},
                    {8, 9, 4},
                    {7, 6, 5}
                };
            Debug.Assert(AreEqual(expected, CreateSpiral(3)));
            Debug.Assert(AreEqual(expected, CreateSpiral2(3)));
        }

        private bool AreEqual(int[,] matrix1, int[,] matrix2)
        {
            if (matrix1.Length != matrix2.Length)
                return false;

            for (int i = 0; i < matrix1.GetLength(0); i++)
            {
                for (int j = 0; j < matrix1.GetLength(1); j++)
                {
                    if (matrix1[i, j] != matrix2[i, j])
                        return false;
                }
            }

            return true;
        }
    }
}