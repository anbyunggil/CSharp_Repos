using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopAppTest002
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 0;

            
            while (i < 5)
            {
                Console.WriteLine(i++); //++i = 1,2,3,4,5   i++ = 0,1,2,3,4
                Console.WriteLine("i : " + i);  //1줄 아래는 무조건 +1
            }
        }
    }
}
