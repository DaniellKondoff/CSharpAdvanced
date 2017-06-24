using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.DiagonalDifference
{
    class DiagonalDifference
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[][] matrix = new int[n][];

            for (int row = 0; row < matrix.Length; row++)
            {
                matrix[row] = Console.ReadLine().Split(new[] {' '},StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            }

            var firstDiagonal = 0;
            var secondDiagonal = 0;
            long difference = 0;


            for (int row = 0; row < matrix.Length; row++)
            {
                firstDiagonal += matrix[row][row];
                secondDiagonal += matrix[row][matrix.Length-row-1];
            }
            difference = Math.Abs(firstDiagonal - secondDiagonal);

            Console.WriteLine(difference);
        }
    }
}
