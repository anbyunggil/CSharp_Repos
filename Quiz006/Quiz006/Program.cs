using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz006   //수식문제 - 점수
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            if (num > 89)
            {
                Console.WriteLine("A");
            }
            else if(num > 79)
            {
                Console.WriteLine("B");
            }
            else if (num > 69)
            {
                Console.WriteLine("C");
            }
            else if (num > 59)
            {
                Console.WriteLine("D");
            }
            else
                Console.WriteLine("F");
        }
    }
}
