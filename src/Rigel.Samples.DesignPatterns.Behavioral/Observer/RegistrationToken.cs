using System;

namespace Rigel.Samples.DesignPatterns.Behavioral.Observer
{
    public class RegistrationToken : IDisposable
    {
        private readonly IWeatherStation _station;
        private readonly IWeatherInfoReceiver _receiver;

        public RegistrationToken(IWeatherStation station, IWeatherInfoReceiver receiver)
        {
            _station = station;
            _receiver = receiver;
        }

        public void Dispose()
        {
            _station.UnSubscribe(_receiver);
        }
    }
}