using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Интерф_Калькулятора.OneArgClasses
{
    public static class OneArgFactory
    {
        public static IOneArgCalculator CreateCalculator(string oper)
        {
            switch (oper)
            {
                case ("sin"): 
                    return new SinCalculator();
                case ("cos"): 
                    return new CosCalculator();
                case ("tg"): 
                    return new TgCalculator();
                case ("ctg"): 
                    return new CtgCalculator();
                case ("pow2"):
                    return new Pow2Calculator();
            }
            return null;
        }
    }
}
