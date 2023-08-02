using System;

namespace Quiz009   //별 그리기
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < i + 1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            {
                //2
                for (int i = 5; i > 0; i--)
                {
                    for (int j = i; j > 0; j--)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
            }
            Console.WriteLine();
            {

                ////3 내가짠거
                //for(int i = 5; i > 0; i--)
                //{
                //    for(int j=i-1; j>0; j--)
                //    {
                //        Console.Write(" ");
                //    }
                //    for (int k=i; k<i+1; k++)
                //    {
                //        Console.Write("*");
                //    }
                //    Console.WriteLine();
                //}

                //교수님이 짠거
                for (int i = 0; i < 5; i++)
                {
                    for (int j = 4 - i; j > 0; j--)
                    {
                        Console.Write(" ");
                    }
                    for (int k = 0; k <= i; k++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
            }
            Console.WriteLine();
            //4
            for (int i = 0; i < 5; i++)
            {
                for (int k = 0; k < i; k++)
                {
                    Console.Write(" ");
                    
                }
                for (int j = 4 - i; j >= 0; j--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            //5
            for(int i = 0; i <= 3; i++)
            {
                for(int j=5; j>5; j++)
                {
                    Console.WriteLine("*");
                }
            }
        }
    }
}
