using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _3.CubicMessages
{
    class Messages
    {
        static void Main(string[] args)
        {
            string pattern = @"^(\d+)([A-Za-z]+)([^A-Za-z]*)$";
            Regex regex = new Regex(pattern);

            string inputMessage;
            while ((inputMessage = Console.ReadLine()) != "Over!")
            {
                var messageLenght = int.Parse(Console.ReadLine());
                var match = regex.Match(inputMessage);

                if (match.Success)
                {
                    var prefix = match.Groups[1].Value;
                    var message = match.Groups[2].Value;
                    var ending = string.Empty;
                    if (match.Groups[3].Value != "")
                    {
                        ending = match.Groups[3].Value;
                    }

                    if (message.Length != messageLenght)
                    {
                        continue;
                    }

                    var indexes = Regex.Replace(prefix + ending, @"\D*", String.Empty);
                    var sb = new StringBuilder();
                    foreach (var index in indexes)
                    {
                        var ind = int.Parse(index.ToString());
                        if (ind >=0 && ind < messageLenght)
                        {
                            sb.Append(message[ind]);
                        }
                        else
                        {
                            sb.Append(" ");
                        }
                    }

                    Console.WriteLine($"{message} == {sb.ToString()}");
                }
            }
        }
    }
}
