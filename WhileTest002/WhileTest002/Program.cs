using System;

namespace WhileTest002
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            //for(초기값; 조건; 증가감;)
            int i = 0;
            while (i < 100)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
                i++;
            }
        }
    }
}

