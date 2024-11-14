using ChallengeExecutor.Challenges.Challenges101To150.Challenge124;

namespace Testing
{
    public class Tests
    {
        private const int Max_Miliseconds_Per_Challenge = 1000 * 60;

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
            Assert.That(challenge.GetElapsedMiliseconds, Is.LessThanOrEqualTo(Max_Miliseconds_Per_Challenge));
        }

        [Test]
        public void Test2()
        {
            var challenge = new Challenge2();
            var result = challenge.Solve();

            Assert.That(result, Is.EqualTo(4613732));
            Assert.That(challenge.GetElapsedMiliseconds, Is.LessThanOrEqualTo(Max_Miliseconds_Per_Challenge));
        }

        [Test]
        public void Test3()
        {
            var challenge = new Challenge3();
            var result = challenge.Solve();

            Assert.That(result, Is.EqualTo(6857));
            Assert.That(challenge.GetElapsedMiliseconds, Is.LessThanOrEqualTo(Max_Miliseconds_Per_Challenge));
        }

        [Test]
        public void Test4()
        {
            var challenge = new Challenge4();
            var result = challenge.Solve();

            Assert.That(result, Is.EqualTo(906609));
            Assert.That(challenge.GetElapsedMiliseconds, Is.LessThanOrEqualTo(Max_Miliseconds_Per_Challenge));
        }

        [Test]
        public void Test5()
        {
            var challenge = new Challenge5();
            var result = challenge.Solve();

            Assert.That(result, Is.EqualTo(232792560));
            Assert.That(challenge.GetElapsedMiliseconds, Is.LessThanOrEqualTo(Max_Miliseconds_Per_Challenge));
        }

        [Test]
        public void Test6()
        {
            var challenge = new Challenge6();
            var result = challenge.Solve();

            Assert.That(result, Is.EqualTo(25164150));
            Assert.That(challenge.GetElapsedMiliseconds, Is.LessThanOrEqualTo(Max_Miliseconds_Per_Challenge));
        }

        [Test]
        public void Test7()
        {
            var challenge = new Challenge7();
            var result = challenge.Solve();

            Assert.That(result, Is.EqualTo(104743));
            Assert.That(challenge.GetElapsedMiliseconds, Is.LessThanOrEqualTo(Max_Miliseconds_Per_Challenge));
        }

        [Test]
        public void Test8()
        {
            var challenge = new Challenge8();
            var result = challenge.Solve();

            Assert.That(result, Is.EqualTo(23514624000));
            Assert.That(challenge.GetElapsedMiliseconds, Is.LessThanOrEqualTo(Max_Miliseconds_Per_Challenge));
        }

        [Test]
        public void Test9()
        {
            var challenge = new Challenge9();
            var result = challenge.Solve();

            Assert.That(result, Is.EqualTo(31875000));
            Assert.That(challenge.GetElapsedMiliseconds, Is.LessThanOrEqualTo(Max_Miliseconds_Per_Challenge));
        }

        [Test]
        public void Test10()
        {
            var challenge = new Challenge10();
            var result = challenge.Solve();

            Assert.That(result, Is.EqualTo(142913828922));
            Assert.That(challenge.GetElapsedMiliseconds, Is.LessThanOrEqualTo(Max_Miliseconds_Per_Challenge));
        }

        [Test]
        public void Test11()
        {
            var challenge = new Challenge11();
            var result = challenge.Solve();

            Assert.That(result, Is.EqualTo(70600674));
            Assert.That(challenge.GetElapsedMiliseconds, Is.LessThanOrEqualTo(Max_Miliseconds_Per_Challenge));
        }

        [Test]
        public void Test12()
        {
            var challenge = new Challenge12();
            var result = challenge.Solve();

            Assert.That(result, Is.EqualTo(76576500));
            Assert.That(challenge.GetElapsedMiliseconds, Is.LessThanOrEqualTo(Max_Miliseconds_Per_Challenge * 2));
        }

        [Test]
        public void Test13()
        {
            var challenge = new Challenge13();
            var result = challenge.Solve();

            Assert.That(result, Is.EqualTo("5537376230"));
            Assert.That(challenge.GetElapsedMiliseconds, Is.LessThanOrEqualTo(Max_Miliseconds_Per_Challenge));
        }

