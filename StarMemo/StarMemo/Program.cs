using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarMemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for(int i = 0; i <5; i++)
            {
                for(int j= 0; j < i+1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            //2문제
            for (int i = 0; i < 5; i++)
            {
                for (int j = 6; j > i + 1; j--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            //3문제
            for (int i = 1; i < 6; i++)
            {
                for (int j = 5; j > i; j--)
                {
                    Console.Write(" ");
                }
                for (int k = 0; k < i; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            //4문제
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 5; k > i; k--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            //5문제
            for (int i = 0; i < 3; i++)
            {
                for (int j = 2; j > i; j--)
                {
                    Console.Write("_");
                }
                int num = i + 3;

                for (int k = 0; k < num-2; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
