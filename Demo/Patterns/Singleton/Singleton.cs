using System;

namespace Demo.Patterns.Singleton
{
    public sealed class Singleton
    {
        private static Lazy<Singleton> _instance = new Lazy<Singleton>(() => new Singleton() { Value = new Random().Next() });
        public static Singleton Instance => _instance.Value;
        public int Value { get; set; }

        private Singleton() { }
    }
}
