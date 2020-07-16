using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Интерф_Калькулятора.OneArgClasses
{
    public class Pow2Calculator : IOneArgCalculator
    {
        public double Calculate(double FirstNumber)
        {
            return Math.Pow(2, FirstNumber);
        }
    }
}