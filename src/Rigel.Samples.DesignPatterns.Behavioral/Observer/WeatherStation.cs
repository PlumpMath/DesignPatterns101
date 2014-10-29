using System;
using System.Collections.Generic;
using System.Linq;

namespace Rigel.Samples.DesignPatterns.Behavioral.Observer
{
    public class WeatherStation : IWeatherStation
    {
        private readonly List<IWeatherInfoReceiver> _receivers = new List<IWeatherInfoReceiver>(); 

        public RegistrationToken Subscribe(IWeatherInfoReceiver receiver)
        {
            if (!_receivers.Any(r => r.Equals(receiver)))
            {
                _receivers.Add(receiver);
            }

            return new RegistrationToken(this, receiver);
        }

        public void UnSubscribe(IWeatherInfoReceiver receiver)
        {
            if (_receivers.Any(r => r.Equals(receiver)))
            {
                _receivers.Remove(receiver);
            }
        }
    }

    public class WeatherReport
    {
        public decimal Temperature { get; set; }
        public decimal Preasure { get; set; }
        public decimal Humidity { get; set; }
        public decimal Wind { get; set; }
        public decimal Precipitation { get; set; }
        public DateTime IssuedOn { get; set; }
    }
}