using System;
using Интерф_Калькулятора;

namespace Интерф_Калькулятора.СalculatorTwoVariables
 {
    public static class FactoryTwoArguments
    {
        public static СalculatorTwoVariables2 CreateCalculator(string name)
        {
            switch (name)
            {
                case "plus":
                    //   СalculatorTwoVariables calculator = new Addition();
                    return new Addition();
                //break;
                case "minuse":
                    return new Subtraction();
                //break;
                case "multiplication":
                    return new Multiply();
                //break;
                case "division":
                    return new Division();
                //break;
                default: throw new Exception("Ошибка!");
            }
        }
    }
}