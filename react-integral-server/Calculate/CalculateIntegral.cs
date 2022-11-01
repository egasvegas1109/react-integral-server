using System;
namespace react_integral_server.Calculate
{
    public class CalculateIntegral
    {
        public double f(double x)
        {
            double res;
            res = Math.Pow(2, 3 * x);
            return res;
        }

        public double Calculate(double upperInt, double lowerInt, double stepInt)
        {
            double h = (upperInt-lowerInt)/stepInt;
            double s = 0;
            int i = 0;
                for (i = 0; i < stepInt; i++)
                {
                    s += h * f(lowerInt + h * i);
                }
            return s;
        }
    }
}

