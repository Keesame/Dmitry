using System;


namespace Интерф_Калькулятора.СalculatorTwoVariables
{
    public class Multiply : СalculatorTwoVariables2
    {
        public double Calculate(double firstValue, double secondValue)
        {
            return firstValue * secondValue;
        }
    }
}