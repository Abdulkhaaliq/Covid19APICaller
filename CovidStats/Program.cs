using StatsLibrary;
using System;
using System.Threading.Tasks;

namespace CovidStats
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            StatsModel weatherBoy = new StatsModel();
            Stats weatherInfo = await StatsGenerator.GetWeatherAsync();

        
            Console.Write("Active cases: " + weatherInfo.active);
        }
    }
}
