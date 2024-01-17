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
        public void Test22()
        {
            var challenge = new Challenge22();
            var result = challenge.Solve();

            Assert.That(result, Is.EqualTo(871198282));
        }

        [Test]
        public void Test23()
        {
            var challenge = new Challenge23();
            var result = challenge.Solve();

            Assert.That(result, Is.EqualTo(4179871));
        }

        [Test]
        public void Test24()
        {
            var challenge = new Challenge24();
            var result = challenge.Solve();

            Assert.That(result, Is.EqualTo(2783915460));
        }

        [Test]
        public void Test25()
        {
            var challenge = new Challenge25();
            var result = challenge.Solve();

            Assert.That(result, Is.EqualTo(4782));
        }

        [Test]
        public void Test26()
        {
            var challenge = new Challenge26();
            var result = challenge.Solve();

            Assert.That(result, Is.EqualTo(983));
        }

        [Test]
        public void Test26WithBigDecimal()
        {
            var challenge = new Challenge26WithBigDecimal();
            var result = challenge.Solve();

            Assert.That(result, Is.EqualTo(983));
        }

        [Test]
        public void Test27()
        {
            var challenge = new Challenge27();
            var result = challenge.Solve();

            Assert.That(result, Is.EqualTo(-59231));
        }

        [Test]
        public void Test28()
        {
            var challenge = new Challenge28();
            var result = challenge.Solve();

            Assert.That(result, Is.EqualTo(669171001));
        }

        [Test]
        public void Test29()
        {
            var challenge = new Challenge29();
            var result = challenge.Solve();

            Assert.That(result, Is.EqualTo(9183));
        }

        [Test]
        public void Test30()
        {
            var challenge = new Challenge30();
            var result = challenge.Solve();

            Assert.That(result, Is.EqualTo(443839));
        }

        [Test]
        public void Test31()
        {
            var challenge = new Challenge31();
            var result = challenge.Solve();

            Assert.That(result, Is.EqualTo(73682));
        }

        [Test]
        public void Test32()
        {
            var challenge = new Challenge32();
            var result = challenge.Solve();

            Assert.That(result, Is.EqualTo(45228));
        }

        [Test]
        public void Test33()
        {
            var challenge = new Challenge33();
            var result = challenge.Solve();

            Assert.That(result, Is.EqualTo(100));
        }

        [Test]
        public void Test34()
        {
            var challenge = new Challenge34();
            var result = challenge.Solve();

            Assert.That(result, Is.EqualTo(40730));
        }

        [Test]
        public void Test35()
        {
            var challenge = new Challenge35();
            var result = challenge.Solve();

            Assert.That(result, Is.EqualTo(55));
        }

        [Test]
        public void Test36()
        {
            var challenge = new Challenge36();
            var result = challenge.Solve();

            Assert.That(result, Is.EqualTo(872187));
        }

        [Test]
        public void Test37()
        {
            var challenge = new Challenge37();
            var result = challenge.Solve();

            Assert.That(result, Is.EqualTo(748317));
        }

        [Test]
        public void Test38()
        {
            var challenge = new Challenge38();
            var result = challenge.Solve();

            Assert.That(result, Is.EqualTo(932718654));
        }

        [Test]
        public void Test39()
        {
            var challenge = new Challenge39();
            var result = challenge.Solve();

            Assert.That(result, Is.EqualTo(840));
        }

        [Test]
        public void Test40()
        {
            var challenge = new Challenge40();
            var result = challenge.Solve();

            Assert.That(result, Is.EqualTo(210));
        }

        [Test]
        public void Test41()
        {
            var challenge = new Challenge41();
            var result = challenge.Solve();

            Assert.That(result, Is.EqualTo(7652413));
        }

        [Test]
        public void Test42()
        {
            var challenge = new Challenge42();
            var result = challenge.Solve();

            Assert.That(result, Is.EqualTo(162));
        }

        [Test]
        public void Test43()
        {
            var challenge = new Challenge43();
            var result = challenge.Solve();

            Assert.That(result, Is.EqualTo(16695334890));
        }

        [Test]
        public void Test44()
        {
            var challenge = new Challenge44();
            var result = challenge.Solve();

            Assert.That(result, Is.EqualTo(5482660));
        }

        [Test]
        public void Test45()
        {
            var challenge = new Challenge45();
            var result = challenge.Solve();

            Assert.That(result, Is.EqualTo(1533776805));
        }

        [Test]
        public void Test46()
        {
            var challenge = new Challenge46();
            var result = challenge.Solve();

            Assert.That(result, Is.EqualTo(5777));
        }

        [Test]
        public void Test47()
        {
            var challenge = new Challenge47();
            var result = challenge.Solve();

            Assert.That(result, Is.EqualTo(134043));
        }

        [Test]
        public void Test48()
        {
            var challenge = new Challenge48();
            var result = challenge.Solve();

            Assert.That(result, Is.EqualTo("9110846700"));
        }

        [Test]
        public void Test49()
        {
            var challenge = new Challenge49();
            var result = challenge.Solve();

            Assert.That(result, Is.EqualTo("296962999629"));
        }

        [Test]
        public void Test50()
        {
            var challenge = new Challenge50();
            var result = challenge.Solve();

            Assert.That(result, Is.EqualTo(997651));
        }


        [Test]
        public void Test52()
        {
            var challenge = new Challenge52();
            var result = challenge.Solve();

            Assert.That(result, Is.EqualTo(142857));
        }


        [Test]
        public void Test53()
        {
            var challenge = new Challenge53();
            var result = challenge.Solve();

            Assert.That(result, Is.EqualTo(4075));
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