using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfElse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 50;

            if (num > 100)
            {
                Console.WriteLine("100보다 큽니다.");
            }
            else if (num > 50)
            {
                Console.WriteLine("50보다 큽니다.");
            }
            else { Console.WriteLine("50보다 같거나 작습니다.");
            }
            //관계연산자 &&  ||
        }
    }
}
