using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.ZippingSlicedFiles
{
    class Zipping
    {
        static void Main(string[] args)
        {
            var files = Directory.GetFiles(@"../../", "*.gz*", SearchOption.AllDirectories).ToList();

            Console.Write("Enter number of parts to slice the file: ");
            int numberOfParts = int.Parse(Console.ReadLine());

            SliceFile(@"../../DLG.mp3", @"../../", numberOfParts);

            Assemble(files, "@../../");

        }
        private static void Assemble(List<string> files, string destinationDirectory)
        {
            using (var writer = new FileStream(destinationDirectory + "assembled", FileMode.Create))
            {

                foreach (var file in files)
                {
                    using (var reader = new FileStream(file, FileMode.Open))
                    {
                        using (var compressionStream = new GZipStream(reader, CompressionMode.Decompress))
                        {
                            var buffer = new byte[4096];
                            while (true)
                            {
                                int readBytes = compressionStream.Read(buffer, 0, buffer.Length);
                                if (readBytes == 0)
                                {
                                    break;
                                }

                                writer.Write(buffer, 0, readBytes);
                            }
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
                    using (var writer = new FileStream($"{destinationDirectory}File-{i}.gz", FileMode.Create))
                    {
                        using (var compressionStream=new GZipStream(writer,CompressionMode.Compress))
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
                                compressionStream.Write(buffer, 0, readBytes);
                                currentSize += readBytes;
                            }
                        }
                        
                    }

                }

            }
        }
    }
}
