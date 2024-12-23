﻿using System.Diagnostics;
using ChallengeExecutor.Challenges.Challenges1To50.Challenge26;
using Common.AdvancedMath;

namespace Testing
{
    public class BigDecimalTests
    {
        [SetUp]
        public void Setup()
        {
        }


        [Test]
        public void A00_TestStringConversion()
        {
            var a = new BigDecimal(1, 0, 0, 1000);
            string aString = a.Value;
            Assert.That(aString, Is.EqualTo("1,0"));

            a = new BigDecimal(1, 1, 0, 1000);
            aString = a.Value;
            Assert.That(aString, Is.EqualTo("1,1"));

            a = new BigDecimal(1, 1, 3, 1000);
            aString = a.Value;
            Assert.That(aString, Is.EqualTo("1,0001"));
        }

        [Test()]
        public void A01_TestEqual()
        {
            var a = new BigDecimal(1, 0, 0, 1000);
            var b = new BigDecimal(1, 0, 0, 1000);
            Assert.That(a, Is.EqualTo(b));

            var a1 = new BigDecimal(5, 0, 0, 1000);
            var b1 = new BigDecimal(6, 0, 0, 1000);
            Assert.That(a1 != b1);

            var a2 = new BigDecimal(1, 15, 0, 1000);
            var b2 = new BigDecimal(1, 0, 0, 1000);
            Assert.That(a2 != b2);

            var a3 = new BigDecimal(1, 0, 0, 1000);
            var b3 = new BigDecimal(1, 15, 0, 1000);
            Assert.That(a3 != b3);

            var a4 = new BigDecimal(2, 15, 0, 1000);
            var b4 = new BigDecimal(1, 15, 0, 1000);
            Assert.That(a4 != b4);

            var a5 = new BigDecimal(21, 3, 1, 1000);
            var b5 = new BigDecimal(21, 3, 0, 1000);
            Assert.That(a5 != b5);

            var a6 = new BigDecimal(2, 3, 0, 1000);
            var b6 = new BigDecimal(2, 3, 1, 1000);
            Assert.That(a6 != b6);

            var a7 = new BigDecimal(1, 100000, 0, 1000);
            var b7 = new BigDecimal(1, 10, 0, 1000);
            Assert.That(a7, Is.EqualTo(b7));

            var a8 = new BigDecimal(1, 1, 0, 1000);
            var b8 = new BigDecimal(1, 10, 0, 1000);
            Assert.That(a7, Is.EqualTo(b8));

            var a9 = new BigDecimal(1, 1, 1, 1000);
            var b9 = new BigDecimal(1, 1000, 1, 1000);
            Assert.That(a9, Is.EqualTo(b9));
        }

        [Test]
        public void A02_TestBiggerThen()
        {
            var a1 = new BigDecimal(5, 0, 0, 1000);
            var b1 = new BigDecimal(6, 0, 0, 1000);
            Assert.That(a1 < b1);

            var a2 = new BigDecimal(5, 0, 0, 1000);
            var b2 = new BigDecimal(5, 15, 0, 1000);
            Assert.That(a1 < b1);

            var a3 = new BigDecimal(5, 15, 1, 1000);
            var b3 = new BigDecimal(5, 15, 0, 1000);
            Assert.That(a3 < b3);
        }

        [Test]
        public void A03_TestSmallerThen()
        {
            var a1 = new BigDecimal(6, 0, 0, 1000);
            var b1 = new BigDecimal(5, 0, 0, 1000);
            Assert.That(a1 > b1);

            var a2 = new BigDecimal(5, 15, 0, 1000);
            var b2 = new BigDecimal(5, 0, 0, 1000);
            Assert.That(a1 > b1);

            var a3 = new BigDecimal(5, 15, 0, 1000);
            var b3 = new BigDecimal(5, 15, 1, 1000);
            Assert.That(a3 > b3);
        }

