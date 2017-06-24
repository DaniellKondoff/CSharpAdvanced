using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.LineNumbers
{
    class LineNumbers
    {
        static void Main(string[] args)
        {

            var inputFile = File.ReadAllLines("input.txt");

            using (var writer=File.AppendText("output.txt"))
            {
                
                for (int i = 0; i < inputFile.Length; i++)
                {
                    writer.WriteLine($"{i+1}. {inputFile[i]}");
                }
            }

        }
    }
}
