using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodTest002
{
    class MyApp
    {
        public int Max(int a, int b)
        {
            if (a > b)
                return a;
            else
                return b;
        }
        public int Min(int a, int b)
        {
            if (a > b)
                return b;
            else
                return a;
        }
    }
    //두 수를 입력받아 큰 수를 입력
    internal class Program
    {
        static void Main(string[] args)
        {
            MyApp app = new MyApp();
            Console.WriteLine(app.Max(100, 200));
            Console.WriteLine(app.Min(100, 200));
        }
    }
}
