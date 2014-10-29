namespace Rigel.Samples.DesignPatterns.Behavioral.Observer
{
    public interface IWeatherInfoReceiver
    {
        void Report(WeatherReport report);
    }
}