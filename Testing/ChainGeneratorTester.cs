using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing
{
    [TestFixture]
    internal class ChainGeneratorTester
    {
        public ChainGeneratorTester()
        {
        }

        [Test]
        public void PeriodicSqareRootChainGeneratorTest()
        {
            PeriodicSqareRootChainGenerator generatorOf2 = new PeriodicSqareRootChainGenerator(2);
            var period2 = generatorOf2.GetPeriod();
            Assert.That(period2, Is.EqualTo("2"));
            
            PeriodicSqareRootChainGenerator generatorOf3 = new PeriodicSqareRootChainGenerator(3);
            var period3 = generatorOf3.GetPeriod();
            Assert.That(period3, Is.EqualTo("12"));

            PeriodicSqareRootChainGenerator generatorOf4 = new PeriodicSqareRootChainGenerator(4);
            var period4 = generatorOf4.GetPeriod();
            Assert.That(period4, Is.EqualTo(""));

            PeriodicSqareRootChainGenerator generatorOf23 = new PeriodicSqareRootChainGenerator(23);
            var period23 = generatorOf23.GetPeriod();
            Assert.That(period23, Is.EqualTo("1318"));
        }
    }
}
