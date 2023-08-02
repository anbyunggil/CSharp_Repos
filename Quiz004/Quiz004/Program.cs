using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz004 //변수교환
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c;
            c = b;
            b = a;
            a = c;
            Console.WriteLine($"{a} {b}");

        }
    }
}
