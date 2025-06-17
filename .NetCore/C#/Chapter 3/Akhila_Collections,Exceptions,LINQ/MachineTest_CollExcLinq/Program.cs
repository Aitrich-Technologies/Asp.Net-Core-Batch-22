using MachineTest_CollExcLinq.Manager;

namespace MachineTest_CollExcLinq
{
    public class Program
    {
        static void Main(string[] args)
        {
            int exitpgm = 0;
            do
            {
                Console.WriteLine("Select your option:\n1.Bank\n2.Customer\n3.Exit");
                string opt=Console.ReadLine();
                switch(opt)
                {
                    case "1":
                        BankManager bank = new BankManager();
                        string user = "bank";
                        string pwd = "123";
                        bank.Login(user,pwd);
                        break;
                    case "2":
                        CustomerManager customer = new CustomerManager();
                        customer.cust_menu();
                        break;
                    case "3":
                        Console.WriteLine("Exit the system");
                        exitpgm = 1;
                        break;
                    default:
                        Console.WriteLine("Invalid Option.Try again!");
                        break;
                }

            } while (exitpgm == 0);
        }
    }
}
