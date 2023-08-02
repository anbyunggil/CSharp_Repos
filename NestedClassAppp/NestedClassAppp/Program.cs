using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestedClassAppp
{
    class OuterClass
    {
        private int OuterNumber;
        class InnerClass
        {
            public void DoSomething()
            {
                OuterClass outer = new OuterClass();
                outer.OuterNumber = 100;
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
