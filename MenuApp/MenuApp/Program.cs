using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("메뉴 : ");
                int n = int.Parse(Console.ReadLine());

                switch (n)
                {
                    case 1:
                        Console.WriteLine("1을 입력하였습니다. ");
                        break;
                    case 2:
                        Console.WriteLine("2를 입력하였습니다. ");
                        break;
                    default:
                        Console.WriteLine("1, 2이외의 수를 입력하였습니다");
                        break;

                }
                if (n == 100)
                {
                    Console.WriteLine("100을 입력하셔서 종료합니다.");
                    break;
                }
            }
        }
    }
}