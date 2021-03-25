using System;

namespace SingletonDesignPattern
{
    public class Singleton
    {
        public DateTime CreatedAt { get; }

        private Singleton() => CreatedAt = DateTime.Now;

        private static readonly Lazy<Singleton> Lazy =
            new(() => new Singleton());

        public static Singleton GetInstance() => Lazy.Value;
    }
}
