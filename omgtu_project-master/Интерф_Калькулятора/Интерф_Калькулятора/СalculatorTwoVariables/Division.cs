

using System.Windows.Forms;

namespace Интерф_Калькулятора.СalculatorTwoVariables
{
    public class Division : СalculatorTwoVariables2
    {
        public double Calculate(double firstValue, double secondValue)
        {
            if (secondValue == 0)
            {
                MessageBox.Show("На ноль делить нельзя!");
                return 0;
            }
            return firstValue / secondValue;
        }
    }
}
