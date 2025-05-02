using System.Formats.Asn1;

namespace structRectangle
{
    internal class Program
    {
        struct Rectangle
        {
            public double length;
            public double width;
        }
        static void Main(string[] args)
        {
            Rectangle[] rectangles = new Rectangle[3];
            for (int i = 0; i < rectangles.Length; i++)
            {
                Console.WriteLine($"Rectangle {i + 1} details:");
                Console.WriteLine("Length: ");
                rectangles[i].length = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Width: ");
                rectangles[i].width = Convert.ToDouble(Console.ReadLine());
                double area = areacalc(rectangles[i].length, rectangles[i].width);
                Console.WriteLine("Area of rectangle {0} is {1}", i + 1, area);
                double perimeter = perimetercalc(rectangles[i].length, rectangles[i].width);
                Console.WriteLine("Perimeter of rectangle {0} is {1}", i + 1, perimeter);

            }
             double areacalc(double l,double w)
            {
                return l * w;
            }
            double perimetercalc(double l, double w)
            {
                double p = 2 * (l + w);
                return p;
            }
            Console.WriteLine("Hello, World!");
        }
    }
}
