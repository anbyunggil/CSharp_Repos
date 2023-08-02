using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuguDan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = int.Parse(Console.ReadLine());
            if (sum >= 90)
             Console.WriteLine('A');
                else if (sum >= 80)
                Console.WriteLine('b');

            else if (sum >= 70)
                Console.WriteLine('c');

            else if (sum >= 60)
                Console.WriteLine('d');

            else 
                Console.WriteLine('f');
        } 
        }
    }
