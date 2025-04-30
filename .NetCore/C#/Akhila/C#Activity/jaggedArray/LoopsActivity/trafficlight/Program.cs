namespace trafficlight
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Color:");
            string light = Console.ReadLine();
            switch(light)
            {
                case "Red":
                    Console.WriteLine("Stop");
                    break;
                case "Yellow":
                    Console.WriteLine("Ready");
                    break ;
                case "Green":
                    Console.WriteLine("Go");
                    break;
                default:
                    Console.WriteLine("Wrong Input");
                    break;
            }
        }
    }
}
