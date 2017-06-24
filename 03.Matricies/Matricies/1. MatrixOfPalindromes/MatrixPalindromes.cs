using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.MatrixOfPalindromes
{
    class MatrixPalindromes

    {
        static void Main(string[] args)
        {
            var matrixSizes = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var matrix = new string[matrixSizes[0]][];
            char[] alphabet = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
            int counter = 0;

            for (int row = 0; row < matrix.Length; row++)
            {
                matrix[row] = new string[matrixSizes[1]];
                for (int col = 0; col < matrix[row].Length; col++)
                {
                    matrix[row][col] = alphabet[row].ToString() + alphabet[col+counter].ToString() + alphabet[row];
                }
                counter++;
            }

            foreach (var row in matrix)
            {
                Console.WriteLine(string.Join(" ",row));
            }
        }
    }
}
