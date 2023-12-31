﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate03
{
    //10진수 or 16진수 출력
    class MyClass
    {
        private delegate void RunDelegate(int i);

        private void RunThis(int val)   //10진수 1024출력
        {
            Console.WriteLine(val);
        }
        private void RunThat(int val)   //16진수 1024출력
        {
            Console.WriteLine($"{val:X}");
        }
        public void Perform()
        {
            //1. Delegate객체 생성
            RunDelegate run = new RunDelegate(RunThis);
            //2. 10진수 출력
            run(1024);
            //3. 16진수 출력
            run = new RunDelegate(RunThat);     //run = RunThat; -> 가능
            run(1024);

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass mc = new MyClass();
            mc.Perform();
        }
    }
}
