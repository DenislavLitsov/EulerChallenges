using Common.NumberSequences;
using Common.NumberSequences.Spirals;

namespace Testing
{
    public class SpiralNumberGeneratorTester
    {
        [Test]
        public void TriangleSequenceGeneratorTest()
        {
            var results = new List<TwoDSpiralNumberResult>();
            results.Add(new TwoDSpiralNumberResult(1, true));
            results.Add(new TwoDSpiralNumberResult(2, false));
            results.Add(new TwoDSpiralNumberResult(3, true));
            results.Add(new TwoDSpiralNumberResult(4, false));
            results.Add(new TwoDSpiralNumberResult(5, true));
            results.Add(new TwoDSpiralNumberResult(6, false));
            results.Add(new TwoDSpiralNumberResult(7, true));
            results.Add(new TwoDSpiralNumberResult(8, false));
            results.Add(new TwoDSpiralNumberResult(9, true));
            results.Add(new TwoDSpiralNumberResult(10, false));
            results.Add(new TwoDSpiralNumberResult(11, false));
            results.Add(new TwoDSpiralNumberResult(12, false));
            results.Add(new TwoDSpiralNumberResult(13, true));
            results.Add(new TwoDSpiralNumberResult(14, false));
            results.Add(new TwoDSpiralNumberResult(15, false));
            results.Add(new TwoDSpiralNumberResult(16, false));
            results.Add(new TwoDSpiralNumberResult(17, true));
            results.Add(new TwoDSpiralNumberResult(18, false));
            results.Add(new TwoDSpiralNumberResult(19, false));
            results.Add(new TwoDSpiralNumberResult(20, false));
            results.Add(new TwoDSpiralNumberResult(21, true));
            results.Add(new TwoDSpiralNumberResult(22, false));
            results.Add(new TwoDSpiralNumberResult(23, false));
            results.Add(new TwoDSpiralNumberResult(24, false));
            results.Add(new TwoDSpiralNumberResult(25, true));

            var generator = new TwoDSpiralNumberGenerator(1);
            for (int i = 0; i < 25; i++)
            {
                var next = generator.GetNext();
                Assert.That(next.Value, Is.EqualTo(results[i].Value));
                Assert.That(next.IsAtAngle, Is.EqualTo(results[i].IsAtAngle));
            }
        }
        [Test]
        public void TriangleSequenceBlockGeneratorTest()
        {
            var generator = new TwoDSpiralNumberGenerator(1);
            var block1 = generator.GetNextBlock();
            var block2 = generator.GetNextBlock();
            var block3 = generator.GetNextBlock();

            Assert.That(block1.Count(), Is.EqualTo(1));
            Assert.That(block2.Count(), Is.EqualTo(8));
            Assert.That(block3.Count(), Is.EqualTo(16));

            Assert.That(block1.First().Value, Is.EqualTo(1));
            Assert.That(block2.Last().Value, Is.EqualTo(9));
            Assert.That(block3.Last().Value, Is.EqualTo(25));
        }
    }
}
