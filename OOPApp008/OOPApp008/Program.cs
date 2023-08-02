using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPApp008
{
    class Shape
    {
        public virtual void Draw()
        {
            Console.WriteLine("도형을 그리다.");  //부모
        }
    }
    class Triangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("삼각형을 그리다.");    //바로 위의 부모가 된다.
        }
    }
    class Rectangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("사각형을 그리다.");
        }
    }
    class Circle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("원을 그리다.");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Shape s1 = new Shape();
            s1.Draw();
            Shape s2 = new Shape();
            s2.Draw();
            Shape s3 = new Shape();
            s3.Draw();
            Shape s4 = new Shape();
            s4.Draw();

            Shape[] shapes = new Shape[4];
            shapes[0] = new Shape();
            shapes[1] = new Triangle();
            shapes[2] = new Rectangle();
            shapes[3] = new Circle();

            for(inti=0; i < 4; i++)
        }
    }
}
