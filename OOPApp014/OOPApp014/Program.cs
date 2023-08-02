using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPApp014
{
    abstract class Shape
    {
        public abstract void Draw();
        
    }
    class Triangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("삼각형");
        }
    }
    class Rectangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("사각형");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Triangle t = new Triangle();
            Rectangle r = new Rectangle();

            t.Draw();
            r.Draw();
        }
    }
}
