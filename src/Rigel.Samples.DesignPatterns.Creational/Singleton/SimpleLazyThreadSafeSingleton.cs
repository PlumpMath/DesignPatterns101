using System;

namespace Rigel.Samples.DesignPatterns.Creational.Singleton
{
    public class SimpleLazyThreadSafeSingleton
    {
        private static readonly Lazy<SimpleLazyThreadSafeSingleton> _instance  = 
            new Lazy<SimpleLazyThreadSafeSingleton>(() => new SimpleLazyThreadSafeSingleton(), true);

        private SimpleLazyThreadSafeSingleton()
        {
        }

        public static SimpleLazyThreadSafeSingleton Instance { get { return _instance.Value; } }
    }
}