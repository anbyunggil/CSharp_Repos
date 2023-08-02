using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{

    internal class Program
    {
        static void Main(string[] args)
        {
           for(int i = 0; i < args.Length; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine("짝수");
                }
                i = int.Parse(Console.ReadLine());
            }
        }
    }
}