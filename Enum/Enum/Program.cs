using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum
{
    internal class Program
    {
        enum DigitalResult { YES, NO, CANEL, CONFIRM, OK }  //클래스 멤버 변수로 넣은 것   {0 1 2 3 4}
        static void Main(string[] args)
        {
            Console.WriteLine(DigitalResult.YES);
            Console.WriteLine((int)DigitalResult.YES);  

            Console.WriteLine(DigitalResult.OK);
            Console.WriteLine((int)DigitalResult.OK);
        }
    }
}
