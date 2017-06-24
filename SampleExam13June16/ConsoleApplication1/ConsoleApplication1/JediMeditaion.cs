using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class JediMeditaion
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Queue<string> mastersQueue = new Queue<string>();
            Queue<string> knightsQueue = new Queue<string>();
            Queue<string> padawansQueue = new Queue<string>();
            Queue<string> specialQueue = new Queue<string>();

            bool isYoudaExist = false;

            for (int i = 0; i < n; i++)
            {
                string inputLine = Console.ReadLine();
                string[] jaday = inputLine.Split();

                for (int j = 0; j < jaday.Length; j++)
                {
                    char cuurrentJaday = jaday[j][0];
                    switch (cuurrentJaday)
                    {
                        case 'm':
                            mastersQueue.Enqueue(jaday[j]);
                            break;
                        case 'k':
                            knightsQueue.Enqueue(jaday[j]);
                            break;
                        case 'p':
                            padawansQueue.Enqueue(jaday[j]);
                            break;
                        case 't':
                        case 's':
                            specialQueue.Enqueue(jaday[j]);
                            break;
                        case 'y':
                            isYoudaExist = true;
                            break;
                    }
                }

            }
            StringBuilder output = new StringBuilder();

            if (isYoudaExist)
            {
                output.Append(string.Join(" ", mastersQueue) + " ");
                output.Append(string.Join(" ", knightsQueue) + " ");
                output.Append(string.Join(" ", specialQueue) + " ");
                output.Append(string.Join(" ", padawansQueue));               
            }
            else
            {
                output.Append(string.Join(" ", specialQueue) + " ");
                output.Append(string.Join(" ", mastersQueue) + " ");
                output.Append(string.Join(" ", knightsQueue) + " ");
                output.Append(string.Join(" ", padawansQueue));             
            }
            Console.WriteLine(output.ToString().Trim());
        }
    }
}
