namespace votingsystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] votes = { 1, 8, 3 ,4,5};
            int large=votes[0];
            int small=votes[0];
            int count=0;
            for (int i = 0; i < votes.Length; i++)
            {
                if (votes[i] > large)
                {
                    large = votes[i];
                    count = i;
                }
                else
                {
                    small = votes[i];

                }
            }
            count++;
            Console.WriteLine("The highest number votes got to the "+ count + " person is " + large);

        }
    }
}
