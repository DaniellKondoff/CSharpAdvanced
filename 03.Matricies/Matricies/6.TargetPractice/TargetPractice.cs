using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.TargetPractice
{
    class TargetPractice
    {
        static void Main(string[] args)
        {
            var dimensions = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string snake = Console.ReadLine();
            var shotParametars = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int numberOfRows = dimensions[0];
            int numberOfCols = dimensions[1];
            int impactRow = shotParametars[0];
            int impactCol = shotParametars[1];
            int shotRadius = shotParametars[2];

            var matrix = new char[numberOfRows][];

            FillMatrix(matrix, snake, numberOfCols);

            FireShot(matrix, impactCol, impactRow, shotRadius);

            DropChars(matrix);

            PrintMatrix(matrix);

        }

        private static void PrintMatrix(char[][] matrix)
        {
            foreach (var row in matrix)
            {
                Console.WriteLine(string.Join("",row));
            }
        }

        private static void DropChars(char[][] matrix)
        {
            for (int row = matrix.Length - 1; row >= 0; row--)
            {
                for (int column = 0; column < matrix[row].Length; column++)
                {
                    if (matrix[row][column] != ' ')
                    {
                        continue;
                    }

                    int currentRow = row - 1;
                    while (currentRow >= 0)
                    {
                        if (matrix[currentRow][column] != ' ')
                        {
                            matrix[row][column] = matrix[currentRow][column];
                            matrix[currentRow][column] = ' ';
                            break;
                        }

                        currentRow--;
                    }
                }
            }
        }

        private static void FireShot(char[][] matrix, int impactCol, int impactRow, int shotRadius)
        {
            int matrixWidth = matrix[0].Length;

            for (int row = 0; row < matrix.Length; row++)
            {
                for (int col = 0; col < matrix[row].Length; col++)
                {
                    if (IsInsideRadius(row, col, impactRow, impactCol, shotRadius))
                    {
                        matrix[row][col] = ' ';
                    }
                }
            }
        }

        private static bool IsInsideRadius(int row, int col, int impactRow, int impactCol, int shotRadius)
        {
            int deltaRow = row - impactRow;
            int deltaCol = col - impactCol;

            bool isInRadius = deltaRow * deltaRow + deltaCol * deltaCol <= shotRadius * shotRadius;

            return isInRadius;
        }

        private static void FillMatrix(char[][] matrix, string snake, int numberOfCols)
        {
            for (int i = 0; i < matrix.Length; i++)
            {
                matrix[i] = new char[numberOfCols];
            }

            bool isMovingLeft = true;
            int currentSymbolIndex = 0;

            for (int row = matrix.Length - 1; row >= 0; row--)
            {
                int col = isMovingLeft ? numberOfCols - 1 : 0;
                int colUpdate = isMovingLeft ? -1 : 1;

                while (0<=col && col < numberOfCols)
                {
                    if (currentSymbolIndex >= snake.Length)
                    {
                        currentSymbolIndex = 0;
                    }

                    matrix[row][col] = snake[currentSymbolIndex];

                    currentSymbolIndex++;
                    col += colUpdate;
                }

                isMovingLeft = !isMovingLeft;
            }
        }

        
    }
}
