using Common.AdvancedMath;

namespace Testing
{
    [TestFixture]
    public class AdvancedMathTester
    {
        public AdvancedMathTester()
        {
        }
        
        [Test]
        public void TestGetAllDivisorsExcludingSameNumber()
        {
            var sum1 = 28.GetAllDivisorsExcludingSameNumber().Sum();
            Assert.That(sum1, Is.EqualTo(28));
            var sum2 = 12.GetAllDivisorsExcludingSameNumber().Sum();
            Assert.That(sum2, Is.EqualTo(16));
            
            long sum5 = ((long)28).GetAllDivisorsExcludingSameNumber().Sum();
            Assert.That(sum5, Is.EqualTo(28));
            long sum6 = ((long)12).GetAllDivisorsExcludingSameNumber().Sum();
            Assert.That(sum6, Is.EqualTo(16));

            var num3 = 16.GetAllDivisorsExcludingSameNumber();
            Assert.That(num3.Count(), Is.EqualTo(4));
            var num4 = ((long)16).GetAllDivisorsExcludingSameNumber();
            Assert.That(num4.Count(), Is.EqualTo(4));
        }
    }
}