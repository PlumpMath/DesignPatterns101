namespace Rigel.Samples.DesignPatterns.Creational.Singleton
{
    public class ThreatSafeSingleton
    {
        private static readonly object _lock = new object();
        private static volatile ThreatSafeSingleton _instance;

        private ThreatSafeSingleton()
        {
        }

        public static ThreatSafeSingleton GetInstance()
        {
            
            if (_instance == null)
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new ThreatSafeSingleton();
                    }
                }
            }

            return _instance;
        } 
    }
}