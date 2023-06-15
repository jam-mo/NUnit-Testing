using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace MyTestProject
{
    [TestFixture]
    class CalcTest
    {
        [Test]
        public void AddTwoNumbersReturnSumTest()
            // method to test if the function returns the expected value
        {
            Calc c = new Calc();
            double x = 4.0;
            double y = 5.0;
            double expectedValue = 9.0;
            double actualValue = c.Add(x, y);
            Assert.AreEqual(expectedValue, actualValue);
        }
        [Test]
        public void AddTwoNumbersToFailTest()
        { // test function intened to fail, to ensure
            Calc c = new Calc();
            double x = 4.0;
            double y = 5.0;
            double expectedValue = 10.0;
            double actualValue = c.Add(x, y);
            Assert.AreEqual(expectedValue, actualValue);
        }
        [Test]
        public void SubtractTwoNumbersAndReturnSum()
        {// test function to check if sum returns is correct
            Calc c = new Calc();
            double i = 8.0;
            double j = 4.0;
            double expectedValue = 4.0;
            double actualValue = c.Subtract(i, j);
            Assert.AreEqual(expectedValue, actualValue);
        }
        [Test]
        public void SubtractTwoNumbersAndFailTEST()
        { // test function intends to fail for subtract function
            Calc c = new Calc();
            double i = 8.0;
            double j = 4.0;
            double expectedValue = 6.0;
            double actualValue = c.Subtract(i, j);
            Assert.AreEqual(expectedValue, actualValue);
        }
    }
}
