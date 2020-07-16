using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Интерф_Калькулятора.OneArgClasses
{
    public class CtgCalculator : IOneArgCalculator
    {
        public double Calculate(double FirstNumber)
        {
            return (1.0 / Math.Tan(FirstNumber * Math.PI / 180));
        }
    }
}