        [Test]
        public void Test14()
        {
            var challenge = new Challenge14();
            var result = challenge.Solve();

            Assert.That(result, Is.EqualTo(837799));
            Assert.That(challenge.GetElapsedMiliseconds, Is.LessThanOrEqualTo(Max_Miliseconds_Per_Challenge));
        }

        [Test]
        public void Test15()
        {
            var challenge = new Challenge15();
            var result = challenge.Solve();

            Assert.That(result == 137846528820);
            Assert.That(challenge.GetElapsedMiliseconds, Is.LessThanOrEqualTo(Max_Miliseconds_Per_Challenge));
        }

        [Test]
        public void Test16()
        {
            var challenge = new Challenge16();
            var result = challenge.Solve();

            Assert.That(result, Is.EqualTo(1366));
            Assert.That(challenge.GetElapsedMiliseconds, Is.LessThanOrEqualTo(Max_Miliseconds_Per_Challenge));
        }

        [Test]
        public void Test17()
        {
            var challenge = new Challenge17();
            var result = challenge.Solve();

            Assert.That(result, Is.EqualTo(21124));
            Assert.That(challenge.GetElapsedMiliseconds, Is.LessThanOrEqualTo(Max_Miliseconds_Per_Challenge));
        }

        [Test]
        public void Test18()
        {
            var challenge = new Challenge18();
            var result = challenge.Solve();

            Assert.That(result, Is.EqualTo(1074));
            Assert.That(challenge.GetElapsedMiliseconds, Is.LessThanOrEqualTo(Max_Miliseconds_Per_Challenge));
        }

        [Test]
        public void Test19()
        {
            var challenge = new Challenge19();
            var result = challenge.Solve();

            Assert.That(result, Is.EqualTo(171));
            Assert.That(challenge.GetElapsedMiliseconds, Is.LessThanOrEqualTo(Max_Miliseconds_Per_Challenge));
        }

        [Test]
        public void Test20()
        {
            var challenge = new Challenge20();
            var result = challenge.Solve();

            Assert.That(result, Is.EqualTo(648));
            Assert.That(challenge.GetElapsedMiliseconds, Is.LessThanOrEqualTo(Max_Miliseconds_Per_Challenge));
        }

        [Test]
        public void Test21()
        {
            var challenge = new Challenge21();
            var result = challenge.Solve();

            Assert.That(result, Is.EqualTo(31626));
            Assert.That(challenge.GetElapsedMiliseconds, Is.LessThanOrEqualTo(Max_Miliseconds_Per_Challenge));
        }

        [Test]
        public void Test22()
        {
            var challenge = new Challenge22();
            var result = challenge.Solve();

            Assert.That(result, Is.EqualTo(871198282));
            Assert.That(challenge.GetElapsedMiliseconds, Is.LessThanOrEqualTo(Max_Miliseconds_Per_Challenge));
        }

        [Test]
        public void Test23()
        {
            var challenge = new Challenge23();
            var result = challenge.Solve();

            Assert.That(result, Is.EqualTo(4179871));
            Assert.That(challenge.GetElapsedMiliseconds, Is.LessThanOrEqualTo(Max_Miliseconds_Per_Challenge));
        }

        [Test]
        public void Test24()
        {
            var challenge = new Challenge24();
            var result = challenge.Solve();

            Assert.That(result, Is.EqualTo(2783915460));
            Assert.That(challenge.GetElapsedMiliseconds, Is.LessThanOrEqualTo(Max_Miliseconds_Per_Challenge));
        }

        [Test]
        public void Test25()
        {
            var challenge = new Challenge25();
            var result = challenge.Solve();

            Assert.That(result, Is.EqualTo(4782));
            Assert.That(challenge.GetElapsedMiliseconds, Is.LessThanOrEqualTo(Max_Miliseconds_Per_Challenge));
        }

        [Test]
        public void Test26()
        {
            var challenge = new Challenge26();
            var result = challenge.Solve();

            Assert.That(result, Is.EqualTo(983));
            Assert.That(challenge.GetElapsedMiliseconds, Is.LessThanOrEqualTo(Max_Miliseconds_Per_Challenge));
        }

