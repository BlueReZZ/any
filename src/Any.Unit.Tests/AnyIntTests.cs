using Any.Framework;
using NUnit.Framework;

namespace Any.Unit.Tests
{
    [TestFixture]
    public class AnyIntTests
    {
        private readonly dynamic Any = new AnyGenerator();

        [Test]
        public void IntTests()
        {
            Assert.That(Any.Int(), Is.InstanceOf<int>());
        }

        [Test]
        public void IntBetweenTests()
        {
            int result = Any.IntBetween(0, 3);
            Assert.That(result, Is.InstanceOf<int>());
            Assert.That(result, Is.GreaterThanOrEqualTo(0));
            Assert.That(result, Is.LessThan(3));
        }

        [Test]
        public void IntExceptTests()
        {
            const int exception = 7;
            int result = Any.IntExcept(exception);
            Assert.That(result, Is.InstanceOf<int>());
            Assert.That(result, Is.Not.EqualTo(exception));
        }
    }
}