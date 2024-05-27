using Common.AdvancedMath.RomanNumbers;

namespace Testing
{
    [TestFixture]
    public class RomanNumbersTester
    {
        public RomanNumbersTester()
        {
        }
        
        
        [Test]
        public void TestNubmersCalc1()
        {
            Assert.That(RomanNumberCalculator.CalculateValue("IIII") == 4);
        }
        [Test]
        public void TestNubmersCalc2()
        {
            Assert.That(RomanNumberCalculator.CalculateValue("XVI") == 16);
        }
        [Test]
        public void TestNubmersCalc3()
        {
            Assert.That(RomanNumberCalculator.CalculateValue("XIIIIII") == 16);
         }
        [Test]
        public void TestNubmersCalc4()
        {
            Assert.That(RomanNumberCalculator.CalculateValue("IV") == 4);
        }
        [Test]
        public void TestNubmersCalc5()
        {
            Assert.That(RomanNumberCalculator.CalculateValue("IX") == 9);
        }
        [Test]
        public void TestNubmersCalc6()
        {
            Assert.That(RomanNumberCalculator.CalculateValue("XIX") == 19);
        }
        [Test]
        public void TestNubmersCalc7()
        {
            Assert.That(RomanNumberCalculator.CalculateValue("XIIIIIIIII") == 19);
        }
        
        [Test]
        public void TestNubmersMinimize()
        {
            Assert.That(RomanNumberCalculator.MinimizeSize("XIIIIIIIII"), Is.EqualTo("XIX"));
        }
        
        [Test]
        public void TestNubmersMinimize2()
        {
            Assert.That(RomanNumberCalculator.MinimizeSize("XXXXIIIIIIIII") == "XLIX");
        }
        
        [Test]
        public void TestNubmersMinimize3()
        {
            Assert.That(RomanNumberCalculator.MinimizeSize("XXXXVIIII") == "XLIX");
        }
        
        [Test]
        public void TestNubmersMinimize4()
        {
            Assert.That(RomanNumberCalculator.MinimizeSize("XXXXIX") == "XLIX");
        }
        
        [Test]
        public void TestNubmersMinimize5()
        {
            Assert.That(RomanNumberCalculator.MinimizeSize("XLIIIIIIIII") == "XLIX");
        }
        
        [Test]
        public void TestNubmersMinimize6()
        {
            Assert.That(RomanNumberCalculator.MinimizeSize("XLVIIII") == "XLIX");
        }
        
        [Test]
        public void TestNubmersMinimize7()
        {
            Assert.That(RomanNumberCalculator.MinimizeSize("MCCCCCCVI"), Is.EqualTo("MDCVI"));
        }
        
        [Test]
        public void TestNubmersMinimize8()
        {
            Assert.That(RomanNumberCalculator.MinimizeSize("DCCCC"), Is.EqualTo("CM"));
        }
    }
}