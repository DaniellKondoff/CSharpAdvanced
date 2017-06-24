using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    class Demo
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            try
            {
                Console.WriteLine(int.Parse(text));
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("GoodBye");
            }
        }
    }
}
