﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.SortEvenNumbers
{
    class SortEvenNumbers
    {
        static void Main(string[] args)
        {
            var evenNumbers = Console.ReadLine()
                .Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .Where(n => n % 2 == 0)
                .OrderBy(n => n)
                .ToList();
            Console.WriteLine(string.Join(", ",evenNumbers));
               
            
        }
    }
}