        [Test]
        public void Test26WithBigDecimal()
        {
            var challenge = new Challenge26WithBigDecimal();
            var result = challenge.Solve();

            Assert.That(result, Is.EqualTo(983));
            Assert.That(challenge.GetElapsedMiliseconds, Is.LessThanOrEqualTo(Max_Miliseconds_Per_Challenge));
        }

        [Test]
        public void Test27()
        {
            var challenge = new Challenge27();
            var result = challenge.Solve();

            Assert.That(result, Is.EqualTo(-59231));
            Assert.That(challenge.GetElapsedMiliseconds, Is.LessThanOrEqualTo(Max_Miliseconds_Per_Challenge));
        }

        [Test]
        public void Test28()
        {
            var challenge = new Challenge28();
            var result = challenge.Solve();

            Assert.That(result, Is.EqualTo(669171001));
            Assert.That(challenge.GetElapsedMiliseconds, Is.LessThanOrEqualTo(Max_Miliseconds_Per_Challenge));
        }

        [Test]
        public void Test29()
        {
            var challenge = new Challenge29();
            var result = challenge.Solve();

            Assert.That(result, Is.EqualTo(9183));
            Assert.That(challenge.GetElapsedMiliseconds, Is.LessThanOrEqualTo(Max_Miliseconds_Per_Challenge));
        }

        [Test]
        public void Test30()
        {
            var challenge = new Challenge30();
            var result = challenge.Solve();

            Assert.That(result, Is.EqualTo(443839));
            Assert.That(challenge.GetElapsedMiliseconds, Is.LessThanOrEqualTo(Max_Miliseconds_Per_Challenge));
        }

        [Test]
        public void Test31()
        {
            var challenge = new Challenge31();
            var result = challenge.Solve();

            Assert.That(result, Is.EqualTo(73682));
            Assert.That(challenge.GetElapsedMiliseconds, Is.LessThanOrEqualTo(Max_Miliseconds_Per_Challenge));
        }

        [Test]
        public void Test32()
        {
            var challenge = new Challenge32();
            var result = challenge.Solve();

            Assert.That(result, Is.EqualTo(45228));
            Assert.That(challenge.GetElapsedMiliseconds, Is.LessThanOrEqualTo(Max_Miliseconds_Per_Challenge));
        }

        [Test]
        public void Test33()
        {
            var challenge = new Challenge33();
            var result = challenge.Solve();

            Assert.That(result, Is.EqualTo(100));
            Assert.That(challenge.GetElapsedMiliseconds, Is.LessThanOrEqualTo(Max_Miliseconds_Per_Challenge));
        }

        [Test]
        public void Test34()
        {
            var challenge = new Challenge34();
            var result = challenge.Solve();

            Assert.That(result, Is.EqualTo(40730));
            Assert.That(challenge.GetElapsedMiliseconds, Is.LessThanOrEqualTo(Max_Miliseconds_Per_Challenge));
        }

        [Test]
        public void Test35()
        {
            var challenge = new Challenge35();
            var result = challenge.Solve();

            Assert.That(result, Is.EqualTo(55));
            Assert.That(challenge.GetElapsedMiliseconds, Is.LessThanOrEqualTo(Max_Miliseconds_Per_Challenge));
        }

        [Test]
        public void Test36()
        {
            var challenge = new Challenge36();
            var result = challenge.Solve();

            Assert.That(result, Is.EqualTo(872187));
            Assert.That(challenge.GetElapsedMiliseconds, Is.LessThanOrEqualTo(Max_Miliseconds_Per_Challenge));
        }

        [Test]
        public void Test37()
        {
            var challenge = new Challenge37();
            var result = challenge.Solve();

            Assert.That(result, Is.EqualTo(748317));
            Assert.That(challenge.GetElapsedMiliseconds, Is.LessThanOrEqualTo(Max_Miliseconds_Per_Challenge));
        }

