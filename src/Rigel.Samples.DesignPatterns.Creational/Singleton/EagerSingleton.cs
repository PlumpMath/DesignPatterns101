namespace Rigel.Samples.DesignPatterns.Creational.Singleton
{
    public class EagerSingleton
    {
        private static readonly EagerSingleton _instance = new EagerSingleton();

        private EagerSingleton()
        {
        }

        public static EagerSingleton GetInstance()
        {
            return _instance;
        }
    }
}