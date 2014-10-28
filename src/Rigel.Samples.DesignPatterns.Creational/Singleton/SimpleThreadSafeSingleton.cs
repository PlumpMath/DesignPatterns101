namespace Rigel.Samples.DesignPatterns.Creational.Singleton
{
    public class SimpleThreadSafeSingleton
    {
        private static readonly SimpleThreadSafeSingleton _instance = new SimpleThreadSafeSingleton();

        public static SimpleThreadSafeSingleton Instance { get { return _instance;  } }

        private SimpleThreadSafeSingleton()
        {
        }
    }
}