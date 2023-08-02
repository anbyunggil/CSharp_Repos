using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateApp01
{
    internal class Program
    {
        delegate int MyDelegate(int a, int b);
        class Calculator { 
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
            Calculator calc = new Calculator();
            MyDelegate Callback;

            Callback = new MyDelegate(calc.Plus);   //CallBack이 더하기 기능이 되었다.
            Console.WriteLine(Callback(5, 10));

            Callback = new MyDelegate(calc.Minus);
            Console.WriteLine(Callback(5, 10));
        }
    }
}
