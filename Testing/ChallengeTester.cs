using System.Numerics;

namespace Testing
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            var challenge = new Challenge1();
            var result = challenge.Solve();

            Assert.That(result, Is.EqualTo(233168));
        }

        [Test]
        public void Test2()
        {
            var challenge = new Challenge2();
            var result = challenge.Solve();

            Assert.That(result, Is.EqualTo(4613732));
        }

        [Test]
        public void Test3()
        {
            var challenge = new Challenge3();
            var result = challenge.Solve();

            Assert.That(result, Is.EqualTo(6857));
        }

        [Test]
        public void Test4()
        {
            var challenge = new Challenge4();
            var result = challenge.Solve();

            Assert.That(result, Is.EqualTo(906609));
        }

        [Test]
        public void Test5()
        {
            var challenge = new Challenge5();
            var result = challenge.Solve();

            Assert.That(result, Is.EqualTo(232792560));
        }

        [Test]
        public void Test6()
        {
            var challenge = new Challenge6();
            var result = challenge.Solve();

            Assert.That(result, Is.EqualTo(25164150));
        }

        [Test]
        public void Test7()
        {
            var challenge = new Challenge7();
            var result = challenge.Solve();

            Assert.That(result, Is.EqualTo(104743));
        }

        [Test]
        public void Test8()
        {
            var challenge = new Challenge8();
            var result = challenge.Solve();

            Assert.That(result, Is.EqualTo(23514624000));
        }

        [Test]
        public void Test9()
        {
            var challenge = new Challenge9();
            var result = challenge.Solve();

            Assert.That(result, Is.EqualTo(31875000));
        }

        [Test]
        public void Test10()
        {
            var challenge = new Challenge10();
            var result = challenge.Solve();
            
            Assert.That(result, Is.EqualTo(142913828922));
        }

        [Test]
        public void Test11()
        {
            var challenge = new Challenge11();
            var result = challenge.Solve();

            Assert.That(result, Is.EqualTo(70600674));
        }

        [Test]
        public void Test12()
        {
            var challenge = new Challenge12();
            var result = challenge.Solve();

            Assert.That(result, Is.EqualTo(76576500));
        }

        [Test]
        public void Test13()
        {
            var challenge = new Challenge13();
            var result = challenge.Solve();

            Assert.That(result, Is.EqualTo("5537376230"));
        }

        [Test]
        public void Test14()
        {
            var challenge = new Challenge14();
            var result = challenge.Solve();

            Assert.That(result, Is.EqualTo(837799));
        }

        [Test]
        public void Test15()
        {
            var challenge = new Challenge15();
            var result = challenge.Solve();

            Assert.That(result == 137846528820);
        }

        [Test]
        public void Test16()
        {
            var challenge = new Challenge16();
            var result = challenge.Solve();

            Assert.That(result, Is.EqualTo(1366));
        }

        [Test]
        public void Test17()
        {
            var challenge = new Challenge17();
            var result = challenge.Solve();

            Assert.That(result, Is.EqualTo(21124));
        }

        [Test]
        public void Test18()
        {
            var challenge = new Challenge18();
            var result = challenge.Solve();

            Assert.That(result, Is.EqualTo(1074));
        }

        [Test]
        public void Test19()
        {
            var challenge = new Challenge19();
            var result = challenge.Solve();

            Assert.That(result, Is.EqualTo(171));
        }

        [Test]
        public void Test20()
        {
            var challenge = new Challenge20();
            var result = challenge.Solve();

            Assert.That(result, Is.EqualTo(648));
        }

        [Test]
        public void Test21()
        {
            var challenge = new Challenge21();
            var result = challenge.Solve();

            Assert.That(result, Is.EqualTo(31626));
        }

        [Test]
        public void Test67()
        {
            var challenge = new Challenge67();
            var result = challenge.Solve();

            Assert.That(result, Is.EqualTo(7273));
        }
    }
}