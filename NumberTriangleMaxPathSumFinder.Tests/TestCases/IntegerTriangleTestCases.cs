using NumberTriangleMaxPathSumFinder.Models;
using NUnit.Framework;
using System;

namespace NumberTriangleMaxPathSumFinder.Tests.TestCases
{
    [TestFixture]
    public class IntegerTriangleTestCases
    {
        [Test]
        public void TC1_WhenPassHeightNegativeValueToConstructor_ShouldGenerateArgumentException()
        {
            var triangleHeight = -1;

            Assert.Throws<ArgumentException>(() => new IntegerTriangle(triangleHeight));
        }

        [Test]
        public void TC2_WhenCallCalculateMaxPathSumMethod_ShouldReturn10()
        {
            var triangleHeight = 1;
            var triangle = new IntegerTriangle(triangleHeight);

            triangle[0][0] = 10;

            Assert.AreEqual(triangle.CalculateMaxPathSum(), 10);
        }

        [Test]
        public void TC3_WhenCallCalculateMaxPathSumMethod_ShouldReturn17()
        {
            var triangleHeight = 3;
            var triangle = new IntegerTriangle(triangleHeight);

            triangle[0][0] = 7;
            triangle[1][0] = -2;
            triangle[1][1] = 2;
            triangle[2][0] = 3;
            triangle[2][1] = 8;
            triangle[2][2] = 7;

            Assert.AreEqual(triangle.CalculateMaxPathSum(), 17);
        }

        [Test]
        public void TC4_WhenCallCalculateMaxPathSumMethod_ShouldReturnMinus70()
        {
            var triangleHeight = 3;
            var triangle = new IntegerTriangle(triangleHeight);

            triangle[0][0] = -10;
            triangle[1][0] = -20;
            triangle[1][1] = -30;
            triangle[2][0] = -50;
            triangle[2][1] = -40;
            triangle[2][2] = -50;

            Assert.AreEqual(triangle.CalculateMaxPathSum(), -70);
        }
    }
}
