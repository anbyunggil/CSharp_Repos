using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    public class Example

    {

        public static void Main()

        {
            Console.Write("단을 입력하세요 : ");
            int i = int.Parse(Console.ReadLine());

            switch (i)
            {
                case 3:
                    for (int j = 1; j <= 9; j++)
                    {

                        Console.WriteLine($"{i}*{j} = {i * j}");
                    }
                    break;
                case 4:
                    for (int j = 1; j <= 9; j++)
                    {

                        Console.WriteLine($"{i}*{j} = {i * j}");
                    }
                    break;
                case 5:
                    for (int j = 1; j <= 9; j++)
                    {

                        Console.WriteLine($"{i}*{j} = {i * j}");
                    }
                    break;
                case 6:
                    for (int j = 1; j <= 9; j++)
                    {

                        Console.WriteLine($"{i}*{j} = {i * j}");
                    }
                    break;

                default:
                    Console.WriteLine("오류");
                    break;
            }
        }
    }
}