        [Test]
        public void Test38()
        {
            var challenge = new Challenge38();
            var result = challenge.Solve();

            Assert.That(result, Is.EqualTo(932718654));
            Assert.That(challenge.GetElapsedMiliseconds, Is.LessThanOrEqualTo(Max_Miliseconds_Per_Challenge));
        }

        [Test]
        public void Test39()
        {
            var challenge = new Challenge39();
            var result = challenge.Solve();

            Assert.That(result, Is.EqualTo(840));
            Assert.That(challenge.GetElapsedMiliseconds, Is.LessThanOrEqualTo(Max_Miliseconds_Per_Challenge));
        }

        [Test]
        public void Test40()
        {
            var challenge = new Challenge40();
            var result = challenge.Solve();

            Assert.That(result, Is.EqualTo(210));
            Assert.That(challenge.GetElapsedMiliseconds, Is.LessThanOrEqualTo(Max_Miliseconds_Per_Challenge));
        }

        [Test]
        public void Test41()
        {
            var challenge = new Challenge41();
            var result = challenge.Solve();

            Assert.That(result, Is.EqualTo(7652413));
            Assert.That(challenge.GetElapsedMiliseconds, Is.LessThanOrEqualTo(Max_Miliseconds_Per_Challenge));
        }

        [Test]
        public void Test42()
        {
            var challenge = new Challenge42();
            var result = challenge.Solve();

            Assert.That(result, Is.EqualTo(162));
            Assert.That(challenge.GetElapsedMiliseconds, Is.LessThanOrEqualTo(Max_Miliseconds_Per_Challenge));
        }

        [Test]
        public void Test43()
        {
            var challenge = new Challenge43();
            var result = challenge.Solve();

            Assert.That(result, Is.EqualTo(16695334890));
            Assert.That(challenge.GetElapsedMiliseconds, Is.LessThanOrEqualTo(Max_Miliseconds_Per_Challenge));
        }

        [Test]
        public void Test44()
        {
            var challenge = new Challenge44();
            var result = challenge.Solve();

            Assert.That(result, Is.EqualTo(5482660));
            Assert.That(challenge.GetElapsedMiliseconds, Is.LessThanOrEqualTo(Max_Miliseconds_Per_Challenge));
        }

        [Test]
        public void Test45()
        {
            var challenge = new Challenge45();
            var result = challenge.Solve();

            Assert.That(result, Is.EqualTo(1533776805));
            Assert.That(challenge.GetElapsedMiliseconds, Is.LessThanOrEqualTo(Max_Miliseconds_Per_Challenge));
        }

        [Test]
        public void Test46()
        {
            var challenge = new Challenge46();
            var result = challenge.Solve();

            Assert.That(result, Is.EqualTo(5777));
            Assert.That(challenge.GetElapsedMiliseconds, Is.LessThanOrEqualTo(Max_Miliseconds_Per_Challenge));
        }

        [Test]
        public void Test47()
        {
            var challenge = new Challenge47();
            var result = challenge.Solve();

            Assert.That(result, Is.EqualTo(134043));
            Assert.That(challenge.GetElapsedMiliseconds, Is.LessThanOrEqualTo(Max_Miliseconds_Per_Challenge));
        }

        [Test]
        public void Test48()
        {
            var challenge = new Challenge48();
            var result = challenge.Solve();

            Assert.That(result, Is.EqualTo("9110846700"));
            Assert.That(challenge.GetElapsedMiliseconds, Is.LessThanOrEqualTo(Max_Miliseconds_Per_Challenge));
        }

        [Test]
        public void Test49()
        {
            var challenge = new Challenge49();
            var result = challenge.Solve();

            Assert.That(result, Is.EqualTo("296962999629"));
            Assert.That(challenge.GetElapsedMiliseconds, Is.LessThanOrEqualTo(Max_Miliseconds_Per_Challenge));
        }

        [Test]
        public void Test50()
        {
            var challenge = new Challenge50();
            var result = challenge.Solve();

            Assert.That(result, Is.EqualTo(997651));
            Assert.That(challenge.GetElapsedMiliseconds, Is.LessThanOrEqualTo(Max_Miliseconds_Per_Challenge));
        }

