using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz011
{
    internal class Program
    {
        static int plus(int a, int b)
        {
            return a + b;
        }
        static int minus(int a, int b)
        {
            return a - b;
        }
        static int multiple(int a, int b)
        {
            return a * b;
        }
        static double divide(int a, int b)
        {
            return a / (double)b;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(plus(100, 100));
            Console.WriteLine(minus(100, 100));
            Console.WriteLine(multiple(100, 100));
            Console.WriteLine(divide(50, 30));


        }         
    }
}
