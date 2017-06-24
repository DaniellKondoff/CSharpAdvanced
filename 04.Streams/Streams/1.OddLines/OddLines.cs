using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.OddLines
{
    class OddLines
    {
        static void Main(string[] args)
        {
            using(StreamReader reader=new StreamReader("input.txt"))
            {
                string line = reader.ReadLine();
                int lineNumber = 0;

                while (line != null)
                {
                    if (lineNumber % 2==1)
                    {
                        Console.WriteLine(line);
                    }
                    line = reader.ReadLine();
                    lineNumber++;
                }
            }

            //SecondOption();
            
        }

        private static void SecondOption()
        {
            var inputText = File.ReadAllLines("input.txt");

            for (int i = 1; i < inputText.Length; i+=2)
            {
                Console.WriteLine(inputText[i]);
                //File.AppendAllText("input.txt", inputText[i] + Environment.NewLine);
            }
        }
    }
}
