
namespace ShapesInhOOPs
{
    class Shapes
    {
        public int sides;
    }
    class Triangle : Shapes 
    {
     public void display(int n)
        {
            Console.WriteLine("Number of sides of Triangle:{0}", n);
        }

    }
    class Square: Shapes
    {
        public void display(int n)
        {
            Console.WriteLine("Number of sides of Square:{0}", n);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Triangle triangle = new Triangle();
            triangle.sides = 3;
            triangle.display(triangle.sides);
            Square square = new Square();
            square.sides = 4;
            square.display(square.sides);
        }
    }
}
