using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPApp008
{
    class HyunDai
    {
        public virtual void Car()
        {
            Console.WriteLine("자동차");
        }
    }
    class avante : HyunDai
    {
        public override void Car()
        {
            Console.WriteLine("아반떼");
        }
    }
    class sonata : HyunDai
    {
        public override void Car()
        {
            Console.WriteLine("소나타");
        }
    }
    class grandeur : HyunDai
    {
        public override void Car()
        {
            Console.WriteLine("그랜져");
        }
    }

    internal class Program
    {
        static void Main(string[] args) 
        {
            HyunDai[] hyunDai = new HyunDai[4];
            hyunDai[0] = new HyunDai();
            hyunDai[1] = new avante();
            hyunDai[2] = new sonata();
            hyunDai[3] = new grandeur();

            for(int i = 0; i < 4; i++)
            {
                hyunDai[i].Car();
            }
        }
    }
}