        [Test]
        public void B01_TestAddition()
        {
            var a1 = new BigDecimal(6, 0, 0, 1000);
            var b1 = new BigDecimal(5, 0, 0, 1000);
            var c1 = new BigDecimal(11, 0, 0, 1000);

            var sum1 = a1 + b1;
            Assert.That(sum1 == c1);

            var a2 = new BigDecimal(5, 123, 0, 1000);
            var b2 = new BigDecimal(5, 0, 0, 1000);
            var c2 = new BigDecimal(10, 123, 0, 1000);

            var sum2 = a2 + b2;
            Assert.That(sum2 == c2);

            var a3 = new BigDecimal(5, 0, 0, 1000);
            var b3 = new BigDecimal(5, 123, 0, 1000);
            var c3 = new BigDecimal(10, 123, 0, 1000);

            var sum3 = a3 + b3;
            Assert.That(sum3 == c3);

            var a4 = new BigDecimal(5, 123, 0, 1000);
            var b4 = new BigDecimal(5, 123, 0, 1000);
            var c4 = new BigDecimal(10, 246, 0, 1000);

            var sum4 = a4 + b4;
            Assert.That(sum4 == c4);

            var a5 = new BigDecimal(5, 1234, 0, 1000);
            var b5 = new BigDecimal(5, 123, 0, 1000);
            var c5 = new BigDecimal(10, 2464, 0, 1000);

            var sum5 = a5 + b5;
            Assert.That(sum5 == c5);

            var a6 = new BigDecimal(5, 123, 0, 1000);
            var b6 = new BigDecimal(5, 1234, 0, 1000);
            var c6 = new BigDecimal(10, 2464, 0, 1000);

            var sum6 = a6 + b6;
            Assert.That(sum6 == c6);

            var a7 = new BigDecimal(5, 5, 0, 1000);
            var b7 = new BigDecimal(5, 5, 0, 1000);
            var c7 = new BigDecimal(11, 0, 0, 1000);

            var sum7 = a7 + b7;
            Assert.That(sum7 == c7);

            var a8 = new BigDecimal(5, 56, 0, 1000);
            var b8 = new BigDecimal(5, 5, 0, 1000);
            var c8 = new BigDecimal(11, 6, 1, 1000);

            var sum8 = a8 + b8;
            Assert.That(sum8 == c8);

            var a9 = new BigDecimal(5, 56, 1, 1000);
            var b9 = new BigDecimal(5, 5, 1, 1000);
            var c9 = new BigDecimal(10, 106, 0, 1000);

            var sum9 = a9 + b9;
            Assert.That(sum9 == c9);

            var a10 = new BigDecimal(5, 123, 1, 1000);
            var b10 = new BigDecimal(5, 1234, 0, 1000);
            var c10 = new BigDecimal(10, 1357, 0, 1000);

            var sum10 = a10 + b10;
            Assert.That(sum10 == c10);

            var a11 = new BigDecimal(5, 1234, 0, 1000);
            var b11 = new BigDecimal(5, 123, 1, 1000);
            var c11 = new BigDecimal(10, 1357, 0, 1000);

            var sum11 = a11 + b11;
            Assert.That(sum11 == c11);

            var a12 = new BigDecimal(5, 1234, 1, 1000);
            var b12 = new BigDecimal(5, 123, 0, 1000);
            var c12 = new BigDecimal(10, 13534, 0, 1000);

            var sum12 = a12 + b12;
            Assert.That(sum12 == c12);

            var a13 = new BigDecimal(5, 5, 5, 1000);
            var b13 = new BigDecimal(5, 5, 4, 1000);
            var c13 = new BigDecimal(10, 55, 4, 1000);

            var sum13 = a13 + b13;
            Assert.That(sum13 == c13);

            var a14 = new BigDecimal(5, 5, 5, 1000);
            var b14 = new BigDecimal(5, 5, 3, 1000);
            var c14 = new BigDecimal(10, 505, 3, 1000);

            var sum14 = a14 + b14;
            Assert.That(sum14 == c14);

            var a15 = new BigDecimal(5, 19, 2, 1000);
            var b15 = new BigDecimal(4, 1, 3, 1000);
            var c15 = new BigDecimal(9, 2, 2, 1000);

            var sum15 = a15 + b15;
            Assert.That(sum15 == c15);

            var a16 = new BigDecimal(5, 99, 2, 1000);
            var b16 = new BigDecimal(4, 1, 3, 1000);
            var c16 = new BigDecimal(9, 1, 1, 1000);

            var sum16 = a16 + b16;
            Assert.That(sum16 == c16);
        }

        [Test]
        public void B02_TestAdditionTimeRequirement()
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            for (int i = 0; i < 1000; i++)
            {
                BigDecimal bigDecimal1 = new BigDecimal(5, 5, 5, 1000);
                BigDecimal bigDecimal2 = new BigDecimal(5, 5, 4, 1000);

                var bigDecimal3 = bigDecimal1 + bigDecimal2;
            }
            sw.Stop();

