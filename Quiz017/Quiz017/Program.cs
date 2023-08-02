using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz017   //계산기 (평균 구하기)
{
    class Calculator
    {
        public int executeTotalScore(int x, int y, int z)
        {
            return x + y + z;
        }
        public double excuteAvg(int x, int y, int z)
        {
            return (x + y + z) / (double)3;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("국어 : ");
            int kor = int.Parse(Console.ReadLine());
            Console.Write("영어 : ");
            int eng = int.Parse(Console.ReadLine());
            Console.Write("수학 : ");
            int math = int.Parse(Console.ReadLine());
            Calculator a = new Calculator();
            Console.WriteLine("총점 : " + a.executeTotalScore(kor, math, eng));
            Console.WriteLine("평균 : " + a.excuteAvg(kor, math, eng));
        }
    }
}