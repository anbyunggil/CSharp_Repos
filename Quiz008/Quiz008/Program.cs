using System;

namespace Quiz008
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //for문으로 13의 배수를 100->1작아지는 순으로 작성
            int i = 0;
            for (i = 100; i >= 1; i--)
            {
                if (i % 13 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}