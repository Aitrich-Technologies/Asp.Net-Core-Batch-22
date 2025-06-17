using Workshop4_CollExcpLinq.Interfaces;
using Workshop4_CollExcpLinq.Manager;

namespace Workshop4_CollExcpLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            IMenu menu = new PublicManager();
            menu.DisplayMenu();
        }
    }
}
