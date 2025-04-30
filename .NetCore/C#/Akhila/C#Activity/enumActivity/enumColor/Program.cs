namespace enumColor
{
    internal class Program
    {
        enum Color { Red = 10, Green = 20, Blue = 30 };
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the value:10,20,30  ");
            int value=Convert.ToInt32(Console.ReadLine());
            switch(value)
            {
                case (int)Color.Red: 
                    Console.WriteLine("red"); 
                    break;
                case (int)Color.Green:
                    Console.WriteLine("Green");
                    break;
                case (int)Color.Blue:
                    Console.WriteLine("Blue");
                    break;

            }
           // Console.WriteLine("Hello, World!");
        }
    }
}
