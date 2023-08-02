using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyHelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //삼각형의 넓이를 구해주세요
            //공식 = 가로*세로 /2.0
            //Console.ReadLine()--> 문자열로 읽어짐
            //1.변수
            //2.로직
            //3.출력

            int width = 0;
            int height = 0;
            
            width = int.Parse(Console.ReadLine());
            height = int.Parse(Console.ReadLine());

            int result = width * height /2;

            Console.WriteLine(result);
        }
    }
}