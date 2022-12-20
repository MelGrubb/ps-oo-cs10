using Demo.Patterns.Singleton;
using NUnit.Framework;
using System;

namespace Tests.SingletonTests
{
    [TestFixture]
    public class SingletonTests
    {
        [Test]
        public void Singleton_Instance_always_returns_the_same_object()
        {
            var instance1 = Singleton.Instance;
            var instance2 = Singleton.Instance;
            Assert.AreEqual(instance1.Value, instance2.Value);
            Console.WriteLine($"{instance1.Value} == {instance2.Value}");
        }
    }
}
