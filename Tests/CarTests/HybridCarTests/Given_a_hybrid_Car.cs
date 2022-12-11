using Demo;
using NUnit.Framework;

<<<<<<<< HEAD:Tests/CarTests/Given_a_Car.cs
namespace Tests.CarTests
{
    [TestFixture]
    public abstract class Given_a_Car
========
namespace Tests.CarTests.HybridCarTests
{
    [TestFixture]
    public abstract class Given_a_hybrid_Car
>>>>>>>> 04-solid-lsp:Tests/CarTests/HybridCarTests/Given_a_hybrid_Car.cs
    {
        protected Car SUT { get; set; }

        [SetUp]
        public virtual void SetUp()
        {
<<<<<<<< HEAD:Tests/CarTests/Given_a_Car.cs
            SUT = new Car { EngineType = EngineType.Electric };
========
            SUT = new Car(new HybridControlModule());
>>>>>>>> 04-solid-lsp:Tests/CarTests/HybridCarTests/Given_a_hybrid_Car.cs
        }
    }
}
