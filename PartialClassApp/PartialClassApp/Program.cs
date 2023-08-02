using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClassApp
{
    partial class A
    {
        public void Method1()
        {
            Console.WriteLine("Method 1");
        }
    }
    partial class A
    {
        public void Method2()
        {
            Console.WriteLine("Method 2");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            A a = new A();
            a.Method1();
            a.Method2();
        }
    }
}
