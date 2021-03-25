using System;

namespace SingletonDesignPattern
{
    public class Singleton
    {
        private static Singleton _instance;
        
        public DateTime CreatedAt { get; private set;  }

        private Singleton() => CreatedAt = DateTime.Now;

        public static Singleton GetInstance()
        {
            if (_instance == null) 
                _instance = new Singleton();

            return _instance;
        }
    }
}
