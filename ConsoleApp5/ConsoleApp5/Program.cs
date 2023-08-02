using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            for(int i = 1; i<=100;  i++)
            {
                num += i;
            }
            Console.WriteLine(num);
        }
    }
}
