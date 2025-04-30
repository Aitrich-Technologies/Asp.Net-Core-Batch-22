namespace enumBasic
{
    internal class Program
    {
        enum Seasons
        {
            Spring,
            Summer,
            Autumn,
            Winter
        };
        static void Main(string[] args)
        {
           
            Seasons current = Seasons.Autumn;
            Console.WriteLine("Autumn set as current season");
        }
    }
}
