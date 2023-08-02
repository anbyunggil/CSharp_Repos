using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharApp
{
    class Program
    {
        static void Main(string[] args)
        {
            char a = '안';
            char b = '녕';
            string str = "안녕";  // char과string은 차이가 있다.

            Console.WriteLine($"{a}{b}");
            Console.WriteLine(str);



            string multi01 = "안녕\n하세요";
            Console.Write(multi01);
        }
    }
}
