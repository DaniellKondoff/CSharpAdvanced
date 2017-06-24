using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.DirectoryTraversal
{
    class DirectoryTraversal
    {
        static void Main(string[] args)
        {
            var filePath = Directory.GetFiles("../../", "*.*", SearchOption.TopDirectoryOnly);
            var files = filePath.Select(p => new FileInfo(p)).ToList();

            var sortedFiles = files.OrderBy(f => f.Length)
                .GroupBy(f => f.Extension)
                .OrderByDescending(g => g.Count())
                .ThenBy(g => g.Key);

            var desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            using (var writerStream=new StreamWriter(desktop+"/report.txt"))
            {
                foreach (var file in sortedFiles)
                {
                    writerStream.WriteLine($"{file.Key}");
                    foreach (var group in file)
                    {
                        writerStream.WriteLine($"--{group.Name} - {(group.Length/1024):F3}kb");
                    }
                }
            }
        }
    }
}
