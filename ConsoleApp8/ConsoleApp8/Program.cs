using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Program
    {
        class Calculator
        {
            public int Plus(int a, int b)
            {
                return a + b;
            }
            public int Minus(int a, int b)
            {
                return a - b;
            }
            static void Main(string[] args)
            {
                Calculator calculator = new Calculator();

                int a = int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());
                
                Console.WriteLine(calculator.Plus(a, b));
                Console.WriteLine(calculator.Minus(a, b));
            }
        }
    }
}
