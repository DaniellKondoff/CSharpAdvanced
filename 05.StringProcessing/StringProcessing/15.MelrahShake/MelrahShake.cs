using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.MelrahShake
{
    class MelrahShake
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine();
            StringBuilder sb = new StringBuilder();
            var pattern = Console.ReadLine();

            while (true)
            {

                int startIndex = text.IndexOf(pattern);
                int lastIndex = text.LastIndexOf(pattern);

                if (startIndex > -1 && lastIndex > -1 && pattern.Length >0)
                {
                    text = text.Remove(lastIndex, pattern.Length);
                    text=text.Remove(startIndex, pattern.Length);
                    sb.AppendLine("Shaked it.");

                    pattern = pattern.Remove(pattern.Length / 2, 1);
                }
                else
                {
                    sb.AppendLine("No shake.");
                    break;
                }
            }

            Console.Write(sb.ToString());
            Console.WriteLine(text);
        }
    }
}
