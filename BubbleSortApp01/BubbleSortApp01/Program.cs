﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSortApp01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] list = { 2, 3, 5, 7, 9, 8, 6, 4, 1 };
            Array.Sort(list);

            /*int temp;
            for(int i = 9-1; i>0; i--)
            {
                for(int j=0; j<i; j++)
                {
                    if (list[j] < list[j + 1])
                    {
                        //교환조건 이루어짐
                        temp = list[j];
                        list[j] = list[j + 1];
                        list[j + 1] = temp;
                    }
                }
            }*/
            foreach (int i in list)     //Console.WriteLine();
            {
                Console.WriteLine(i);
            }
        }
    }
}