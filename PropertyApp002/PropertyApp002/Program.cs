using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyApp002
{

    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < i; i++)
                {
                    Console.Write("ㅋ");
                    Console.WriteLine();
                }
            }
        }
    }
}
