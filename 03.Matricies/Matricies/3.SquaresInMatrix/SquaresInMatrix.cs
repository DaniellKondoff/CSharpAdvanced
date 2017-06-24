using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.SquaresInMatrix
{
    class SquaresInMatrix
    {
        static void Main(string[] args)
        {
            var matrixSize = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var matrix = new char[matrixSize[0]][];
            int counter = 0;

            for (int row = 0; row < matrix.Length; row++)
            {
                matrix[row] = Console.ReadLine().Split(new[] {' '},StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();
            }

            for (int row = 0; row < matrix.Length-1; row++)
            {
                for (int col = 0; col < matrix[row].Length-1; col++)
                {
                    if (matrix[row][col]==matrix[row][col+1] && matrix[row][col]==matrix[row+1][col] && matrix[row][col + 1]== matrix[row+1][col + 1])
                    {
                        counter++;
                    }
                }
            }

            Console.WriteLine(counter);
        }
    }
}
