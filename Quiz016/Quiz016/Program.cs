using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Quiz016   //고양이 클래스의 Getter, Setter를 만들어보자
{
    internal class Program
    {
        class Cat
        {
            private string name;
            private string color;
            private int age;

            public void setName(string _name)   //set은void
            {
                name = _name;
            }

            public void setColor(string _color)
            {
                color = _color;
            }
            public void setAge(int _age)
            {
                age = _age;
            }
            public string getName()
            {
                return name;
            }
            public string getColor()
            {
                return color;
            }
            public int getAge()
            {
                return age;
            }
        }
        
        
            static void Main(string[] args)
            {
                Cat nero = new Cat();
                nero.setName("네로");
                nero.setColor("검은색");
                nero.setAge(10);

                Console.WriteLine($"이름 : {nero.getName()} 색깔 : {nero.getColor()} 나이 : {nero.getAge()}");
            }
        }
    }

