using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.LegoBlocks
{
    class LegoBlocks
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            bool isLego = true;

            var matrix = new int[2*n][];

            for (int row = 0; row <n*2; row++)
            {
                if (row < n)
                {
                    matrix[row] = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                }
                else
                {
                    matrix[row] = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).Reverse().ToArray();
                }
            }

            for (int row = 1; row < n; row++)
            {
                if ((matrix[row].Length + matrix[row+n].Length) != (matrix[row - 1].Length + matrix[row-1+n].Length))
                {
                    isLego = false;
                }
            }

            if (isLego)
            {
                for (int row = 0; row < n; row++)
                {                
                    Console.WriteLine($"[{string.Join(", ",matrix[row])}, {string.Join(", ",matrix[row+n])}]");
                }

            }
            else
            {
                int count = 0;
                for (int i = 0; i < 2*n; i++)
                {
                    count += matrix[i].Length;
                }
                Console.WriteLine($"The total number of cells is: {count}");
            }
        }
    }
}
