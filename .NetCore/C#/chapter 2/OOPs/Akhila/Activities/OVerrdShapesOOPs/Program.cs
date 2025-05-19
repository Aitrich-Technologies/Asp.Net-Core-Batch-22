using System.Runtime.CompilerServices;

namespace OVerrdShapesOOPs
{
    abstract class Shape
    {
        public abstract void GetArea();
    }
    class Circle : Shape
    {
        public override void GetArea()
        {
            Console.WriteLine("Enter Radius of circle:");
            int r=Convert.ToInt32(Console.ReadLine());
            double area = 3.14 * r * r;
            Console.WriteLine("Area of circle:{0}", area);
        }
    }
    class Rectangle:Shape
    {
        public override void GetArea()
        {
            Console.WriteLine("Enter Length of Rectangle:");
            int l= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Width of Rectangle:");
            int w= Convert.ToInt32(Console.ReadLine());
            int rectarea = l * w;
            Console.WriteLine("Area of circle:{0}", rectarea);
        }
    }
    class Square : Shape
    {
        public override void GetArea()
        {
            Console.WriteLine("Enter the side of a square:");
            int side = Convert.ToInt32(Console.ReadLine());
            int sqarea = side * side;
            Console.WriteLine("Area of Square:{0}", sqarea);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Shape> shapes = new List<Shape>();
            shapes.Add(new Circle());
            shapes.Add(new Rectangle());
            shapes.Add(new Square());

            foreach (Shape shape in shapes)
            {
                shape.GetArea();
            }
        }
    }
}
