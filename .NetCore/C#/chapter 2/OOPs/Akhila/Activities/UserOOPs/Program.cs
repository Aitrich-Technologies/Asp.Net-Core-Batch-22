namespace UserOOPs
{
    class User
    {
        public string Username;
        public string Email;
        public int Age;

        public User(string u,string e,int a)
        {
            Username = u;
            Email = e;
            Age = a;
            if(a < 18)
            {
                Console.WriteLine("Underage user");
            }
            else
            {
                Console.WriteLine("User's age is Okay");
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            User user1 = new User("Abc", "abc@gmail.com", 19);
            User user2 = new User("Atul", "atul@gmail.com", 16);

        }
    }
}
