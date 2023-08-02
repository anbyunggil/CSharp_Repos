using System;

namespace OOPApp005
{
    class Calculator
    {
        /* 오버로딩이라 부른다. */
        //정수 두 개를 합산하는 Plus 메소드
        public int Plus(int a, int b)
        {
            return a + b;
        }
        //정수 네 개를 합산하는 Plus 메소드
        public int Plus(int a, int b, int c, int d)
        {
            return a + b + c + d;
        }
        //double 두개를 합산하는 Plus 메소드
        public double Plus(double a, double b)
        {
            return a + b;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            Console.WriteLine(calculator.Plus(1, 2));
            Console.WriteLine(calculator.Plus(2, 3));
            Console.WriteLine(calculator.Plus(3.5, 4.5));
        }
    }
}
