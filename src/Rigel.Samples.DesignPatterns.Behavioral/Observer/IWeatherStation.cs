namespace Rigel.Samples.DesignPatterns.Behavioral.Observer
{
    public interface IWeatherStation
    {
        RegistrationToken Subscribe(IWeatherInfoReceiver receiver);
        void UnSubscribe(IWeatherInfoReceiver receiver);
    }
}