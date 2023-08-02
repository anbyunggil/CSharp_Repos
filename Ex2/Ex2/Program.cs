using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2
{
    delegate int MyDelegate(int a, int b);
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
        }
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();

            MyDelegate Callback;

            Callback = new MyDelegate(calculator.Plus);

            Console.WriteLine(Callback(3, 4));

            Callback = new MyDelegate(calculator.Minus);

            Console.WriteLine(Callback(7, 5));
        }
    }
}
