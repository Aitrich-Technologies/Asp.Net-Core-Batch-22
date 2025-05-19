using System.Drawing;

namespace encapsShape
{
    abstract class Shapes
    {
        public abstract void CalculateArea();
    }
    class Circle : Shapes 
    {
        int radius;
        public int rad
        {
            get { return radius; }
            set { radius = value; }
        }
        public override void CalculateArea()
        {
            double carea = 3.14 * radius * radius;
            Console.WriteLine("Area of Circle is {0}", carea);
        }
    }
    class Square : Shapes 
    {
        int side;
        public int sid
        {
            get { return side; }
            set { side = value; }
        }
        public override void CalculateArea()
        {
            double sarea=side * side;
            Console.WriteLine("Area of Square is {0}",sarea);
        }
    }
    class Rectangle:Shapes
    {
        int width;
        int length;
        public int wid
        {
            get { return width; }
            set {  width = value; }
        }
        public int len
        {
            get{ return length; }
            set{ length = value; }
        }
        public override void CalculateArea()
        {
            double rarea = length * width;
            Console.WriteLine("Area of Rectangle is {0}", rarea);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Circle circle=new Circle();
            circle.rad = 10;
            circle.CalculateArea();

            Square square = new Square();
            square.sid = 5;
            square.CalculateArea();

            Rectangle rect = new Rectangle();
            rect.wid = 5;
            rect.len = 4;
            rect.CalculateArea();

        }
    }
}
