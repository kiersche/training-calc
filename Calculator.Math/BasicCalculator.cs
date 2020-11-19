using System;

namespace Calculator.Math
{
    public class BasicCalculator
    {
        public double Calculate(double x, double y, BasicOperation operation)
        {
            if (operation == BasicOperation.Add)
            {
                return x + y;
            }

            throw new NotImplementedException();
        }
    }
}
