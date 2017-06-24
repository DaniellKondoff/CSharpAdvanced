using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.SlicingFile
{
    public class SlicingFile
    {
        static void Main(string[] args)
        {
            List<string> files = new List<string>();

            Console.Write("Enter number of parts to slice the file: ");
            int numberOfParts = int.Parse(Console.ReadLine());

            SliceFile(@"../../zip.zip", @"../../", numberOfParts);

            Assemble(files, "@../../");
        }

        private static void Assemble(List<string> files, string destinationDirectory)
        {
            using (var writer= new FileStream(destinationDirectory+"assembled",FileMode.Create))
            {
                
                foreach (var file in files)
                {
                    using (var reader = new FileStream(file, FileMode.Open))
                    {
                        var buffer = new byte[4096];
                        while (true)
                        {
                            int readBytes = reader.Read(buffer, 0, buffer.Length);
                            if (readBytes==0)
                            {
                                break;
                            }

                            writer.Write(buffer, 0, readBytes);
                        }
                    }
                }
            }
        }

        private static void SliceFile(string sourceFile, string destinationDirectory, int numberOfParts)
        {
            using (var reader = new FileStream(sourceFile, FileMode.Open))
            {
                var partSize = Math.Ceiling(reader.Length / (double)numberOfParts);

                for (int i = 1; i <= numberOfParts; i++)
                {
                    using (var writer = new FileStream($"{destinationDirectory}File-{i}", FileMode.Create))
                    {
                        var buffer = new byte[4096];
                        long currentSize = 0;
                        while (currentSize < partSize)
                        {
                            int readBytes = reader.Read(buffer, 0, buffer.Length);
                            if (readBytes == 0)
                            {
                                break;
                            }
                            writer.Write(buffer, 0, readBytes);
                            currentSize += readBytes;
                        }
                    }
                }
            }
        }
    }
}
