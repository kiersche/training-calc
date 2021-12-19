using Xunit;

namespace Calculator.Math.Test
{
    public class BasicCalculatorTest
    {
        [Fact]
        public void CanAdd()
        {
            double d1 = 2.0d;
            double d2 = 2.5d;
            double expectedResult = 4.5d;

            BasicCalculator calculator = new BasicCalculator();
            double actualResult = calculator.Calculate(d1, d2, BasicOperation.Add);

            Assert.Equal(actualResult, expectedResult);
        }
    }
}
