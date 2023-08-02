using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("단을 입력하세요. : ");
            int num = int.Parse(Console.ReadLine());

            switch (num)
            {
                case 3:
                    for(int i = 1; i<=9; i++)
                    {
                        int j = num * i;
                        Console.WriteLine($"{num} * {i} = {j}");
                    }
                    break;
                case 4:
                    for (int i = 1; i <= 9; i++)
                    {
                        int j = num * i;
                        Console.WriteLine($"{num} * {i} = {j}");
                    }
                    break;
                case 5:
                    for (int i = 1; i <= 9; i++)
                    {
                        int j = num * i;
                        Console.WriteLine($"{num} * {i} = {j}");
                    }
                    break;
                case 6:
                    for (int i = 1; i <= 9; i++)
                    {
                        int j = num * i;
                        Console.WriteLine($"{num} * {i} = {j}");
                    }
                    break;
            }
        }
    }
}