        [Test]
        public void Test51()
        {
            var challenge = new Challenge51();
            var result = challenge.Solve();

            Assert.That(result, Is.EqualTo(121313));
            Assert.That(challenge.GetElapsedMiliseconds, Is.LessThanOrEqualTo(Max_Miliseconds_Per_Challenge));
        }

        [Test]
        public void Test52()
        {
            var challenge = new Challenge52();
            var result = challenge.Solve();

            Assert.That(result, Is.EqualTo(142857));
            Assert.That(challenge.GetElapsedMiliseconds, Is.LessThanOrEqualTo(Max_Miliseconds_Per_Challenge));
        }

        [Test]
        public void Test53()
        {
            var challenge = new Challenge53();
            var result = challenge.Solve();

            Assert.That(result, Is.EqualTo(4075));
            Assert.That(challenge.GetElapsedMiliseconds, Is.LessThanOrEqualTo(Max_Miliseconds_Per_Challenge));
        }

        [Test]
        public void Test54()
        {
            var challenge = new Challenge54();
            var result = challenge.Solve();

            Assert.That(result, Is.EqualTo(376));
            Assert.That(challenge.GetElapsedMiliseconds, Is.LessThanOrEqualTo(Max_Miliseconds_Per_Challenge));
        }

        [Test]
        public void Test55()
        {
            var challenge = new Challenge55();
            var result = challenge.Solve();

            Assert.That(result, Is.EqualTo(249));
            Assert.That(challenge.GetElapsedMiliseconds, Is.LessThanOrEqualTo(Max_Miliseconds_Per_Challenge));
        }

        [Test]
        public void Test56()
        {
            var challenge = new Challenge56();
            var result = challenge.Solve();

            Assert.That(result, Is.EqualTo(972));
            Assert.That(challenge.GetElapsedMiliseconds, Is.LessThanOrEqualTo(Max_Miliseconds_Per_Challenge));
        }

        [Test]
        public void Test57()
        {
            var challenge = new Challenge57();
            var result = challenge.Solve();

            Assert.That(result, Is.EqualTo(153));
            Assert.That(challenge.GetElapsedMiliseconds, Is.LessThanOrEqualTo(Max_Miliseconds_Per_Challenge));
        }

        [Test]
        public void Test58()
        {
            var challenge = new Challenge58();
            var result = challenge.Solve();

            Assert.That(result, Is.EqualTo(26241));
            Assert.That(challenge.GetElapsedMiliseconds, Is.LessThanOrEqualTo(Max_Miliseconds_Per_Challenge));
        }

        [Test]
        public void Test59()
        {
            var challenge = new Challenge59();
            var result = challenge.Solve();

            Assert.That(result, Is.EqualTo(129448));
            Assert.That(challenge.GetElapsedMiliseconds, Is.LessThanOrEqualTo(Max_Miliseconds_Per_Challenge));
        }

        [Test]
        public void Test60()
        {
            var challenge = new Challenge60();
            Assert.That(challenge.Solve(), Is.EqualTo(26033));
            Assert.That(challenge.GetElapsedMiliseconds, Is.LessThanOrEqualTo(Max_Miliseconds_Per_Challenge));
        }

        [Test]
        public void Test61()
        {
            var challenge = new Challenge61();
            Assert.That(challenge.Solve(), Is.EqualTo(28684));
            Assert.That(challenge.GetElapsedMiliseconds, Is.LessThanOrEqualTo(Max_Miliseconds_Per_Challenge));
        }

        [Test]
        public void Test62()
        {
            var challenge = new Challenge62();
            Assert.That(challenge.Solve(), Is.EqualTo(127035954683));
            Assert.That(challenge.GetElapsedMiliseconds, Is.LessThanOrEqualTo(Max_Miliseconds_Per_Challenge));
        }

        [Test]
        public void Test63()
        {
            var challenge = new Challenge63();
            var result = challenge.Solve();

            Assert.That(result, Is.EqualTo(49));
            Assert.That(challenge.GetElapsedMiliseconds, Is.LessThanOrEqualTo(Max_Miliseconds_Per_Challenge));
        }

