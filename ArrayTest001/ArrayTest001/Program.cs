﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayTest001
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1~10까지 들어있는 정수형 배열 arr을 선언
            int[] arr = new int[10];

            //입력
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = i + 1; //배열은 선형적 메모리
                Console.WriteLine(arr[i]);  //출력을 없애고 입력에서 출력하기
            }
            ////출력
            //for(int i = 0; i < arr.Length;i++)
            //{
            //    Console.WriteLine(arr[i]);
            //}
        }
    }
}
