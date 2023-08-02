using System;

namespace LoopAppTest003
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            n = int.Parse(Console.ReadLine());
            do
            {
                switch (n)
                {
                    case 1:
                        Console.WriteLine("1입력");
                        break;
                    case 2:
                        Console.WriteLine("2입력");
                        break;
                    default:
                        Console.WriteLine("잘못입력");
                        break;
                }
                if (n == 100)
                {
                    Console.WriteLine("100입력 종료");
                    break;
                }
            } while (true);
        }
}
}
