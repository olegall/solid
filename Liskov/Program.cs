using System;
using System.Collections.Generic;
using System.Linq;
using static Liskov.Metanit;
using static Liskov.Stackoverflow; // что это, как это?

namespace Liskov
{
    interface INerd
    {
        public int Smartness { get; set; }
    }

    static class Program
    {
        //public static string RecallSomeDigitsOfPi<T>(this IList<T> nerdSmartnesses) where T : int
        //{
        //    var smartest = nerdSmartnesses.Max();
        //    return Math.PI.ToString("F" + Math.Min(14, smartest));
        //}

        //public static string RecallSomeDigitsOfPi<T>(this IList<T> nerds) where T : INerd
        //{
        //    var smartest = nerds.OrderByDescending(n => n.Smartness).First();
        //    return Math.PI.ToString("F" + Math.Min(14, smartest.Smartness));
        //}

        static void Main(string[] args)
        {
            IList<int> list = new List<int> { 2, 3, 4 };
            //var digits = list.RecallSomeDigitsOfPi();
            //Console.WriteLine("Digits: " + digits);

            //new Circle(2); // prints "The radius is 2"
            //new Liskov.Stackoverflow.Square(2); // prints "The radius is -1"

            //Rectangle rect = new Liskov.Metanit.Square();
            //TestRectangleArea(rect);

            Account acc1 = new Account(); // ok
            InitializeAccount(acc1);

            Account acc2 = new MicroAccount(); // нарушение Лисков
            //InitializeAccount(acc2);
            CalculateInterest(acc2); // получаем 1100 без бонуса 100
        }
    }
}