            Assert.That(sw.ElapsedMilliseconds < 120);
        }

        [Test]
        public void C01_TestSubstraction()
        {
            var a1 = new BigDecimal(6, 0, 0, 1000);
            var b1 = new BigDecimal(5, 0, 0, 1000);
            var c1 = new BigDecimal(1, 0, 0, 1000);

            var sum1 = a1 - b1;
            Assert.That(sum1 == c1);

            var a2 = new BigDecimal(5, 123, 0, 1000);
            var b2 = new BigDecimal(5, 0, 0, 1000);
            var c2 = new BigDecimal(0, 123, 0, 1000);

            var sum2 = a2 - b2;
            Assert.That(sum2 == c2);

            try
            {
                var a3 = new BigDecimal(5, 0, 0, 1000);
                var b3 = new BigDecimal(5, 123, 0, 1000);

                var sum3 = a3 - b3;
                Assert.Fail();
            }
            catch (Exception e)
            {
            }

            var a4 = new BigDecimal(5, 123, 0, 1000);
            var b4 = new BigDecimal(5, 123, 0, 1000);
            var c4 = new BigDecimal(0, 0, 0, 1000);

            var sum4 = a4 - b4;
            Assert.That(sum4 == c4);

            var a5 = new BigDecimal(5, 1234, 0, 1000);
            var b5 = new BigDecimal(5, 123, 0, 1000);
            var c5 = new BigDecimal(0, 4, 3, 1000);

            var sum5 = a5 - b5;
            Assert.That(sum5 == c5);

            try
            {
                var a6 = new BigDecimal(5, 123, 0, 1000);
                var b6 = new BigDecimal(5, 1234, 0, 1000);

                var sum6 = a6 - b6;
                Assert.Fail();
            }
            catch (Exception)
            {
            }

            var a8 = new BigDecimal(5, 56, 0, 1000);
            var b8 = new BigDecimal(5, 5, 0, 1000);
            var c8 = new BigDecimal(0, 6, 1, 1000);

            var sum8 = a8 - b8;
            Assert.That(sum8 == c8);

            var a9 = new BigDecimal(5, 56, 1, 1000);
            var b9 = new BigDecimal(5, 5, 1, 1000);
            var c9 = new BigDecimal(0, 6, 2, 1000);

            var sum9 = a9 - b9;
            Assert.That(sum9 == c9);

            try
            {
                var a10 = new BigDecimal(5, 123, 1, 1000);
                var b10 = new BigDecimal(5, 1234, 0, 1000);

                var sum10 = a10 - b10;
                Assert.Fail();
            }
            catch (Exception)
            {
            }

            try
            {
                var a19 = new BigDecimal(5, 123567788, 1, 1000);
                var b19 = new BigDecimal(5, 1234, 0, 1000);

                var sum19 = a19 - b19;
                Assert.Fail();
            }
            catch (Exception)
            {
            }

            var a11 = new BigDecimal(5, 1234, 0, 1000);
            var b11 = new BigDecimal(5, 123, 1, 1000);
            var c11 = new BigDecimal(0, 1111, 0, 1000);

            var sum11 = a11 - b11;
            Assert.That(sum11 == c11);

            try
            {
                var a123 = new BigDecimal(5, 1234, 1, 1000);
                var b123 = new BigDecimal(5, 123, 0, 1000);

                var sum123 = a123 - b123;
                Assert.Fail();
            }
            catch (Exception)
            {
            }

            var a12 = new BigDecimal(5, 0, 0, 1000);
            var b12 = new BigDecimal(3, 5, 0, 1000);
            var c12 = new BigDecimal(1, 5, 0, 1000);

            var sum12 = a12 - b12;
            Assert.That(sum12 == c12);

            var a13 = new BigDecimal(5, 0, 0, 1000);
            var b13 = new BigDecimal(3, 5, 1, 1000);
            var c13 = new BigDecimal(1, 95, 0, 1000);

            var sum13 = a13 - b13;
            Assert.That(sum13 == c13);

            var a14 = new BigDecimal(5, 1, 1, 1000);
            var b14 = new BigDecimal(3, 5, 5, 1000);
            var c14 = new BigDecimal(2, 9995, 2, 1000);

            var sum14 = a14 - b14;
            Assert.That(sum14 == c14);
        }

