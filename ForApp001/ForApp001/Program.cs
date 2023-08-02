using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForApp001
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1~100까지 합을 출력
            int sum = 0;
            for(int i=1; i<101; i++)
                sum += i;    //sum을 더한다. i값+1씩 100까지
            {
                Console.WriteLine(sum);
            }
        }
    }
}