using Common.AdvancedMath.WrittenNumbers;

namespace Testing
{
    [TestFixture]
    public class WrittenCalculations
    {
        [Test]
        public void Add()
        {
            var main = new WrittenCalculation(2, CalculationType.Add);
            var second = new WrittenCalculation(5, CalculationType.JustValue);

            main.SetCalculation(second);
            Assert.That(main.GetCalculation(), Is.EqualTo(7));
        }

        [Test]
        public void Substract()
        {
            var main = new WrittenCalculation(5, CalculationType.Substract);
            var second = new WrittenCalculation(2, CalculationType.JustValue);

            main.SetCalculation(second);
            Assert.That(main.GetCalculation(), Is.EqualTo(3));
        }

        [Test]
        public void Multiply()
        {
            var main = new WrittenCalculation(2, CalculationType.Multiply);
            var second = new WrittenCalculation(5, CalculationType.JustValue);

            main.SetCalculation(second);
            Assert.That(main.GetCalculation(), Is.EqualTo(10));
        }

        [Test]
        public void Divide()
        {
            var main = new WrittenCalculation(15, CalculationType.Divide);
            var second = new WrittenCalculation(5, CalculationType.JustValue);

            main.SetCalculation(second);
            Assert.That(main.GetCalculation(), Is.EqualTo(3));
        }

        [Test]
        public void Sqrt()
        {
            var main = new WrittenCalculation(16, CalculationType.Sqrt);

            Assert.That(main.GetCalculation(), Is.EqualTo(4));
        }

        [Test]
        public void JustValue()
        {
            var main = new WrittenCalculation(2, CalculationType.JustValue);
            Assert.That(main.GetCalculation(), Is.EqualTo(2));
        }

        [Test]
        public void SqrtAndAdd()
        {
            var main = new WrittenCalculation(16, CalculationType.Sqrt);
            var second = new WrittenCalculation(2, CalculationType.Add);

            second.SetCalculation(main);
            Assert.That(second.GetCalculation(), Is.EqualTo(6));
        }
    }
}