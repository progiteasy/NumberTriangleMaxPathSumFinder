using NumberTriangleMaxPathSumFinder.Utilities;
using System;
using System.Linq;

namespace NumberTriangleMaxPathSumFinder
{
    public class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                if (args.Length != 1)
                    throw new ArgumentException("The wrong number of arguments was passed: only 1 argument can be passed - the height of the number triangle");
                if (!Int32.TryParse(args.First(), out var triangleHeight))
                    throw new ArgumentException("The passed argument has an incorrect data type: the value must be a positive integer");

                var triangleGenerator = new IntegerTriangleGenerator();
                var triangle = triangleGenerator.GenerateRandomly(triangleHeight, (-99, 100));
                var triangleMaxPathSum = triangle.CalculateMaxPathSum();

                Console.WriteLine($"The height of the generated number triangle is {triangle.Height}");
                Console.Write($"{triangle}");
                Console.WriteLine($"The maximum path sum of the triangle: {triangleMaxPathSum}");
            }
            catch (Exception exception)
            {
                Console.WriteLine($"{exception.Message}!");
            }
            finally
            {
                Console.ReadKey(true);
            }
        }
    }
}
