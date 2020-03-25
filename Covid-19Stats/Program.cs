using CovidNineteenStatsLibrary;
using System;
using System.Threading.Tasks;

namespace Covid_19Stats
{
    public class Program
    {
        static async Task Main(string[] args)
        {

            StatGenerator statGenerator = new StatGenerator();

            InformationHere informationHere = await StatGenerator.GetStatAsync();

            Console.WriteLine(informationHere.total_cases);
            
            //Console.WriteLine($"{statGenerator.ToString()}");


        }
    }
}
