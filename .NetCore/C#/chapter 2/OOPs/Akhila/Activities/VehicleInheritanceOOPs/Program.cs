namespace VehicleInheritanceOOPs
{
    class Vehicle
    {
        public string brand;
        public void showbrand(string brnd)
        {
            Console.WriteLine("Brand is {0}", brnd);
        }
    }
    class Car:Vehicle
    {
        public void Drive()
        {
            Console.WriteLine("Car Drive");
        }
    }
    class Bike:Vehicle
    {
        public void Ride()
        {
            Console.WriteLine("Bike Ride");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car=new Car();
            car.showbrand("TATA");
            car.Drive();
            //car.Ride();
            Bike bike = new Bike();
            bike.showbrand("Honda");
            //bike.Drive();
            bike.Ride();
            //Console.WriteLine("Hello, World!");
        }
    }
}
