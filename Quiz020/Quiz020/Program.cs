using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz020
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("문자열을 입력하세요 : ");
            string s =Console.ReadLine();

            int cnt = 0, cnt1 = 0, cnt2 = 0, cnt3 = 0;

            for(int i=0; i<s.Length; i++)
            {
                if (s[i] >= '0' && s[i] <= '9')
                    cnt++;
                else if (s[i] >= 'A' && s[i] <= 'Z')
                    cnt1++;
                else if (s[i] >= 'a' && s[i] <= 'z')
                    cnt2++;
                else
                    cnt3++;
            }
            Console.WriteLine("알파벳 대문자 : " +  cnt1);
            Console.WriteLine("알파벳 소문자 : " + cnt2);
            Console.WriteLine("숫자 : " + cnt);
            Console.WriteLine("특수문자 : " + cnt3);
        }
    }
}
