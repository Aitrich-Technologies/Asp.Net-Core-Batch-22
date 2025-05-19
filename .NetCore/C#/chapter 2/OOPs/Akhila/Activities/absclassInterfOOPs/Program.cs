using System.Reflection.PortableExecutable;
using absclassInterfOOPs;

namespace absclassInterfOOPs
{
    interface IDriveable
    {
        public void Drive();
    }
    abstract class Machine
    {
        public abstract void Start();
    }
class Car:Machine, IDriveable
{
        public override void Start()
        {
            Console.WriteLine("Abstract class Machine Started");
        }
        public void Drive()
        {
            Console.WriteLine("Interface IDriveable is Driving");
        }
}

    internal class Program
    {
        static void Main(string[] args)
        {
            Car car=new Car();
            car.Start();
            car.Drive();
        }
    }
}
