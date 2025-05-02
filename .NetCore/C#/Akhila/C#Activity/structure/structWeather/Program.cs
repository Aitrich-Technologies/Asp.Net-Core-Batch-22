namespace structWeather
{

    internal class Program
    {
        struct Weather
        {
            public string date;
            public double Temperature;
            public double Humidity;
            public string Condition;
        }
        static void Main(string[] args)
        {
            Weather[] weather = new Weather[7];
            Console.WriteLine("Enter weather report of 7 days: ");
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine($"Weather:Day {i + 1}");
                Console.WriteLine("Date: ");
                weather[i].date = Console.ReadLine();
                Console.WriteLine("Temperature: ");
                weather[i].Temperature = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Humidity: ");
                weather[i].Humidity = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Condition:");
                weather[i].Condition = Console.ReadLine();
                Console.WriteLine("________________________");
            }
            int hot = 0;
            int cold = 0;
            double min = 10;
            double max = 50;
            for (int i = 0; i < 4; i++)
            {
                if (weather[i].Temperature > max)
                {
                    max = weather[i].Temperature;
                    hot = i;
                }
                else if (weather[i].Temperature < min)
                {
                    min = weather[i].Temperature;
                    cold = i;
                }
            }
            Console.WriteLine("The hottest day is on {0} temperature is {1}", weather[hot].date, weather[hot].Temperature);
            Console.WriteLine("________________________");
            Console.WriteLine("The coldest day is on {0} temperature is {1}", weather[cold].date, weather[hot].Temperature);
            Console.WriteLine("________________________");

        }
    }
}
