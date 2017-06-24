using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.CopyBinaryFile
{
    class CopyBinaryFile
    {
        static void Main(string[] args)
        {
           const string sourceFilepath = "../../RD.jpg";
           const string destinationFilepath = "../../result.jpg";

            using (var source = new FileStream(sourceFilepath, FileMode.Open))
            {
                using (var destination= new FileStream(destinationFilepath,FileMode.Create))
                {
                    var buffer = new byte[4096];

                    while (true)
                    {
                        int readBytes = source.Read(buffer, 0, buffer.Length);
                        if (readBytes==0)
                        {
                            break;
                        }

                        destination.Write(buffer, 0, readBytes);
                    }
                }
            }
        }
    }
}
