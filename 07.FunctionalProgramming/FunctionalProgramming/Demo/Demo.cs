using Demo;
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
            //Action
            Action<int> myAction = Print;
            myAction(1);

            //Func
            Func<int, int> func = a => a + 1;
            Func<int, int> calcFunc = Calc;
            int result = calcFunc(100);

            //Console.WriteLine(result);
            Func<int> myFunc = () => 1;

            Console.WriteLine(TestForCondition(10, n=> n> 100));
            Console.WriteLine(TestForCondition(5, n=> n % 2== 1));

            Execute(10, n => Console.WriteLine(n));

            string text = "---text----";
            var textWithOutDashes = text.TrimDashes();
            Console.WriteLine(textWithOutDashes);

            var set = new HashSet<int>();
            set.Add(1);
            set.Add(2);
            set.Add(3);

            set.ForEach(n => Console.WriteLine(n));
            set.ForEach(n => Console.WriteLine(n+5));

            var list = new List<int>
            {
                1,2,3,4,5,6
            };
            var evenNum = list.Where(n => n % 2 == 0);
            evenNum.ForEach(n => Console.WriteLine(n));

            var filterResult = Filterr(list, n => n % 2 == 0 && n>3);
            filterResult.ForEach(n => Console.WriteLine(n));
            var resultList = list.Filter(n => n % 2 == 0 && n > 3);
        }

        public static List<int> Filterr(List<int>numbers, Func<int,bool> filter)
        {
            var result = new List<int>();
            foreach (var number in numbers)
            {
                if (filter(number))
                {
                    result.Add(number);
                }
            }
            return result;
        }
        public static void Execute(int number,Action<int> SomeAction)
        {
            SomeAction(number);
        }
        public static bool TestForCondition(int a,Func<int,bool> condition)
        {
            if (condition(a))
            {
                return true;
            }
            return false;
        }
        public static void Print(int a)
        {
            Console.WriteLine(a);
        }
        public static int Calc(int a)
        {
            return a + 1;
        }
    }
}
