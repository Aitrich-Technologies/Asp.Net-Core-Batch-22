namespace _2Dmarksheet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[ , ] marks = { { 80,85,75},
                               { 79,90,95},
                                {98,90,80 },
                                {89,96,90 },
                                {75,80,89 } };
            double total = 0;
            for(int i=0;i<5;i++)
            {
                for(int j=0;j<3;j++)
                {
                    total += marks[i,j];
                }
                double avg = total / 3;
                Console.WriteLine("Student average marks is:{0}", avg);
                total = 0;
            }
            
        }
    }
}
