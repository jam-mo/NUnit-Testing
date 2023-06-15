using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace MyTestProject
{
    [TestFixture]
    class AreasTest
    {
        [Test]
        public void calculateCircleAreaWithRadiusTest()
            //test case for circle area function, to ensure it works as intended
        {
            Circle circle = new Circle();
            double rad = 4.0;
            double expectedValue = 50.27;
            double actualValue = circle.Area(rad);
            Assert.AreEqual(expectedValue, actualValue);
        }
        [Test]
        public void calculateCircleAreaWithRadiusTestForFailure()
        { // test case for circle area, intentionally incorrect
            Circle circle = new Circle();
            double rad = 4.0;
            double expectedValue = 46.29;
            double actualValue = circle.Area(rad);
            Assert.AreEqual(expectedValue, actualValue);
        }


        [Test]
        public void calculateCirclePerimeterWithRadiusTest()
        { //  test case for circle to ensure it works as intended
            Circle circle = new Circle();
            double rad = 4.0;
            double expectedValue = 25.13;
            double actualValue = circle.Perimeter(rad);
            Assert.AreEqual(expectedValue, actualValue);
        }
        [Test]
        public void calculateCirclePerimeterWithRadiusTestForFailure()
        { // test case for failure for circle perimeter
            Circle circle = new Circle();
            double rad = 4.0;
            double expectedValue = 35.13;
            double actualValue = circle.Perimeter(rad);
            Assert.AreEqual(expectedValue, actualValue);
        }
        [Test]
        public void calculateRectangleAreaTest()
        { // test case for calculating rectangles area
            Rectangle rectangle = new Rectangle();
            double h = 3.0;
            double w = 6.0;
            double expectedValue = 18.0;
            double actualValue = rectangle.Area(h, w);
            Assert.AreEqual(expectedValue, actualValue);
        }
        [Test]
        public void calculateRectangleAreaTestForFailure()
        { // test case for calculating failure with wrong input
            Rectangle rectangle = new Rectangle();
            double h = 3.0;
            double w = 6.0;
            double expectedValue = 21.0;
            double actualValue = rectangle.Area(h, w);
            Assert.AreEqual(expectedValue, actualValue);
        }
        [Test]
        public void calculateRectanglePerimeterTest()
        {// test case to calculate perimeter of rectangle works as intended
            Rectangle rectangle = new Rectangle();
            double h = 3.0;
            double w = 6.0;
            double expectedValue = 18.0;
            double actualValue = rectangle.Perimeter(h, w);
            Assert.AreEqual(expectedValue, actualValue);
        }
        [Test]
        public void calculateRectanglePerimeterTestForFailure()
        { // failure testcase for rectangle perimeter
            Rectangle rectangle = new Rectangle();
            double h = 3.0;
            double w = 6.0;
            double expectedValue = 36.0;
            double actualValue = rectangle.Perimeter(h, w);
            Assert.AreEqual(expectedValue, actualValue);
        }
        [Test]
        public void calculateTriangleAreaTest()
        { // test case for calculating area of triangle
            Triangle triangle = new Triangle();
            double a = 3;
            double b = 4;
            double c = 5;
            double expectedValue = 6.0;
            double actualValue = triangle.Area(a, b, c);
            Assert.AreEqual(expectedValue, actualValue);
        }
        [Test]
        public void calculateTriangleAreaTestForFailure()
        { // failure test case for triangle area
            Triangle triangle = new Triangle();
            double a = 3;
            double b = 4;
            double c = 5;
            double expectedValue = 7.0;
            double actualValue = triangle.Area(a, b, c);
            Assert.AreEqual(expectedValue, actualValue);
        }
        [Test]
        public void calculateTrianglePerimeterTest() 
        { // test case for calculating a triangles perimeter
            Triangle triangle = new Triangle();
            double a = 3;
            double b = 4;
            double c = 5;
            double expectedValue = 12.0;
            double actualValue = triangle.Perimeter(a, b, c);
            Assert.AreEqual(expectedValue, actualValue);
        }
        [Test]
        public void calculateTrianglePerimeterTestForFailure()
        { // failure test case for triangle perimeter
            Triangle triangle = new Triangle();
            double a = 3;
            double b = 4;
            double c = 5;
            double expectedValue = 14.0;
            double actualValue = triangle.Perimeter(a, b, c);
            Assert.AreEqual(expectedValue, actualValue);
        }
    }
}
