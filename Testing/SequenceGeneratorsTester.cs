using System.Numerics;
using Common.NumberSequences;

namespace Testing
{
    public class SequenceGeneratorsTester
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TriangleSequenceGeneratorTest()
        {
            TriangleSequenceGenerator generator = new TriangleSequenceGenerator();
            Assert.That(generator.CalculateNumberAtExactIndex(1), Is.EqualTo(1));
            Assert.That(generator.CalculateNumberAtExactIndex(2), Is.EqualTo(3));
            Assert.That(generator.CalculateNumberAtExactIndex(3), Is.EqualTo(6));
            Assert.That(generator.CalculateNumberAtExactIndex(4), Is.EqualTo(10));
        }

        [Test]
        public void PentagonalSequenceGeneratorTest()
        {
            PentagonalSequenceGenerator generator = new PentagonalSequenceGenerator();
            Assert.That(generator.CalculateNumberAtExactIndex(1), Is.EqualTo(1));
            Assert.That(generator.CalculateNumberAtExactIndex(2), Is.EqualTo(5));
            Assert.That(generator.CalculateNumberAtExactIndex(3), Is.EqualTo(12));
            Assert.That(generator.CalculateNumberAtExactIndex(4), Is.EqualTo(22));
        }

        [Test]
        public void HexagonalSequenceGeneratorTest()
        {
            HexagonalSequenceGenerator generator = new HexagonalSequenceGenerator();
            Assert.That(generator.CalculateNumberAtExactIndex(1), Is.EqualTo(1));
            Assert.That(generator.CalculateNumberAtExactIndex(2), Is.EqualTo(6));
            Assert.That(generator.CalculateNumberAtExactIndex(3), Is.EqualTo(15));
            Assert.That(generator.CalculateNumberAtExactIndex(4), Is.EqualTo(28));
        }

        [Test]
        public void PrimeSequenceGeneratorTest()
        {
            PrimeSequenceGenerator generator = new PrimeSequenceGenerator(0, 1000000);
            Assert.That(generator.CalculateNumberAtExactIndex(0), Is.EqualTo(2));
            Assert.That(generator.CalculateNumberAtExactIndex(1), Is.EqualTo(3));
            Assert.That(generator.CalculateNumberAtExactIndex(2), Is.EqualTo(5));
            Assert.That(generator.CalculateNumberAtExactIndex(3), Is.EqualTo(7));
            Assert.That(generator.CalculateNumberAtExactIndex(4), Is.EqualTo(11));
            Assert.That(generator.CalculateNumberAtExactIndex(5), Is.EqualTo(13));
            Assert.That(generator.CalculateNumberAtExactIndex(6), Is.EqualTo(17));

            Assert.That(generator.GetIndexInCachedSquence(17), Is.EqualTo(6));
            Assert.That(generator.IsPartOfCachedSequence(3), Is.EqualTo(true));
            Assert.That(generator.IsPartOfCachedSequence(4), Is.EqualTo(false));

            generator = new PrimeSequenceGenerator(2, 1000000);

            Assert.That(generator.GetIndexInCachedSquence(7), Is.EqualTo(1));
            Assert.That(generator.IsPartOfCachedSequence(5), Is.EqualTo(true));
            Assert.That(generator.IsPartOfCachedSequence(3), Is.EqualTo(false));
            Assert.That(generator.IsPartOfCachedSequence(4), Is.EqualTo(false));
        }
    }
}