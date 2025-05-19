namespace FruitInhrtnOOps
{
    class Fruits
    {
        public string color;
    }
    class Apple:Fruits
    {
        public void display(string c)
        {
            Console.WriteLine("Color of Apple:{0}",c);
        }
    }
    class Banana:Fruits
    {
        public void display(string c)
        {
            Console.WriteLine("Color of Banana:{0}", c);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Banana banana = new Banana();
            banana.color = "Yellow";
            banana.display(banana.color);
            Apple apple = new Apple();
            apple.color = "Red";
            apple.display(apple.color);
        }
    }
}
