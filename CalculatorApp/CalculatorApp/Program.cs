﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApp
{
    class Calculator
    {
        //멤버변수
        //생성자
        //멤버메소드
        public int Plus(int a, int b)
        {
            return a + b;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            int result = calculator.Plus(1, 2);
            Console.WriteLine(result);
        }
    }
}