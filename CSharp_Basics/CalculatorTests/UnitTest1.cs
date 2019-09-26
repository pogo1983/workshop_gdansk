using NUnit.Framework;
using System;
using Calculator;


namespace CalculatorTests
{
    [TestFixture]
    public class UnitTest1
    {
        [Test]
        public void AddingOperation()
        {
            MathData mathData = new MathData(5,4,"/");
            var result = Calculations.DoMath(mathData);
            Assert.AreEqual(9, result);
        }
    }
}
