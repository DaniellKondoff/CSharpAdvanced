﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.RubikMatrix
{
    class RubikMatrix
    {
        static void Main(string[] args)
        {
            var matrixSize = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var matrix = new int[matrixSize[0]][];
            int counter = 1;

            for (int row = 0; row < matrix.Length; row++)
            {
                matrix[row] = new int[matrixSize[1]];
                for (int col = 0; col < matrix[row].Length; col++)
                {
                    matrix[row][col] = counter;
                    counter++;
                }
            }

            int cmdNum = int.Parse(Console.ReadLine());

            for (int i = 0; i < cmdNum; i++)
            {
                var cmdTokens = Console.ReadLine().Split(new[] { ' ' },StringSplitOptions.RemoveEmptyEntries);
                var rcIndex = int.Parse(cmdTokens[0]);
                var direction = cmdTokens[1];
                var moves= int.Parse(cmdTokens[2]);

                switch (direction)
                {
                    case "up":
                        MoveCol(matrix, rcIndex, moves);
                        break;
                    case "down":
                        MoveCol(matrix, rcIndex, matrix.Length- moves % matrix.Length);
                        break;
                    case "left":
                        MoveRow(matrix, rcIndex, moves);
                        break;
                    case "right":
                        MoveRow(matrix, rcIndex, matrix[0].Length-moves % matrix[0].Length);
                        break;
                }
            }

            var element = 1;
            for (int row = 0; row < matrix.Length; row++)
            {
                for (int col = 0; col < matrix[row].Length; col++)
                {
                    if (matrix[row][col]==element)
                    {
                        Console.WriteLine("No swap required");
                    }
                    else
                    {
                        for (int r = 0; r < matrix.Length; r++) 
                        {
                            for (int c = 0; c < matrix[r].Length; c++)
                            {
                                if (matrix[r][c]==element)
                                {
                                    var currentElement = matrix[row][col];
                                    matrix[row][col] = element;
                                    matrix[r][c] = currentElement;
                                    Console.WriteLine($"Swap ({row}, {col}) with ({r}, {c})");
                                    break;
                                }
                            }
                        }
                    }
                    element++;
                }
            }
           
        }

        private static void MoveRow(int[][] matrix, int rcIndex, int moves)
        {
            var temp = new int[matrix[0].Length];

            for (int coll = 0; coll < matrix[0].Length; coll++)
            {
                temp[coll] = matrix[rcIndex][(coll + moves) % matrix[0].Length];
            }
            matrix[rcIndex] = temp;
        }

        private static void MoveCol(int[][] matrix, int rcIndex, int moves)
        {
            var temp = new int[matrix.Length];
            for (int row = 0; row < matrix.Length; row++)
            {
                temp[row] = matrix[(row+moves) % matrix.Length][rcIndex];
            }

            for (int row = 0; row < matrix.Length; row++)
            {
                matrix[row][rcIndex] = temp[row];
            }
        }
    }
}