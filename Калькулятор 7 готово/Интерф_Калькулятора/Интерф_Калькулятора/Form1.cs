using System;
using System.Windows.Forms;
using Интерф_Калькулятора.СalculatorTwoVariables;
using Интерф_Калькулятора.OneArgClasses;

namespace Интерф_Калькулятора
{

    public partial class Form1 : Form
    {
        double firstNumber, secondNumber, result;
        string Nametion, na1;
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }
        // clear result1 after input


        /// <summary>
        /// Fill textBox after input firstNumber and save First Number
        /// </summary>
        void name1()
        {
            if (result1.Text.Length > 0)
            {
                onenumber2.Text = result1.Text;
                firstNumber = Convert.ToDouble(result1.Text);
                twonumber3.Text = null;
            }
            result1.Text = null;
            result1.Focus();

            switch (Nametion)
            {
                case ("multiplication"):
                    na1 = "*";
                    break;
                case ("division"):
                    na1 = "/";
                    break;
                case ("plus"):
                    na1 = "+";
                    break;
                case ("minuse"):
                    na1 = "-";
                    break;
            }
            comboBox4.Text = na1;
        }
        /// <summary>
        /// frequently used operations were separated in function
        /// </summary>
        void def1()
        {
            result1.Text = Convert.ToString(result);
            firstNumber = result;
            result1.Focus();
            result1.SelectionStart = result1.Text.Length;

        }
        void def2()
        {
            IOneArgCalculator calculator = OneArgFactory.CreateCalculator(Nametion);
            result = calculator.Calculate(firstNumber);
            onenumber2.Text = result1.Text;
            result1.Text = Convert.ToString(result);
            comboBox4.Text = Nametion;

        }
        /// <summary>
        /// processing choose operation and function
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void operChoose(object sender, EventArgs e) // two args
        {
            Nametion = ((Button)sender).Name;
            name1();
        }
        private void funcChoose(object sender, EventArgs e) // one args
        {
            firstNumber = Convert.ToDouble(result1.Text);
            Nametion = ((Button)sender).Name;
            def2();
        }

        // Write result in result1 and make the result the first number to continue calculations

        private void dot_Click(object sender, EventArgs e)
        {
            result1.Text = result1.Text + ",";
        }

        private void delete_Button(object sender, EventArgs e)
        {
            if (result1.Text.Length == 0)
            {
                result1.Text = null;
                result1.Focus();
            }
            else
                result1.Text = result1.Text.Remove(result1.Text.Length - 1, 1);
        }

        private void clearResult(object sender, EventArgs e)
        {
            onenumber2.Text = "";
            twonumber3.Text = "";
            result1.Text = "";
            comboBox4.Text = "";
        }
        /// <summary>
        ///  processing a click on "equal" button where is the main choice of further operations and functions
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void equally_Click(object sender, EventArgs e)
        {
            if (result1.Text.Length > 0) // textBox is not empty
            {
                secondNumber = Convert.ToDouble(result1.Text);
                twonumber3.Text = result1.Text;
                СalculatorTwoVariables2 calculator = FactoryTwoArguments.CreateCalculator(Nametion);
                result = calculator.Calculate(firstNumber, secondNumber);
                def1();
            }
            result1.Focus();
        }
        /// <summary>
        /// Processing clicks on buttons
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttALL2(object sender, EventArgs e)
        {
            switch (((Button)sender).Name)
            {
                case "button10":
                    _ = ((result1.Text == "0") && (result1.Text != null)) ? (result1.Text = "0") : (result1.Text = result1.Text + "0");
                    break;
                case "button1":
                    _ = ((result1.Text == "0") && (result1.Text != null)) ? (result1.Text = "1") : (result1.Text = result1.Text + "1");
                    break;
                case "button2":
                    _ = ((result1.Text == "0") && (result1.Text != null)) ? (result1.Text = "2") : (result1.Text = result1.Text + "2");
                    break;
                case "button3":
                    _ = ((result1.Text == "0") && (result1.Text != null)) ? (result1.Text = "3") : (result1.Text = result1.Text + "3");
                    break;
                case "button4":
                    _ = ((result1.Text == "0") && (result1.Text != null)) ? (result1.Text = "4") : (result1.Text = result1.Text + "4");
                    break;
                case "button5":
                    _ = ((result1.Text == "0") && (result1.Text != null)) ? (result1.Text = "5") : (result1.Text = result1.Text + "5");
                    break;
                case "button6":
                    _ = ((result1.Text == "0") && (result1.Text != null)) ? (result1.Text = "6") : (result1.Text = result1.Text + "6");
                    break;
                case "button7":
                    _ = ((result1.Text == "0") && (result1.Text != null)) ? (result1.Text = "7") : (result1.Text = result1.Text + "7");
                    break;
                case "button8":
                    _ = ((result1.Text == "0") && (result1.Text != null)) ? (result1.Text = "8") : (result1.Text = result1.Text + "8");
                    break;
                case "button9":
                    _ = ((result1.Text == "0") && (result1.Text != null)) ? (result1.Text = "9") : (result1.Text = result1.Text + "9");
                    break;
            }
            result1.Focus();
            result1.SelectionStart = result1.Text.Length;
        }
        // support input from keyboard
        /// <summary>
        /// mention of the main operations in the text cause them by this function
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void result1_TextChanged(object sender, EventArgs e)
        {
            if (result1.Text.Length >= 1)
            {
                string a = Convert.ToString(result1.Text[result1.Text.Length - 1]);
                switch (a)
                {
                    case ("*"):
                        result1.Text = result1.Text.Remove(result1.Text.Length - 1, 1);
                        operChoose(multiplication, e);
                        break;
                    case ("/"):
                        result1.Text = result1.Text.Remove(result1.Text.Length - 1, 1);
                        operChoose(division, e);
                        break;
                    case ("+"):
                        result1.Text = result1.Text.Remove(result1.Text.Length - 1, 1);
                        operChoose(plus, e);
                        break;
                }
                if (a == "*" || a == "/" || a == "+" || a == "-")
                { }
                else
                {
                    if (!Char.IsDigit(Convert.ToChar(result1.Text[result1.Text.Length - 1])))
                    {
                        result1.Text = result1.Text.Remove(result1.Text.Length - 1, 1);
                        result1.SelectionStart = result1.Text.Length;
                    }
                }
            }
        }
    }
}