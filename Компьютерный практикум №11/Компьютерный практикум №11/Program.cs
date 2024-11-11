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
            SayHello();
            SayBay();

            Console.ReadKey();
        }

        public static void SayHello()
        {
            Console.WriteLine("Привет!");
        }

        public static void SayBay()
        {
            Console.WriteLine("Пока!");
        }
    }
}
