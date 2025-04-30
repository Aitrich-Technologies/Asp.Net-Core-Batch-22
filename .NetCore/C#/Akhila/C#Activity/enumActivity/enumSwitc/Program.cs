namespace enumSwitc
{
    internal class Program
    {
        enum Severity 
        { 
            Low, Medium, High 
        };
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Low,Medium or High: ");
            string input=Console.ReadLine();
            Severity sevrty = (Severity)Enum.Parse(typeof(Severity),input);
            switch (sevrty)
            {
                case (Severity.Low):
                    Console.WriteLine("Take it easy");
                    break;
                case (Severity.Medium):
                    Console.WriteLine("Be careful");
                    break;
                case (Severity.High):
                    Console.WriteLine("Emergency");
                    break;
            }
        }
    }
}
