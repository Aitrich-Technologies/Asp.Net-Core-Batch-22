namespace Pgm1OOPs
{
    public class JobSeeker
    {
        public int Id;
        public string FirstName;
        public string LastName;

        public JobSeeker() 
        {
            Console.WriteLine("Default constructor");
        }
        public JobSeeker(int id, string firstName, string lastName)
        {

            Id = id;
            FirstName = firstName;
            LastName = lastName;
        }

        public void applyJob(int jobid)
        {
            Console.WriteLine("Applying for a job started");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            JobSeeker seeker=new JobSeeker(1,"Sam","Wilson");
            //seeker.FirstName = "Sam";
            //seeker.LastName = "Wilson";
           Console.WriteLine(seeker.FirstName);
            seeker.applyJob(1);
            //Console.WriteLine("Hello, World!");
        }
    }
}
