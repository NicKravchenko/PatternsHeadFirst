using System.Text;
using System.Threading.Tasks;

namespace Patterns
{
    internal partial class Program
    {
        static void Main(string[] args)
        {
            WeatherData weatherData = new WeatherData();

            CurrentConditionsDisplay currentConditionsDisplay = 
                new CurrentConditionsDisplay(weatherData);

            weatherData.setMeasurements(81, 65, 30.4f);

        }
    }
}
