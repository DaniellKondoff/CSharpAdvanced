using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.NMS
{
    class NMS
    {
        static void Main(string[] args)
        {
            var input = new StringBuilder();
            string inputLine;

            while ((inputLine=Console.ReadLine()) != "---NMS SEND---")
            {
                input.Append(inputLine);
            }

            var delimiter = Console.ReadLine();
            var message = input.ToString();
            var result = new StringBuilder();
            result.Append(message[0]);

            for (int i = 1; i < message.Length; i++)
            {
                if (string.Compare(message[i].ToString(),message[i-1].ToString(),true) >= 0)
                {
                    result.Append(message[i]);
                }
                else
                {
                    result.Append(delimiter);
                    result.Append(message[i]);
                }
            }

            Console.WriteLine(result);
        }
    }
}
