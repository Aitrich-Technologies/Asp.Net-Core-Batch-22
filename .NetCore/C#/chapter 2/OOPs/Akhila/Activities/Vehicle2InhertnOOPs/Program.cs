namespace Vehicle2InhertnOOPs
{
    class Vehicle
    {
        string brand;
        public void Setbrand(string b)
        {
            Console.WriteLine("Brand name is:{0}", b);
        }
    }
    class Car : Vehicle
        {

        }
    
    internal class Program
    {
        static void Main(string[] args)
        {
                Car car= new Car();
                Console.WriteLine("Enter the brand of the car:");
                string brd=Console.ReadLine();
                car.Setbrand(brd);
            //Console.WriteLine("Hello, World!");
        }
    }
}
