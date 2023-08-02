﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Study01
{
    class Point
    {
        public int x;
        public int y;
        //생성자의 역할은 객체의 초기화
        public Point()
        {
            x = 1;
            y = 1;
        }
        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }
    internal class Program
    {
       
        static void Main(string[] args)
        {
            Point pt1 = new Point();
            Console.WriteLine($"({pt1.x},{pt1.y})");

            Point pt2 = new Point(2, 2);        //정수형변수 ?
            Console.WriteLine($"({pt2.x},{pt2.y})");
        }
    }
}
