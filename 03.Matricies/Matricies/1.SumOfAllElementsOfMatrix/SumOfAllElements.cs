using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.SumOfAllElementsOfMatrix
{
    class SumOfAllElements
    {
        static void Main(string[] args)
        {
            var matrixSizes = Console.ReadLine().Split(new string[] {", " }, StringSplitOptions.RemoveEmptyEntries);

            int[,] matrix = new int[int.Parse(matrixSizes[0]), int.Parse(matrixSizes[1])];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                var inputRow=Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = inputRow[col];
                }
            }

            int totalSum = 0;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    totalSum += matrix[row, col];
                }
            }

            Console.WriteLine(matrix.GetLength(0));
            Console.WriteLine(matrix.GetLength(1));
            Console.WriteLine(totalSum);

        }
    }
}
