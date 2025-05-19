namespace RectangleOOPs
{
    class Rectangle
    {
        public int Length;
        public int Width;
        public Rectangle(int l,int w)
        {
            Length = l;
            Width = w;
        }
        public void getArea()
        {
            int area = Length * Width;
            Console.WriteLine("Area of rectangle is {0}",area);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect1 = new Rectangle(4, 5);
            rect1.getArea();
            Rectangle rect2= new Rectangle(5, 5);
            rect2.getArea();
            Rectangle rect3 = new Rectangle(5, 6);
            rect3.getArea();
        }
    }
}
