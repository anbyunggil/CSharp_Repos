using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringApp002
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ABC".ToLower()); //소문자로 변환
            Console.WriteLine("abc".ToUpper()); //대문자로 변환

            Console.WriteLine("Happy Friday!".Insert(5, " Sunny")); //5번째에 Sunny 삽입
            Console.WriteLine("I Don't Love You".Remove(2, 6)); //2~6번째까지 삭제
            
            Console.WriteLine(" ABC ".Trim());  //공백 제거
        }
    }
}
