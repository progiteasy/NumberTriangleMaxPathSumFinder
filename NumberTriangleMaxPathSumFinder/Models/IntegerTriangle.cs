using ConsoleTableExt;
using System;
using System.Linq;

namespace NumberTriangleMaxPathSumFinder.Models
{
    public class IntegerTriangle
    {
        private readonly int[][] _numbers;

        public IntegerTriangle(int height)
        {
            if (height <= 0)
                throw new ArgumentException($"Invalid value for the '{nameof(height)}' parameter: the value must be greater than 0");
            
            _numbers = Enumerable.Range(1, height).Select(length => new int[length]).ToArray();
        }

        public long CalculateMaxPathSum()
        {
            var pathSums = _numbers.Last().Select(number => Convert.ToInt64(number)).ToArray();
            
            for (var i = _numbers.Length - 2; i >= 0; i--)
                for (var j = 0; j <= i; j++)
                    pathSums[j] = Math.Max(pathSums[j], pathSums[j + 1]) + _numbers[i][j];

            return pathSums.First();
        }

        public override string ToString()
        {
            var triangleTable = Enumerable.Range(1, _numbers.Length).
                Select(row => Enumerable.Repeat((object)String.Empty, 2 * _numbers.Last().Length - 1).ToList()).ToList();

            for (var i = 0; i < _numbers.Length; i++)
                for (var (j, n) = (0, _numbers.Length - i - 1); j < _numbers[i].Length; j++, n += 2)
                    triangleTable[i][n] = _numbers[i][j].ToString();
     
            return ConsoleTableBuilder.From(triangleTable).WithFormat(ConsoleTableBuilderFormat.Minimal).Export().ToString();
        }

        public int[] this[int index]
        {
            get => _numbers[index];
            set => _numbers[index] = value;
        }

        public int Height => _numbers.Length;
    }
}
