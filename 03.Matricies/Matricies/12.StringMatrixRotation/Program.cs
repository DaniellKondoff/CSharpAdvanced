using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.StringMatrixRotation
{
    class Program
    {
        static void Main(string[] args)
        {
            string rotate = Console.ReadLine();
            string[] integer = rotate.Split('(');
            integer[1] = integer[1].Remove(integer[1].Length - 1, 1);
            int degrees = int.Parse(integer[1]);

            var input = Console.ReadLine();
            var list = new List<string>();
            int longestWord = int.MinValue;

            while (input != "END")
            {

                list.Add(input);
                if (longestWord < input.Length)
                {
                    longestWord = input.Length;
                }
                input = Console.ReadLine();
            }

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].Length < longestWord)
                {
                    list[i] = list[i] + new string(' ', longestWord - list[i].Length);
                }
            }

            if (degrees == 180 || degrees % 360 == 180)
            {
                RotateOn180Degrees(list);
            }
            if (degrees == 0 || degrees % 360 == 0)
            {
                RotateOnZeroDegrees(list);
            }

            char[,] rotate90 = new char[longestWord, list.Count];

            for (int row = 0; row < longestWord; row++)
            {
                for (int col = 0; col < list.Count; col++)
                {
                    rotate90[row, col] = list[col][row];
                }
            }

            if (degrees == 270 || degrees % 360 == 270)
            {
                RotateOn270Degrees(rotate90);
            }

            if (degrees == 90 || degrees % 360 == 90)
            {
                RotateOn90Degrees(rotate90);
            }
        }

        private static void RotateOn90Degrees(char[,] rotate90)
        {
            for (int row = 0; row < rotate90.GetLength(0); row++)
            {
                for (int coll = rotate90.GetLength(1) - 1; coll >= 0; coll--)
                {
                    Console.Write(rotate90[row,coll]);
                }
                Console.WriteLine();
            }
        }

        private static void RotateOn270Degrees(char[,] rotate90)
        {
            for (int row = rotate90.GetLength(0) - 1; row >= 0; row--)
            {
                for (int col = 0; col < rotate90.GetLength(1); col++)
                {
                    Console.Write(rotate90[row,col]);
                }
                Console.WriteLine();
            }
        }

        private static void RotateOnZeroDegrees(List<string> list)
        {
            foreach (var row in list)
            {
                Console.WriteLine(string.Join(" ",row));
            }
        }

        private static void RotateOn180Degrees(List<string> list)
        {
            for (int rowIndex = list.Count - 1; rowIndex >= 0; rowIndex--)
            {
                for (int colIndex = list[rowIndex].Length - 1; colIndex >= 0; colIndex--)
                {
                    Console.Write(list[rowIndex][colIndex]);
                }
                Console.WriteLine();
            }
        }
    }
}
