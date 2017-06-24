namespace _9.Crossfire
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Crossfire
    {
        static void Main(string[] args)
        {
            var matrixSize = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rows = matrixSize[0];
            int colls = matrixSize[1];

            var matrix = FillMatrix(rows, colls);

            var commandTokens = Console.ReadLine();

            while (commandTokens != "Nuke it from orbit")
            {
                var parametars = commandTokens.Split().Select(int.Parse).ToArray();
                int rowImpact = parametars[0];
                int collImpact = parametars[1];
                int radius = parametars[2];

                for (int rowIndex = rowImpact - radius; rowIndex <= rowImpact + radius; rowIndex++)
                {
                    if (IsInMatrx(rowIndex,collImpact,matrix))
                    {
                        matrix[rowIndex][collImpact] = -1;
                    }
                }

                for (int collIndex = collImpact-radius; collIndex <= collImpact+radius; collIndex++)
                {
                    if (IsInMatrx(rowImpact, collIndex, matrix))
                    {
                        matrix[rowImpact][collIndex] = -1;
                    }
                }
                FilerMatric(matrix);
                commandTokens = Console.ReadLine();
            }

            PrintMatrix(matrix);
        }

        private static void FilerMatric(List<List<int>> matrix)
        {
            for (int rowIndex = matrix.Count-1; rowIndex >=0; rowIndex--)
            {
                for (int collIndex = matrix[rowIndex].Count - 1; collIndex >= 0; collIndex--)
                {
                    if (matrix[rowIndex][collIndex]== -1)
                    {
                        matrix[rowIndex].RemoveAt(collIndex);
                    }
                }

                if (matrix[rowIndex].Count==0)
                {
                    matrix.RemoveAt(rowIndex);
                }

            }
        }

        private static void PrintMatrix(List<List<int>> matrix)
        {
            foreach (var row in matrix)
            {
                Console.WriteLine(string.Join(" ",row));
            }
        }

        private static bool IsInMatrx(int currentRow, int currentColl, List<List<int>> matrix)
        {
            if (currentRow >= 0 && currentRow < matrix.Count && currentColl >=0 && currentColl < matrix[currentRow].Count)
            {
                return true;
            }
            return false;
        }

        private static List<List<int>> FillMatrix(int rows,int colls)
        {
            var matrix = new List<List<int>>();
            int counter = 1;
            for (int rowIndex = 0; rowIndex < rows; rowIndex++)
            {
                matrix.Add(new List<int>());
                for (int collIndex = 0; collIndex < colls; collIndex++)
                {
                    matrix[rowIndex].Add(counter);
                    counter++;
                }
            }

            return matrix;
        }


    }
}
