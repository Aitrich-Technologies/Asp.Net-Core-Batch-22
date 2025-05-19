namespace IntrfcPrinterOOPs
{
    interface IPrinter
    {
         void Start();
    }
    interface IScanner
    {
         void Start();
    }
    class AllInOnePrinter:IPrinter,IScanner
    {
         void IPrinter.Start()
        {
            Console.WriteLine("Printer started");
        }
        void IScanner.Start()
        {
            Console.WriteLine("Scanner started");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            AllInOnePrinter allInOnePrinter = new AllInOnePrinter();
            IPrinter iprinter = allInOnePrinter;
            IScanner iscanner = allInOnePrinter;
            iprinter.Start();
            iscanner.Start();

        }
    }
}
