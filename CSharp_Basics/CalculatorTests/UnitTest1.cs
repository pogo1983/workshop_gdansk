using NUnit.Framework;
using System;
using Calculator;


namespace CalculatorTests
{
    [TestFixture]
    public class UnitTest1
    {
        [TestCase(1,4,5)]
        [TestCase(5, 5, 10)]
        public void AddingOperationPositiveValues(int a, int b, int x)
        {
            //Arrange   
            MathData mathData = new MathData(a,b,"+");
            //Act
            var result = Calculations.DoMath(mathData);
            //Assert
            Assert.AreEqual(x, result);
        }

        [Test]
        public void AddingOperationNegativeValues()
        {
            //Arrange   
            MathData mathData = new MathData(-5, -4, "+");
            //Act
            var result = Calculations.DoMath(mathData);
            //Assert
            Assert.AreEqual(-9, result);
        }

        [Test]
        public void AddingOperationMaxInt()
        {
            //Arrange   
            MathData mathData = new MathData(int.MaxValue,int.MinValue, "+");
            //Act
            var result = Calculations.DoMath(mathData);
            //Assert
            Assert.AreEqual(-1, result);
        }
        [Test]
        public void AddingOperationBigInt()
        {
            //Arrange   
            MathData mathData = new MathData(30000,35000, "+");
            //Act
            var result = Calculations.DoMath(mathData);
            //Assert
            Assert.AreEqual(65000, result);
        }
    }
}
