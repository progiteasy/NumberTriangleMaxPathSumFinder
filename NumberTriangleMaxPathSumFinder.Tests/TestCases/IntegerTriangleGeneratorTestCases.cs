using NumberTriangleMaxPathSumFinder.Utilities;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;

namespace NumberTriangleMaxPathSumFinder.Tests.TestCases
{
    [TestFixture]
    public class IntegerTriangleGeneratorTestCases
    {
        [Test]
        public void TC1_WhenPassHeightNegativeValueToGenerateRandomlyMethod_ShouldGenerateArgumentException()
        {
            var triangleGenerator = new IntegerTriangleGenerator();
            var triangleHeight = -1;
            var randomGeneratorRange = ValueTuple.Create(-99, 100);

            Assert.Throws<ArgumentException>(() => triangleGenerator.GenerateRandomly(triangleHeight, randomGeneratorRange));
        }

        [Test]
        public void TC2_WhenPassRandomGeneratorRangeInvalidValueToGenerateRandomlyMethod_ShouldGenerateArgumentException()
        {
            var triangleGenerator = new IntegerTriangleGenerator();
            var triangleHeight = 3;
            var randomGeneratorRange = ValueTuple.Create(10, 1);

            Assert.Throws<ArgumentException>(() => triangleGenerator.GenerateRandomly(triangleHeight, randomGeneratorRange));
        }

        [Test]
        public void TC3_WhenCallGenerateRandomlyMethod_ShouldReturnValidIntegerTriangleObject()
        {
            var triangleGenerator = new IntegerTriangleGenerator();
            var triangleHeight = 3;
            var randomGeneratorRange = ValueTuple.Create(-10, 11);
            var triangle = triangleGenerator.GenerateRandomly(triangleHeight, randomGeneratorRange);
            var triangleNumbers = new List<int>();

            for (var i = 0; i < triangle.Height; i++)
                for (var j = 0; j < triangle[i].Length; j++)
                    triangleNumbers.Add(triangle[i][j]);

            Assert.AreEqual(triangle.Height, triangleHeight);
            Assert.IsTrue(triangleNumbers.All(triangleNumber => triangleNumber >= randomGeneratorRange.Item1 && triangleNumber < randomGeneratorRange.Item2));
        }
    }
}
