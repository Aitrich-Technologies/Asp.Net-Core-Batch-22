namespace enumcastingint
{
    internal class Program
    {
        enum Color { Red = 10, Green = 20, Blue = 30 };
        static void Main(string[] args)
        {
            
            Color c = Color.Blue;
            int value = Convert.ToInt32(c);
            Console.WriteLine(value);
           
        }
    }
}
