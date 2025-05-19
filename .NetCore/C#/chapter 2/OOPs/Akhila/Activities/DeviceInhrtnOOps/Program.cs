namespace DeviceInhrtnOOps
{
    class Device
    {
        public string brand;
        public void display()
        {
            Console.WriteLine("The  brand is {0}",brand);
        }
    }
    class Mobile : Device
    {
       
        public void display()
        {
            base.display();
            Console.WriteLine("The mobile brand is {0}",brand);
        }
    }
    class Laptop : Device
    {
        //public void display(string b)
        //{
        //    Console.WriteLine("The Laptop brand is {0}", b);
        //}
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Mobile mobile = new Mobile();

            Console.WriteLine("Enter Brand of Mobile:");
            mobile.brand = Console.ReadLine();
            mobile.display();
            //Laptop laptop = new Laptop();
            //Console.WriteLine("Enter Brand of Laptop:");
            //laptop.brand = Console.ReadLine();
            //laptop.display(laptop.brand);
        }
    }
}
