using System;
using Xunit;

namespace Calculator.Math.Test
{
    public class BasicCalculatorTest
    {
        [Fact]
        public void CanAdd()
        {
            const double x = 3.5d;
            const double y = 2.5d;

            var calculator = new BasicCalculator();
            double result = calculator.Calculate(x, y, BasicOperation.Add);

            Assert.Equal(6.0d, result);
        }
    }
}
