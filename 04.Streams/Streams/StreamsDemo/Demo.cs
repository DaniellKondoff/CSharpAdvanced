using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace StreamsDemo
{
    class Demo
    {
        static void Main(string[] args)
        {
            StreamWriter writer = new StreamWriter("someFile.txt");

            for (int i = 0; i < 10; i++)
            {
                writer.WriteLine(i);
            }

            writer.Close();

            StreamReader reader = new StreamReader("someFile.txt");

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(reader.ReadLine());
            }
            reader.Close();

           
        }
    }
}
