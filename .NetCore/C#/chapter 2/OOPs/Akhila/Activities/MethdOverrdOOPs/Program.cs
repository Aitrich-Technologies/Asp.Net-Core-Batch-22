namespace MethdOverrdOOPs
{
    class Animal
    {
        public virtual void MakeSound()
        {
            Console.WriteLine("Animals can make sound");

        }
    }
    class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Woof ");

        }
    }
    class Cat:Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Meow ");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>();
            animals.Add(new Dog());
            animals.Add(new Cat());

            foreach (Animal animal in animals)
            {
                animal.MakeSound();
            }

        }
    }
}
