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
            Console.Write("y = ");
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine(
                $"x + y: {Sum(x, y)}\n" +
                $"x - y: {Difference(x, y)}\ty - x: {Difference(y, x)}\n" +
                $"x * y: {Multiply(x, y)}\n" +
                $"x / y: {Division(x, y)}\ty / x: {Division(y, x)}");

            Console.ReadKey();
        }

        public static int Sum(int x, int y)
        {
            return x + y;
        }

        public static int Difference(int x, int y)
        {
            return x - y;
        }

        public static int Multiply(int x, int y)
        {
            return x * y;
        }

        public static int Division(int x, int y)
        {
            return x / y;
        }
    }
}