        public void Test64()
        {
            throw new NotImplementedException();
            //var challenge = new Challenge99();
            //Assert.That(challenge.Solve(), Is.EqualTo(709));
            //Assert.That(challenge.GetElapsedMiliseconds, Is.LessThanOrEqualTo(Max_Miliseconds_Per_Challenge));
        }

        public void Test65()
        {
            throw new NotImplementedException();
            //var challenge = new Challenge99();
            //Assert.That(challenge.Solve(), Is.EqualTo(709));
            //Assert.That(challenge.GetElapsedMiliseconds, Is.LessThanOrEqualTo(Max_Miliseconds_Per_Challenge));
        }

        public void Test66()
        {
            throw new NotImplementedException();
            //var challenge = new Challenge99();
            //Assert.That(challenge.Solve(), Is.EqualTo(709));
            //Assert.That(challenge.GetElapsedMiliseconds, Is.LessThanOrEqualTo(Max_Miliseconds_Per_Challenge));
        }

        [Test]
        public void Test67()
        {
            var challenge = new Challenge67();
            var result = challenge.Solve();

            Assert.That(result, Is.EqualTo(7273));
            Assert.That(challenge.GetElapsedMiliseconds, Is.LessThanOrEqualTo(Max_Miliseconds_Per_Challenge));
        }

        [Test]
        public void Test68()
        {
            var challenge = new Challenge68();
            Assert.That(challenge.Solve(), Is.EqualTo(6531031914842725));
            Assert.That(challenge.GetElapsedMiliseconds, Is.LessThanOrEqualTo(Max_Miliseconds_Per_Challenge));
        }

        public void Test69()
        {
            throw new NotImplementedException();
            //var challenge = new Challenge99();
            //Assert.That(challenge.Solve(), Is.EqualTo(709));
            //Assert.That(challenge.GetElapsedMiliseconds, Is.LessThanOrEqualTo(Max_Miliseconds_Per_Challenge));
        }

        public void Test70()
        {
            throw new NotImplementedException();
            //var challenge = new Challenge99();
            //Assert.That(challenge.Solve(), Is.EqualTo(709));
            //Assert.That(challenge.GetElapsedMiliseconds, Is.LessThanOrEqualTo(Max_Miliseconds_Per_Challenge));
        }

        [Test]
        public void Test71()
        {
            var challenge = new Challenge71();
            var result = challenge.Solve();

            Assert.That(result, Is.EqualTo(428570));
            Assert.That(challenge.GetElapsedMiliseconds, Is.LessThanOrEqualTo(Max_Miliseconds_Per_Challenge));
        }

        public void Test72()
        {
            throw new NotImplementedException();
            //var challenge = new Challenge99();
            //Assert.That(challenge.Solve(), Is.EqualTo(709));
            //Assert.That(challenge.GetElapsedMiliseconds, Is.LessThanOrEqualTo(Max_Miliseconds_Per_Challenge));
        }

        [Test]
        public void Test73()
        {
            var challenge = new Challenge73();
            Assert.That(challenge.Solve(), Is.EqualTo(7295372));
            Assert.That(challenge.GetElapsedMiliseconds, Is.LessThanOrEqualTo(Max_Miliseconds_Per_Challenge));
        }

        [Test]
        public void Test74()
        {
            var challenge = new Challenge74();
            Assert.That(challenge.Solve(), Is.EqualTo(402));
            Assert.That(challenge.GetElapsedMiliseconds, Is.LessThanOrEqualTo(Max_Miliseconds_Per_Challenge));
        }

        public void Test75()
        {
            throw new NotImplementedException();
            //var challenge = new Challenge99();
            //Assert.That(challenge.Solve(), Is.EqualTo(709));
            //Assert.That(challenge.GetElapsedMiliseconds, Is.LessThanOrEqualTo(Max_Miliseconds_Per_Challenge));
        }

        public void Test76()
        {
            throw new NotImplementedException();
            //var challenge = new Challenge99();
            //Assert.That(challenge.Solve(), Is.EqualTo(709));
            // Assert.That(challenge.GetElapsedMiliseconds, Is.LessThanOrEqualTo(Max_Miliseconds_Per_Challenge));
        }

