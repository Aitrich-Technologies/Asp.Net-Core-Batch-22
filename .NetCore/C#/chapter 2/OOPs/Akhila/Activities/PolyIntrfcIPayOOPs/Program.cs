using System.Security.Cryptography.X509Certificates;

namespace PolyIntrfcIPayOOPs
{
    interface IPayment
    {
         void Pay();
    }
    class CreditCard:IPayment
    {
        public void Pay()
        {
            Console.WriteLine("Credit card payment");
        }
    }
    class PayPal : IPayment
    {
        public void Pay()
        {
            Console.WriteLine("PayPal payment done");
        }
    }
    class Cash:IPayment
    {
        public void Pay()
        {
            Console.WriteLine("Cash payment done");
        }
    }
    internal class Program
    {
        static void ProcessPayment(IPayment paymentMethod)
        {
            paymentMethod.Pay();
        }
        static void Main(string[] args)
        {

            ProcessPayment(new CreditCard());
            ProcessPayment(new PayPal());
            ProcessPayment(new Cash());
                          
        }
    }
}
