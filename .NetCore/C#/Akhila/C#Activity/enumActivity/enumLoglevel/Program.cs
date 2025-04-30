using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Diagnostics;

namespace enumLoglevel
{
    internal class Program
    {
        enum LogLevel
        {
            Debug = 1,
            Info = 2,
            Warning = 4,
            Error = 8
        };
        static void Main(string[] args)
        { 


            Console.WriteLine("enum Loglevel created");
        }
    }
}