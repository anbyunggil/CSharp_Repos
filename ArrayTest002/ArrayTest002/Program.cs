using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ArrayTest002
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1~10까지 정수가 담겨있는 배열 arr
            //홀수만 출력
            //1,3,5,7,9 --> 출력이!!
            int[] arr = new int[10];

            for(int i = 0; i < arr.Length; i++)
            {
                arr[i] = i+1;
                if (arr[i]%2 != 0)
                {
                    Console.WriteLine(arr[i]);
                }
            }
        }
    }
}
