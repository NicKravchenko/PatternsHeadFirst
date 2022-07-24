using System.Collections.Generic;
using System.Linq;

namespace Patterns
{
    public class WeatherData : ISubject
    {
        private List<IObserverr> _observers;
        private float _temperature;
        private float _humidity;
        private float _pressure;

        public WeatherData()
        {
            _observers = new List<IObserverr>();
        }

        public void notifyObserver()
        {
            foreach (var observer in _observers)
            {
                observer.update(_temperature,_humidity, _pressure);
            }
        }

        public void registerObserver(IObserverr o)
        {
            _observers.Add(o);
        }

        public void removeObserver(IObserverr o)
        {
            if (_observers != null && _observers.Count() > 0)
            {
                _observers.Remove(o);
            }
        }

        public void MesurementChanged()
        {
            notifyObserver();
        }

        public void setMeasurements(float temp, float humidity, float pressure)
        {
            this._temperature = temp;
            this._humidity = humidity;
            this._pressure = pressure;
            MesurementChanged();
        }
    }
}
