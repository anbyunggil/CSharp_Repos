﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooApp001
{
    class Tiger
    {
        private string name;
        private int age;

        public Tiger(string _name)
        {
            name = _name;
        }
        //Getter, Setter
        public void setAge(int _age)
        {
            this.age = _age;
        }
        public int getAge()
        {
            return age;
        }
        public string getName()
        {
            return name;
        }
    }
    class Lion
    {

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Tiger timon = new Tiger("티몬");
            timon.setAge(5);

            Console.WriteLine($"티몬의 나이는 : {timon.getAge()}");
            Console.WriteLine($"티몬의 이름은 : {timon.getName()}");
        }
    }
}
