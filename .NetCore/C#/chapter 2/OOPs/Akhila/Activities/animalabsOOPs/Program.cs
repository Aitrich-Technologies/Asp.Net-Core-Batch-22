namespace animalabsOOPs
{
    abstract class Animal
    {
        public abstract void speak();
        public abstract void move();
    }
    class Dog : Animal
    {
        public override void move()
        {
            Console.WriteLine("Dog can move");
        }
        public override void speak()
        {
            Console.WriteLine("Dog can speak");
        }
    }
    class Bird:Animal
    {
        public override void move()
        {
            Console.WriteLine("Dog can move");
        }
        public override void speak()
        {
            Console.WriteLine("Bird can speak");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            dog.move();
            Animal bird = new Bird();
            bird.speak();
        }
    }
}