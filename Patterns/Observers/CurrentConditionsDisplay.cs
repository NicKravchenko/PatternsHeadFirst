using System;

namespace Patterns
{
    public class CurrentConditionsDisplay : IObserverr, IDisplayElement
    {
        private float _temperature;
        private float _humidity;
        private ISubject _weatherData;

        public CurrentConditionsDisplay(ISubject weatherData)
        {
            this._weatherData = weatherData;
            weatherData.registerObserver(this);
        }
        public void display()
        {
            Console.WriteLine($"Current condition: {_temperature}F degrees and humidity {_humidity}");
        }

        public void update(float temp, float humidity, float pressure)
        {
            this._temperature = temp;
            this._humidity = humidity;
            display();
        }
    }    
}
