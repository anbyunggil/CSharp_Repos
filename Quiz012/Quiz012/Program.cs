﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz012   //4개 수 합 출력
{
    internal class Program
    {
        static int hap(int a, int b, int c, int d)
        {
            return a+ b + c + d;
        }
        static void Main(string[] args)
        {
            Console.Clear();
            string[] input = Console.ReadLine().Split(' ');

            int a = int.Parse(input[0]);
            int b = int.Parse(input[1]);
            int c = int.Parse(input[2]);
            int d = int.Parse(input[3]);

            Console.WriteLine(hap(a, b, c, d));
        }
    }
}
