using System.Linq;

namespace MyDelicatessen.ArrayProblems
{
    public class SetZeroesProblem
    {
        public class Solution_Ineficient
        {
            public void SetZeroes(int[][] matrix)
            {
                bool[] rowsZeroes = new bool[matrix.Length];
                bool[] columnsZeroes = new bool[matrix[0].Length];

                for (int i = 0; i < matrix.Length; i++)
                {
                    for (int j = 0; j < matrix[i].Length; j++)
                    {
                        if (matrix[i][j] == 0)
                        {
                            rowsZeroes[i] = true;
                            columnsZeroes[j] = true;
                        }
                    }
                }

                for (int i = 0; i < rowsZeroes.Length; i++)
                {
                    if (rowsZeroes[i])
                    {
                        for (int j = 0; j < matrix[i].Length; j++)
                        {
                            matrix[i][j] = 0;
                        }
                    }
                }

                for (int j = 0; j < columnsZeroes.Length; j++)
                {
                    if (columnsZeroes[j])
                    {
                        for (int i = 0; i < matrix.Length; i++)
                        {
                            matrix[i][j] = 0;
                        }
                    }
                }
            }
        }

        public class Solution_Efficient
        {
            public void SetZeroes(int[][] matrix)
            {
                bool firstRowIsZero = matrix[0].Any(v => v == 0);
                bool firstColumnIsZero = AnyZeroColumn(0, matrix);

                MarkZeroes(matrix);
                FillZeroes(matrix);

                if (firstColumnIsZero)
                {
                    //fill first row and colum
                    for (int row = 0; row < matrix.Length; row++)
                    {
                        matrix[row][0] = 0;
                    }

                }

                if (firstRowIsZero)
                {
                    //fill first row and colum
                    for (int column = 0; column < matrix[0].Length; column++)
                    {
                        matrix[0][column] = 0;
                    }
                }
            }

            private bool AnyZeroColumn(int column, int[][] matrix)
            {
                for (int row = 0; row < matrix.Length; row++)
                {
                    if (matrix[row][column] == 0)
                    {
                        return true;
                    }
                }
                return false;
            }

            private void MarkZeroes(int[][] matrix)
            {
                for (int row = 1; row < matrix.Length; row++)
                {
                    for (int column = 1; column < matrix[row].Length; column++)
                    {
                        if (matrix[row][column] == 0)
                        {
                            matrix[0][column] = 0;
                            matrix[row][0] = 0;
                        }
                    }
                }
            }

            private void FillZeroes(int[][] matrix)
            {
                for (int r = 1; r < matrix.Length; r++)
                {
                    if (matrix[r][0] == 0)
                    {
                        for (int c = 0; c < matrix[r].Length; c++)
                        {
                            matrix[r][c] = 0;
                        }
                    }
                }

                for (int c = 1; c < matrix[0].Length; c++)
                {
                    if (matrix[0][c] == 0)
                    {
                        for (int r = 0; r < matrix.Length; r++)
                        {
                            matrix[r][c] = 0;
                        }
                    }
                }
            }
        }
    }
}
