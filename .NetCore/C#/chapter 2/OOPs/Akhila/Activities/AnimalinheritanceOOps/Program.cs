namespace AnimalinheritanceOOps
{
    class Animal
    {
        string breed;
        public void SetBreed(string brd)
        {
            Console.WriteLine("{0} breed",brd);

        }
    }
    class Dog : Animal
    {
       
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();

            Console.WriteLine("Enter the breed name:");
            string b=Console.ReadLine();
            dog.SetBreed(b);
        }
    }
}
