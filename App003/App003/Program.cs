﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App003
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 가로(width), 세로(height)를 입력받아 넓이를 구합시다.
            // 단, 입력은 정수로 계사될 범위까지 들어옵니다.
            int width, height;
            width = Int32.Parse(Console.ReadLine());
            height = Int32.Parse(Console.ReadLine());
            int result = width*height;

            Console.WriteLine(result);
        }
    }
}
