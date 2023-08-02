using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodTest001
{
    internal class Program
    {
        //국어, 영어, 수학 성적의 평균을 구해주세요. ex)100, 100, 90
        double Avg(int k, int e, int m)
        {
            return (k + e + m) / 3.0;
        }
        
        static void Main(string[] args)
        {
            int[] score = new int[3];

            for(int i=0; i<3; i++)
            {
                score[i] = int.Parse(Console.ReadLine());
            }
            
            Program p = new Program();
            double result = p.Avg(score[0], score[1], score[2]);
            
            Console.WriteLine(result);
            
        }
    }
}
