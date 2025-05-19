namespace inheritanceOOPs
{
    class Animal
    {
        public Animal()
        {
            Console.WriteLine("Parent class");
        }
    }
    class Dog : Animal
    {
        public Dog()
        {
            Console.WriteLine("Base class");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();

            Console.WriteLine("Hello, World!");
        }
    }
}
