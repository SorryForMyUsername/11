using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Компьютерный_практикум__11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("x = ");
            int x = int.Parse(Console.ReadLine());
            double y = Function(x);
            Console.WriteLine($"y = {y}");

            Console.ReadKey();
        }

        public static double Function(int x)
        {
            return x < 5 
                ? (4 * Math.Pow(x, 2) + 1) / (x - 5)
                : 3 * Math.Pow(x, 2) - 2;
        }
    }
}