        public void Test77()
        {
            throw new NotImplementedException();
            //var challenge = new Challenge99();
            //Assert.That(challenge.Solve(), Is.EqualTo(709));
            // Assert.That(challenge.GetElapsedMiliseconds, Is.LessThanOrEqualTo(Max_Miliseconds_Per_Challenge));
        }

        public void Test78()
        {
            throw new NotImplementedException();
            //var challenge = new Challenge99();
            //Assert.That(challenge.Solve(), Is.EqualTo(709));
            //Assert.That(challenge.GetElapsedMiliseconds, Is.LessThanOrEqualTo(Max_Miliseconds_Per_Challenge));
        }

        public void Test79()
        {
            throw new NotImplementedException();
            //var challenge = new Challenge99();
            //Assert.That(challenge.Solve(), Is.EqualTo(709));
            // Assert.That(challenge.GetElapsedMiliseconds, Is.LessThanOrEqualTo(Max_Miliseconds_Per_Challenge));
        }

        public void Test80()
        {
            throw new NotImplementedException();
            //var challenge = new Challenge99();
            //Assert.That(challenge.Solve(), Is.EqualTo(709));
            // Assert.That(challenge.GetElapsedMiliseconds, Is.LessThanOrEqualTo(Max_Miliseconds_Per_Challenge));
        }

        [Test]
        public void Test81()
        {
            var challenge1 = new Challenge81(false);
            var challenge2 = new Challenge81(true);

            var result1 = challenge1.Solve();
            var result2 = challenge2.Solve();

            Assert.That(result1, Is.EqualTo(2427));
            Assert.That(result2, Is.EqualTo(427337));
            Assert.That(challenge1.GetElapsedMiliseconds, Is.LessThanOrEqualTo(Max_Miliseconds_Per_Challenge));
            Assert.That(challenge2.GetElapsedMiliseconds, Is.LessThanOrEqualTo(Max_Miliseconds_Per_Challenge));
        }

        [Test]
        public void Test82()
        {
            var challenge = new Challenge82();
            Assert.That(challenge.Solve(), Is.EqualTo(260324));
            Assert.That(challenge.GetElapsedMiliseconds, Is.LessThanOrEqualTo(Max_Miliseconds_Per_Challenge));
        }

        [Test]
        public void Test83()
        {
            var challenge = new Challenge83();
            Assert.That(challenge.Solve(), Is.EqualTo(425185));
            Assert.That(challenge.GetElapsedMiliseconds, Is.LessThanOrEqualTo(Max_Miliseconds_Per_Challenge));
        }

        public void Test84()
        {
            throw new NotImplementedException();
            //var challenge = new Challenge99();
            //Assert.That(challenge.Solve(), Is.EqualTo(709));
            //  Assert.That(challenge.GetElapsedMiliseconds, Is.LessThanOrEqualTo(Max_Miliseconds_Per_Challenge));
        }

        public void Test85()
        {
            throw new NotImplementedException();
            //var challenge = new Challenge99();
            //Assert.That(challenge.Solve(), Is.EqualTo(709));
            //   Assert.That(challenge.GetElapsedMiliseconds, Is.LessThanOrEqualTo(Max_Miliseconds_Per_Challenge));
        }

        public void Test86()
        {
            throw new NotImplementedException();
            //var challenge = new Challenge99();
            //Assert.That(challenge.Solve(), Is.EqualTo(709));
            //   Assert.That(challenge.GetElapsedMiliseconds, Is.LessThanOrEqualTo(Max_Miliseconds_Per_Challenge));
        }

        public void Test87()
        {
            throw new NotImplementedException();
            //var challenge = new Challenge99();
            //Assert.That(challenge.Solve(), Is.EqualTo(709));
            //  Assert.That(challenge.GetElapsedMiliseconds, Is.LessThanOrEqualTo(Max_Miliseconds_Per_Challenge));
        }

        public void Test88()
        {
            throw new NotImplementedException();
            //var challenge = new Challenge99();
            //Assert.That(challenge.Solve(), Is.EqualTo(709));
            //  Assert.That(challenge.GetElapsedMiliseconds, Is.LessThanOrEqualTo(Max_Miliseconds_Per_Challenge));
        }