        [Test]
        public void C02_TestSubstractionTimeRequirement()
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            for (int i = 0; i < 1000; i++)
            {
                BigDecimal bigDecimal1 = new BigDecimal(5, 5, 5, 1000);
                BigDecimal bigDecimal2 = new BigDecimal(5, 5, 6, 1000);

                var bigDecimal3 = bigDecimal1 - bigDecimal2;
            }
            sw.Stop();

            Assert.That(sw.ElapsedMilliseconds < 120);
        }

        [Test]
        public void D01_TestMultiplication()
        {
            var a = new BigDecimal(5, 0, 0, 1000);
            var b = new BigDecimal(5, 0, 0, 1000);
            var c = new BigDecimal(25, 0, 0, 1000);

            var multiplication = a * b;
            Assert.That(multiplication == c);

            a = new BigDecimal(5, 5, 0, 1000);
            b = new BigDecimal(5, 5, 0, 1000);
            c = new BigDecimal(30, 25, 0, 1000);

            multiplication = a * b;
            Assert.That(multiplication == c);

            a = new BigDecimal(2, 5, 0, 1000);
            b = new BigDecimal(2, 0, 0, 1000);
            c = new BigDecimal(5, 0, 0, 1000);

            multiplication = a * b;
            Assert.That(multiplication == c);

            a = new BigDecimal(2, 55, 0, 1000);
            b = new BigDecimal(2, 0, 0, 1000);
            c = new BigDecimal(5, 1, 0, 1000);

            multiplication = a * b;
            Assert.That(multiplication == c);

            a = new BigDecimal(2, 5, 1, 1000);
            b = new BigDecimal(2, 0, 0, 1000);
            c = new BigDecimal(4, 1, 0, 1000);

            multiplication = a * b;
            Assert.That(multiplication == c);

            a = new BigDecimal(2, 123, 3, 1000);
            b = new BigDecimal(3, 1234, 5, 1000);
            c = new BigDecimal(6, 371468151782, 3, 1000);

            multiplication = a * b;
            Assert.That(multiplication == c);

            a = new BigDecimal(2, 123, 0, 1000);
            b = new BigDecimal(3, 1234, 5, 1000);
            c = new BigDecimal(6, 369002619782, 0, 1000);

            multiplication = a * b;
            Assert.That(multiplication == c);
        }

        [Test]
        public void D02_TestMultiplicationTimeRequirement()
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            for (int i = 0; i < 1000; i++)
            {
                BigDecimal bigDecimal1 = new BigDecimal(int.MaxValue, long.MaxValue, 5, 1000);
                BigDecimal bigDecimal2 = new BigDecimal(long.MaxValue, int.MaxValue, 4, 1000);

                var bigDecimal3 = bigDecimal1 * bigDecimal2;
            }
            sw.Stop();

            Assert.That(sw.ElapsedMilliseconds < 120);
        }

        [Test]
        public void E01_TestDivision()
        {
            var a = new BigDecimal(5, 0, 0, 1000);
            var b = new BigDecimal(5, 0, 0, 1000);
            var c = new BigDecimal(1, 0, 0, 1000);

            var division = a / b;
            Assert.That(division == c);

            a = new BigDecimal(5, 0, 0, 1000);
            b = new BigDecimal(2, 0, 0, 1000);
            c = new BigDecimal(2, 5, 0, 1000);

            division = a / b;
            Assert.That(division == c);

            a = new BigDecimal(50, 5, 0, 1000);
            b = new BigDecimal(2, 0, 0, 1000);
            c = new BigDecimal(25, 25, 0, 1000);

            division = a / b;
            Assert.That(division == c);
            
            a = new BigDecimal(10, 5, 0, 1000);
            b = new BigDecimal(2, 0, 0, 1000);
            c = new BigDecimal(5, 25, 0, 1000);

            division = a / b;
            Assert.That(division == c);

            a = new BigDecimal(5, 0, 0, 1000);
            b = new BigDecimal(2, 55, 0, 1000);
            c = new BigDecimal(1, 96088431372549, 0, 1000);
            var d = new BigDecimal(1, 96078431372549, 0, 1000);

            division = a / b;
            Assert.That(division > d);
            Assert.That(division < c);

            a = new BigDecimal(7, 0, 0, 1000);
            b = new BigDecimal(3, 0, 0, 1000);

            c = new BigDecimal(2, 3334, 0, 1000);
            d = new BigDecimal(2, 3332, 0, 1000);

            division = a / b;
            Assert.That(division > d);
            Assert.That(division < c);

            a = new BigDecimal(5, 3, 2, 1000);
            b = new BigDecimal(2, 0, 0, 1000);
            c = new BigDecimal(2, 5015, 0, 1000);

            division = a / b;
            Assert.That(division == c);

            a = new BigDecimal(5, 3, 2, 1000);
            b = new BigDecimal(2, 3, 3, 1000);
            c = new BigDecimal(2, 50112483127531, 0, 1000);
            d = new BigDecimal(2, 50112483127530, 0, 1000);

            division = a / b;
            Assert.That(division > d);
            Assert.That(division < c);

            a = new BigDecimal(6, 3, 2, 1000);
            b = new BigDecimal(2, 0, 0, 1000);
            c = new BigDecimal(3, 15, 2, 1000);

            division = a / b;
            Assert.That(division == c);

            a = new BigDecimal(6, 3, 2, 1000);
            b = new BigDecimal(2, 4, 3, 1000);
            c = new BigDecimal(3, 899820035994, 3, 1000);
            d = new BigDecimal(3, 899820035992, 3, 1000);


            division = a / b;
            int count = division.ToString().Length;
            Assert.That(division > d);
            Assert.That(division < c);

            a = new BigDecimal(4, 0, 0, 1000);
            b = new BigDecimal(8, 0, 0, 1000);
            c = new BigDecimal(0, 5, 0, 1000);

            division = a / b;
            Assert.That(division == c);

            a = new BigDecimal(4, 2, 0, 1000);
            b = new BigDecimal(8, 0, 0, 1000);
            c = new BigDecimal(0, 525, 0, 1000);

            division = a / b;
            Assert.That(division == c);

            a = new BigDecimal(0, 5, 0, 1000);
            b = new BigDecimal(0, 25, 0, 1000);
            c = new BigDecimal(2, 0, 0, 1000);

            division = a / b;
            Assert.That(division == c);

            a = new BigDecimal(1, 0, 0, 1000);
            b = new BigDecimal(2000, 0, 0, 1000);
            c = new BigDecimal(0, 5, 3, 1000);

            division = a / b;
            Assert.That(division == c);

            a = new BigDecimal(2, 0, 0, 1000);
            b = new BigDecimal(16, 0, 0, 1000);
            c = new BigDecimal(0, 125, 0, 1000);

            division = a / b;
            Assert.That(division == c);

            a = new BigDecimal(2, 15, 0, 1000);
            b = new BigDecimal(16, 0, 0, 1000);
            c = new BigDecimal(0, 134375, 0, 1000);

            division = a / b;
            Assert.That(division == c);

            a = new BigDecimal(2, 15, 2, 1000);
            b = new BigDecimal(16, 0, 0, 1000);
            c = new BigDecimal(0, 12509375, 0, 1000);

            division = a / b;
            Assert.That(division == c);

            a = new BigDecimal(2, 15, 1, 1000);
            b = new BigDecimal(32, 0, 0, 1000);
            c = new BigDecimal(0, 6296875, 1, 1000);

            division = a / b;
            Assert.That(division == c);

            a = new BigDecimal(2, 0, 0, 1000);
            b = new BigDecimal(1000, 0, 0, 1000);
            c = new BigDecimal(0, 2, 2, 1000);

            division = a / b;
            Assert.That(division == c);
        }

        [Test]
        public void E02_TestDivisionTimeRequirement()
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            for (int i = 0; i < 1000; i++)
            {
                BigDecimal bigDecimal1 = new BigDecimal(int.MaxValue, long.MaxValue, 5, 1000);
                BigDecimal bigDecimal2 = new BigDecimal(long.MaxValue, int.MaxValue, 4, 1000);

                var bigDecimal3 = bigDecimal1 / bigDecimal2;
            }
            sw.Stop();

            Assert.That(sw.ElapsedMilliseconds < 500);
        }


        [Test]
        public void F02_TestChallengeUsingBigDecimal()
        {
            var challenge = new Challenge26WithBigDecimal();
            var result = challenge.Solve();

            Assert.That(result, Is.EqualTo(983));
        }
    }
}