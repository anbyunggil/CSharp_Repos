using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz007   //연도와 나이
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //태어난 연도를 입력하면 한국나이를 출력해주는 프로그램 작성

            int year = int.Parse(Console.ReadLine());
            year = 2023 - year;

            Console.WriteLine($"{year + 1}");
            Console.WriteLine($"만{year}세");
            }
        }
    }