        [Test]
        public void Test89()
        {
            var challenge = new Challenge89();
            Assert.That(challenge.Solve(), Is.EqualTo(743));
            Assert.That(challenge.GetElapsedMiliseconds, Is.LessThanOrEqualTo(Max_Miliseconds_Per_Challenge));
        }

        public void Test90()
        {
            throw new NotImplementedException();
            //var challenge = new Challenge99();
            //Assert.That(challenge.Solve(), Is.EqualTo(709));
            //  Assert.That(challenge.GetElapsedMiliseconds, Is.LessThanOrEqualTo(Max_Miliseconds_Per_Challenge));
        }

        public void Test91()
        {
            throw new NotImplementedException();
            //var challenge = new Challenge99();
            //Assert.That(challenge.Solve(), Is.EqualTo(709));
            //   Assert.That(challenge.GetElapsedMiliseconds, Is.LessThanOrEqualTo(Max_Miliseconds_Per_Challenge));
        }

        [Test]
        public void Test92()
        {
            var challenge = new Challenge92();
            Assert.That(challenge.Solve(), Is.EqualTo(8581146));
            Assert.That(challenge.GetElapsedMiliseconds, Is.LessThanOrEqualTo(Max_Miliseconds_Per_Challenge));
        }

        public void Test93()
        {
            throw new NotImplementedException();
            //var challenge = new Challenge99();
            //Assert.That(challenge.Solve(), Is.EqualTo(709));
            //  Assert.That(challenge.GetElapsedMiliseconds, Is.LessThanOrEqualTo(Max_Miliseconds_Per_Challenge));
        }

        public void Test94()
        {
            throw new NotImplementedException();
            //var challenge = new Challenge99();
            //Assert.That(challenge.Solve(), Is.EqualTo(709));
            //   Assert.That(challenge.GetElapsedMiliseconds, Is.LessThanOrEqualTo(Max_Miliseconds_Per_Challenge));
        }

        [Test]
        public void Test95()
        {
            var challenge = new Challenge95();
            Assert.That(challenge.Solve(), Is.EqualTo(14316));
            Assert.That(challenge.GetElapsedMiliseconds, Is.LessThanOrEqualTo(Max_Miliseconds_Per_Challenge));
        }

        public void Test96()
        {
            throw new NotImplementedException();
            //var challenge = new Challenge99();
            //Assert.That(challenge.Solve(), Is.EqualTo(709));
            //   Assert.That(challenge.GetElapsedMiliseconds, Is.LessThanOrEqualTo(Max_Miliseconds_Per_Challenge));
        }

        [Test]
        public void Test97()
        {
            var challenge = new Challenge97();
            Assert.That(challenge.Solve(), Is.EqualTo("8739992577"));
            Assert.That(challenge.GetElapsedMiliseconds, Is.LessThanOrEqualTo(Max_Miliseconds_Per_Challenge));
        }

        public void Test98()
        {
            throw new NotImplementedException();
            //var challenge = new Challenge99();
            //Assert.That(challenge.Solve(), Is.EqualTo(709));
            //   Assert.That(challenge.GetElapsedMiliseconds, Is.LessThanOrEqualTo(Max_Miliseconds_Per_Challenge));
        }

        [Test]
        public void Test99()
        {
            var challenge = new Challenge99();
            Assert.That(challenge.Solve(), Is.EqualTo(709));
            Assert.That(challenge.GetElapsedMiliseconds, Is.LessThanOrEqualTo(Max_Miliseconds_Per_Challenge));
        }

        public void Test100()
        {
            throw new NotImplementedException();
            //var challenge = new Challenge99();
            //Assert.That(challenge.Solve(), Is.EqualTo(709));
            //  Assert.That(challenge.GetElapsedMiliseconds, Is.LessThanOrEqualTo(Max_Miliseconds_Per_Challenge));
        }
        
        [Test]
        public void Test124()
        {
            var challenge = new Challenge124();
            Assert.That(challenge.Solve(), Is.EqualTo(21417));
            Assert.That(challenge.GetElapsedMiliseconds, Is.LessThanOrEqualTo(Max_Miliseconds_Per_Challenge));
        }
    }
}