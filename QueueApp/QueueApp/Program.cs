using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Queue : 앞이 열려있고 뒤로 뚫려있는 구조 123 -> 123
            Queue<string> que = new Queue<string>();
            que.Enqueue("Hello");
            que.Enqueue("Halo");
            que.Enqueue("Hi");

            while(que.Count > 0)
                Console.WriteLine(que.Dequeue());

            Stack<char> stack = new Stack<char>();
            stack.Push('H');
            stack.Push('e');
            stack.Push('l');
            stack.Push('l');
            stack.Push('O');
            Console.WriteLine();
            while (stack.Count > 0)
                Console.Write(stack.Pop());
            Console.WriteLine();

        }
    }
}
