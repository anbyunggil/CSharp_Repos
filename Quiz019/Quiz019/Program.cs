using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
    
namespace Quiz019   //문자열 뒤집기
{
    internal class Program
    {
        static void Main(string[] args)
        {
           string s = Console.ReadLine();

            string R = "";

            for(int i=s.Length-1; i>=0; i--)
            {
                R += s[i];
            }
            Console.WriteLine(R);
        }
    }
}
