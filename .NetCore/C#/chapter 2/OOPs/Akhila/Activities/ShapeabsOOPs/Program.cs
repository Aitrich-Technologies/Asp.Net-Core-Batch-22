namespace ShapeabsOOPs
{
    abstract class Shapes
    {
        public string Name;
        public abstract double GetArea();
        
    }
    class Rectangle : Shapes 
    {
        public int le;
        public int br;
        public Rectangle(int x, int y)
        {
            le=x; br=y;
        }
        public override double GetArea()
        {
            return le*br;
        }
    }
    class Circle : Shapes
    {
        public int r;
        public Circle(int x)
        {
            r = x;
        }
        public override double GetArea()
        {
            return 3.14 * r * r;
        }
    }
   
    internal class Program
    {
        static void Main(string[] args)
        {
            //Rectangle rectangle = new Rectangle();
            //rectangle.GetArea(4, 5);
            //Circle circle=new Circle();
            //circle.GetArea(10);
            Shapes shapes[0] =new Rectangle(4,5);
            //Console.WriteLine("Area of Reactangle is {0}",shapes.GetArea());
            Shapes shapes[1] = new Circle(10);
            //Console.WriteLine("Area of Circle is {0}",shape.GetArea());
            for(int i=0;i<)

        }
    }
}
