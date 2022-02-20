using NumberTriangleMaxPathSumFinder.Models;
using System;

namespace NumberTriangleMaxPathSumFinder.Utilities
{
    public class IntegerTriangleGenerator
    {
        public IntegerTriangleGenerator() { }

        public IntegerTriangle GenerateRandomly(int height, (int MinValue, int MaxValue) randomGeneratorRange)
        {
            if (height <= 0)
                throw new ArgumentException($"Invalid value for the '{nameof(height)}' parameter: the value must be greater than 0");
            if (randomGeneratorRange.MinValue > randomGeneratorRange.MaxValue)
                throw new ArgumentException($"Invalid value for the '{nameof(randomGeneratorRange)}' parameter: MinValue must be greater or equal to MaxValue");

            var triangle = new IntegerTriangle(height);
            var randomGenerator = new Random();

            for (var i = 0; i < triangle.Height; i++)
                for (var j = 0; j < triangle[i].Length; j++)
                    triangle[i][j] = randomGenerator.Next(randomGeneratorRange.MinValue, randomGeneratorRange.MaxValue);

            return triangle;
        }
    }
}
