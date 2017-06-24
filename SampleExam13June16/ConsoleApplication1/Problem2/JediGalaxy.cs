using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2
{
    class JediGalaxy
    {
        static void Main(string[] args)
        {
            long ivoStartValue = 0;

            int[] matrixDimenssions = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var ivoInputCordinates = Console.ReadLine();
            int[,] matrix = new int[matrixDimenssions[0], matrixDimenssions[1]];

            FillMatrix(matrix);

            while (ivoInputCordinates != "Let the Force be with you")
            {
                var evalInputCordinates = Console.ReadLine();

                int[] ivoParsedCoordinates = ivoInputCordinates.Split().Select(int.Parse).ToArray();
                int[] evalParsedCoordinates = evalInputCordinates.Split().Select(int.Parse).ToArray();

                int currentIvoRow = ivoParsedCoordinates[0];
                int currentIvoCol = ivoParsedCoordinates[1];

                int currentEvilRow = evalParsedCoordinates[0];
                int currentEvilCol = evalParsedCoordinates[1];

                while (currentEvilRow >= 0 && currentEvilCol >= 0)
                {
                    if (IsInMatric(matrix, currentEvilRow, currentEvilCol))
                    {
                        matrix[currentEvilRow, currentEvilCol] = 0;
                    }
                    currentEvilRow--;
                    currentEvilCol--;
                }

                while (currentIvoRow >= 0 && currentIvoCol < matrix.GetLength(1))
                {
                    if (IsInMatric(matrix,currentIvoRow,currentIvoCol))
                    {
                        ivoStartValue += matrix[currentIvoRow, currentIvoCol];
                    }
                    currentIvoRow--;
                    currentIvoCol++;
                }

                ivoInputCordinates = Console.ReadLine();
            }
            Console.WriteLine(ivoStartValue);
        }

        private static bool IsInMatric(int[,] matrix, int givenRow, int givenCol)
        {
            bool result = givenRow >= 0 
                && givenRow < matrix.GetLength(0)
                && givenCol >= 0 
                && givenCol < matrix.GetLength(1);
            return result;
        }

        private static void FillMatrix(int[,] matrix)
        {
            int currentCount = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i,j] = currentCount;
                    currentCount++;
                }
            }
        }
    }
}
