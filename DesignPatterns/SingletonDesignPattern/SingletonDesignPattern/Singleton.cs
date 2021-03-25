using System;

namespace SingletonDesignPattern
{
    public class Singleton
    {
        private static Singleton _instance;

        private static object padLock = new object();

        public DateTime CreatedAt { get; private set;  }

        private Singleton() => CreatedAt = DateTime.Now;

        public static Singleton GetInstance()
        {
            lock (padLock)
            {
                if (_instance == null)
                    _instance = new Singleton();
            }
            return _instance;
        }
    }
}
