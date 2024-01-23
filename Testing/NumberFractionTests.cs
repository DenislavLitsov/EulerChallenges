using Common.AdvancedMath;
using Common.Cards.GameEngines.Utility;
using System.Numerics;

namespace Testing
{
    public class NumberFractionTests
    {
        [Test]
        public void Problem57Example1()
        {
            var fraction = new NumberFraction(1, 2);
            var sum = fraction + 1;

            Assert.That(sum.Number, Is.EqualTo(new BigInteger(3)));
            Assert.That(sum.Denominator, Is.EqualTo(new BigInteger(2)));
        }

        [Test]
        public void Problem57Example2()
        {
            var fraction = new NumberFraction(1, 2);
            var under1 = fraction + 2;

            var next = new NumberFraction(1) / under1;
            var result = next + 1;

            Assert.That(result.Number, Is.EqualTo(new BigInteger(7)));
            Assert.That(result.Denominator, Is.EqualTo(new BigInteger(5)));
        }

        [Test]
        public void Problem57Example3()
        {
            var fraction = new NumberFraction(1, 2);
            var under1 = fraction + 2;

            var next = (new NumberFraction(1) / under1) + 2;
            next = new NumberFraction(1) / next;
            var result = next + 1;

            Assert.That(result.Number, Is.EqualTo(new BigInteger(17)));
            Assert.That(result.Denominator, Is.EqualTo(new BigInteger(12)));
        }

        [Test]
        public void Problem57Example4()
        {
            var fraction = new NumberFraction(1, 2);
            var under1 = fraction + 2;

            var next = (new NumberFraction(1) / under1) + 2;
            next = new NumberFraction(1) / next + 2;
            next = new NumberFraction(1) / next;
            var result = next + 1;

            Assert.That(result.Number, Is.EqualTo(new BigInteger(41)));
            Assert.That(result.Denominator, Is.EqualTo(new BigInteger(29)));
        }
    }
}
