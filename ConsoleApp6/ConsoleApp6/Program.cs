using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //별1
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");

                }
                Console.WriteLine();
            }
            Console.WriteLine();

            //별2
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 6; j > i; j--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            //별3
            for (int i = 0; i <= 5; i++)
            {
                for (int j = 5; j > i; j--)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            //별4
            for (int i = 0; i <= 5; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 5; j > i; j--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            //별5
            for(int i = 0; i <= 2; i++)
            {
                for (int j = 1; j >= i; j--)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < 1+i*2 ; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();                
            }
            for(int i = 0; i <= 1; i++)
            {
                for(int j = 0; j < i+1; j++)
                {
                    Console.Write(" ");
                }
                for(int j = 2; j > i*2-1; j--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

        }
    }
}