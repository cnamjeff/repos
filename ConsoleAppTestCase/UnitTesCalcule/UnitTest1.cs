using System;
using NUnit.Framework;

namespace UnitTesCalcule
{
    [TestFixture]
    public class UnitTest1
    {
        [Test]
        public void TestMethod1()
        {
        }

        Calcule _calcule;
        [SetUp]
        public void Initialisation()
        {
            _calcule = new Calcule();
        }


        [Test]
        [TestCase(2, 5, 7)]
        [TestCase(20, 5, 25)]
        [TestCase(15, 10, 25)]
        public void add(int value1, int value2, int valueAttendu)
        {
            var result = _calcule.Addition(value1, value2);
            Assert.AreEqual(result, valueAttendu);
        }

        [Test]
        public void calculatorTest()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new Calcule().Addition(5, 55));
        }

    }
}
