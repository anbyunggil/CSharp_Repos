using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericApp04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int>list = new List<int>();
            for(int i = 0; i <5; i++)
                list.Add(i);

            list.RemoveAt(2);   //0, 1, 2 ->3번째 값 제거

            foreach (int element in list)
                Console.Write(element);
            Console.WriteLine();

            list.Insert(3, 2);  //3번째 자리에 내가 넣고 싶은 값 입력
            foreach (int element in list)
                Console.Write(element);
            Console.WriteLine();
        }
    }
}
