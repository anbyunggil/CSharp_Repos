using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPApp003
{
    class Cat
    {
        //이름
        public string Name;
        //색깔
        public string Color;
        //나이
        public int Age;

        //생성자
        public Cat()    //default생성자
        {
            //초기값
            //this.Name = "야옹이";
            //this.Age = 2;
            //this.Color = "누런색";
        }
        public void Meow()
        {
            Console.WriteLine("야옹");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //객체 생성
            Cat kitty = new Cat();
            //생성 후 초기화
            kitty.Name = "키티";
            kitty.Age = 10;
            kitty.Color = "갈색";
            //출력
            Console.WriteLine($"키티의 이름은 {kitty.Name}, 키티의 나이는 {kitty.Age}, 키티의 색깔은 {kitty.Color}");
        }
    }
}
