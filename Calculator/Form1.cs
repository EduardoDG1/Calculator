using System;
using System.CodeDom;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;


namespace Calculator
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        double result;
        double result2;
        bool erase = false;

        private void btn0_Click(object sender, EventArgs e)
        {
            if (label.Text == "Cannot divide by zero")
            {
                label.Text = btn0.Text;
                operationTextBox.Text = string.Empty;
                label.TextAlign = ContentAlignment.BottomRight;
            }
            else if (label.Text != "0" && label.Text.Length < 16)
            {
                if (label.Text == result2.ToString())
                {
                    operationTextBox.Text = string.Empty;
                    label.Text = btn0.Text;
                }
                else
                {
                    label.Text += btn0.Text;
                }
            }

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (label.Text == "Cannot divide by zero")
            {
                label.Text = btn1.Text;
                operationTextBox.Text = string.Empty;
                label.TextAlign = ContentAlignment.BottomRight;
            }
            else if (label.Text == "0")
            {
                if (erase == true)
                {
                    operationTextBox.Text = string.Empty;
                    label.Text = btn1.Text;
                }
                else
                {
                    label.Text = btn1.Text;
                }
            }
            else if (label.Text.Length < 16)
            {
                if (label.Text == result2.ToString())
                {
                    operationTextBox.Text = string.Empty;
                    label.Text = btn1.Text;
                }
                else
                {

                    label.Text += btn1.Text;

                }
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (label.Text == "Cannot divide by zero")
            {
                label.Text = btn2.Text;
                operationTextBox.Text = string.Empty;
                label.TextAlign = ContentAlignment.BottomRight;
            }
            else if (label.Text == "0")
            {
                if (erase == true)
                {
                    operationTextBox.Text = string.Empty;
                    label.Text = btn2.Text;
                }
                else
                {
                    label.Text = btn2.Text;
                }
            }
            else if (label.Text.Length < 16)
            {
                if (label.Text == result2.ToString())
                {
                    operationTextBox.Text = string.Empty;
                    label.Text = btn2.Text;
                }
                else
                {

                    label.Text += btn2.Text;

                }
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (label.Text == "Cannot divide by zero")
            {
                label.Text = btn3.Text;
                operationTextBox.Text = string.Empty;
                label.TextAlign = ContentAlignment.BottomRight;
            }
            else if (label.Text == "0")
            {
                if (erase == true)
                {
                    operationTextBox.Text = string.Empty;
                    label.Text = btn3.Text;
                }
                else
                {
                    label.Text = btn3.Text;
                }
            }
            else if (label.Text.Length < 16)
            {
                if (label.Text == result2.ToString())
                {
                    operationTextBox.Text = string.Empty;
                    label.Text = btn3.Text;
                }
                else
                {

                    label.Text += btn3.Text;

                }
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (label.Text == "Cannot divide by zero")
            {
                label.Text = btn4.Text;
                operationTextBox.Text = string.Empty;
                label.TextAlign = ContentAlignment.BottomRight;
            }
            else if (label.Text == "0")
            {
                if (erase == true)
                {
                    operationTextBox.Text = string.Empty;
                    label.Text = btn4.Text;
                }
                else
                {
                    label.Text = btn4.Text;
                }
            }
            else if (label.Text.Length < 16)
            {
                if (label.Text == result2.ToString())
                {
                    operationTextBox.Text = string.Empty;
                    label.Text = btn4.Text;
                }
                else
                {

                    label.Text += btn4.Text;

                }
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (label.Text == "Cannot divide by zero")
            {
                label.Text = btn5.Text;
                operationTextBox.Text = string.Empty;
                label.TextAlign = ContentAlignment.BottomRight;
            }
            else if (label.Text == "0")
            {
                if (erase == true)
                {
                    operationTextBox.Text = string.Empty;
                    label.Text = btn5.Text;
                }
                else
                {
                    label.Text = btn5.Text;
                }
            }
            else if (label.Text.Length < 16)
            {

                if (label.Text == result2.ToString())
                {
                    operationTextBox.Text = string.Empty;
                    label.Text = btn5.Text;
                }
                else
                {

                    label.Text += btn5.Text;

                }
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (label.Text == "Cannot divide by zero")
            {
                label.Text = btn6.Text;
                operationTextBox.Text = string.Empty;
                label.TextAlign = ContentAlignment.BottomRight;
            }
            else if (label.Text == "0")
            {
                if (erase == true)
                {
                    operationTextBox.Text = string.Empty;
                    label.Text = btn6.Text;
                }
                else
                {
                    label.Text = btn6.Text;
                }
            }
            else if (label.Text.Length < 16)
            {

                if (label.Text == result2.ToString())
                {
                    operationTextBox.Text = string.Empty;
                    label.Text = btn6.Text;
                }
                else
                {
                    label.Text += btn6.Text;

                }
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (label.Text == "Cannot divide by zero")
            {
                label.Text = btn7.Text;
                operationTextBox.Text = string.Empty;
                label.TextAlign = ContentAlignment.BottomRight;
            }
            else if (label.Text == "0")
            {
                if (erase == true)
                {
                    operationTextBox.Text = string.Empty;
                    label.Text = btn7.Text;
                }
                else
                {
                    label.Text = btn7.Text;
                }
            }
            else if (label.Text.Length < 16)
            {

                if (label.Text == result2.ToString())
                {
                    operationTextBox.Text = string.Empty;
                    label.Text = btn7.Text;
                }
                else
                {

                    label.Text += btn7.Text;

                }
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (label.Text == "Cannot divide by zero")
            {
                label.Text = btn8.Text;
                operationTextBox.Text = string.Empty;
                label.TextAlign = ContentAlignment.BottomRight;
            }
            else if (label.Text == "0")
            {
                if (erase == true)
                {
                    operationTextBox.Text = string.Empty;
                    label.Text = btn8.Text;
                }
                else
                {
                    label.Text = btn8.Text;
                }
            }
            else if (label.Text.Length < 16)
            {

                if (label.Text == result2.ToString())
                {
                    operationTextBox.Text = string.Empty;
                    label.Text = btn8.Text;
                }
                else
                {

                    label.Text += btn8.Text;

                }
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (label.Text == "Cannot divide by zero")
            {
                label.Text = btn9.Text;
                operationTextBox.Text = string.Empty;
                label.TextAlign = ContentAlignment.BottomRight;
            }
            else if (label.Text == "0")
            {
                if (erase == true)
                {
                    operationTextBox.Text = string.Empty;
                    label.Text = btn9.Text;
                }
                else
                {
                    label.Text = btn9.Text;
                }
            }
            else if (label.Text.Length < 16)
            {

                if (label.Text == result2.ToString())
                {
                    operationTextBox.Text = string.Empty;
                    label.Text = btn9.Text;
                }
                else
                {

                    label.Text += btn9.Text;

                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            label.Text = "0";
            operationTextBox.Text = string.Empty;
            label.TextAlign = ContentAlignment.BottomRight;
        }

        private void BtnRemove_Click(object sender, EventArgs e)
        {
            string newNumber = label.Text.Remove(label.Text.Length - 1);
            if (label.Text != "0")
            {
                label.Text = newNumber;

                if (label.Text.Length - 1 < 0)
                {
                    label.Text = "0";
                }
            }
        }

        private void label_TextChanged(object sender, EventArgs e)
        {
            if (label.Text.Length == 14)
            {
                label.Font = new Font("Gadugi", 27, FontStyle.Bold);
            }
            else if (label.Text.Length == 15)
            {
                label.Font = new Font("Gadugi", 26, FontStyle.Bold);

            }
            else if (label.Text.Length == 16)
            {
                label.Font = new Font("Gadugi", 24, FontStyle.Bold);
            }
            else
            {
                label.Font = new Font("Gadugi", 28, FontStyle.Bold);
            }
        }

        private void Calculator_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.D0:
                case Keys.NumPad0:
                    btn0_Click(sender, e);
                    break;
                case Keys.D1:
                case Keys.NumPad1:
                    btn1_Click(sender, e);
                    break;
                case Keys.D2:
                case Keys.NumPad2:
                    btn2_Click(sender, e);
                    break;
                case Keys.D3:
                case Keys.NumPad3:
                    btn3_Click(sender, e);
                    break;
                case Keys.D4:
                case Keys.NumPad4:
                    btn4_Click(sender, e);
                    break;
                case Keys.D5:
                case Keys.NumPad5:
                    btn5_Click(sender, e);
                    break;
                case Keys.D6:
                case Keys.NumPad6:
                    btn6_Click(sender, e);
                    break;
                case Keys.D7:
                case Keys.NumPad7:
                    btn7_Click(sender, e);
                    break;
                case Keys.D8:
                case Keys.NumPad8:
                    btn8_Click(sender, e);
                    break;
                case Keys.D9:
                case Keys.NumPad9:
                    btn0_Click(sender, e);
                    break;
                case Keys.Back:
                    BtnRemove_Click(sender, e);
                    break;
                case Keys.Delete:
                    btnClear_Click(sender, e);
                    break;
            }
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            if (operationTextBox.Text == string.Empty)
            {
                operationTextBox.Text = label.Text + $" {btnPlus.Text} ";
                label.Text = "0";
            }
            else if (label.Text != "Cannot divide by zero")
            {

                string[] numberTextBox = operationTextBox.Text.Split(' ');
                if (!numberTextBox.Contains("="))
                {
                    switch (numberTextBox[1])
                    {
                        case "-":
                            result2 = 0;
                            result = double.Parse(numberTextBox[0], CultureInfo.InvariantCulture) - double.Parse(label.Text, CultureInfo.InvariantCulture);
                            operationTextBox.Text = result.ToString("F2", CultureInfo.InvariantCulture) + $" {btnPlus.Text} ";
                            label.Text = "0";
                            break;
                        case "x":
                            result2 = 0;
                            result = double.Parse(numberTextBox[0], CultureInfo.InvariantCulture) * double.Parse(label.Text, CultureInfo.InvariantCulture);
                            operationTextBox.Text = result.ToString(CultureInfo.InvariantCulture) + $" {btnPlus.Text} ";
                            label.Text = "0";
                            break;
                        case "÷":
                            result = double.Parse(numberTextBox[0], CultureInfo.InvariantCulture) / double.Parse(label.Text, CultureInfo.InvariantCulture);
                            operationTextBox.Text = result.ToString(CultureInfo.InvariantCulture) + $" {btnPlus.Text} ";
                            label.Text = "0";
                            break;
                        case "^":
                            result = Math.Pow(double.Parse(numberTextBox[0], CultureInfo.InvariantCulture), double.Parse(label.Text, CultureInfo.InvariantCulture));
                            operationTextBox.Text = result.ToString("F2", CultureInfo.InvariantCulture) + $" {btnPlus.Text} ";
                            label.Text = "0";
                            break;
                        case "%":
                            operationTextBox.Text = (double.Parse(numberTextBox[0]) / 100).ToString(CultureInfo.InvariantCulture) + $" {btnPlus.Text} ";
                            label.Text = "0";
                            break;
                        case "√":
                            operationTextBox.Text = Math.Sqrt(double.Parse(numberTextBox[2], CultureInfo.InvariantCulture)).ToString("F2", CultureInfo.InvariantCulture) + $" {btnPlus.Text} ";
                            label.Text = "0";
                            break;
                        default:
                            result2 = 0;
                            result = double.Parse(numberTextBox[0], CultureInfo.InvariantCulture) + double.Parse(label.Text, CultureInfo.InvariantCulture);
                            operationTextBox.Text = result.ToString(CultureInfo.InvariantCulture) + $" {btnPlus.Text} ";
                            label.Text = "0";
                            break;
                    }
                }
                else
                {
                    operationTextBox.Text = double.Parse(label.Text, CultureInfo.InvariantCulture).ToString(CultureInfo.InvariantCulture) + $" {btnPlus.Text} ";
                    label.Text = "0";
                }

            }


        }

        private void btnMinus_Click(object sender, EventArgs e)
        {

            if (operationTextBox.Text == string.Empty)
            {
                operationTextBox.Text = label.Text + $" {btnMinus.Text} ";
                label.Text = "0";
            }
            else if (label.Text != "Cannot divide by zero")
            {
                string[] numberTextBox = operationTextBox.Text.Split(' ');

                if (!numberTextBox.Contains("="))
                {
                    switch (numberTextBox[1])
                    {
                        case "+":
                            result = double.Parse(numberTextBox[0], CultureInfo.InvariantCulture) + double.Parse(label.Text, CultureInfo.InvariantCulture);
                            operationTextBox.Text = result.ToString(CultureInfo.InvariantCulture) + $" {btnMinus.Text} ";
                            label.Text = "0";
                            break;
                        case "x":
                            result = double.Parse(numberTextBox[0], CultureInfo.InvariantCulture) * double.Parse(label.Text, CultureInfo.InvariantCulture);
                            operationTextBox.Text = result.ToString(CultureInfo.InvariantCulture) + $" {btnMinus.Text} ";
                            label.Text = "0";
                            break;
                        case "÷":
                            result = double.Parse(numberTextBox[0], CultureInfo.InvariantCulture) / double.Parse(label.Text, CultureInfo.InvariantCulture);
                            operationTextBox.Text = result.ToString(CultureInfo.InvariantCulture) + $" {btnMinus.Text} ";
                            label.Text = "0";
                            break;
                        case "^":
                            result = Math.Pow(double.Parse(numberTextBox[0], CultureInfo.InvariantCulture), double.Parse(label.Text, CultureInfo.InvariantCulture));
                            operationTextBox.Text = result.ToString(CultureInfo.InvariantCulture) + $" {btnMinus.Text} ";
                            label.Text = "0";
                            break;
                        case "%":
                            operationTextBox.Text = (double.Parse(numberTextBox[0]) / 100).ToString(CultureInfo.InvariantCulture) + $" {btnMinus.Text} ";
                            label.Text = "0";
                            break;
                        case "√":
                            operationTextBox.Text = Math.Sqrt(double.Parse(numberTextBox[2], CultureInfo.InvariantCulture)).ToString(CultureInfo.InvariantCulture) + $" {btnMinus.Text} ";
                            label.Text = "0";
                            break;
                        default:
                            result = double.Parse(numberTextBox[0], CultureInfo.InvariantCulture) - double.Parse(label.Text, CultureInfo.InvariantCulture);
                            operationTextBox.Text = result.ToString(CultureInfo.InvariantCulture) + $" {btnMinus.Text} ";
                            label.Text = "0";
                            break;
                    }
                }
                else
                {
                    operationTextBox.Text = double.Parse(label.Text, CultureInfo.InvariantCulture).ToString(CultureInfo.InvariantCulture) + $" {btnMinus.Text} ";
                    label.Text = "0";
                }

            }
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            if (operationTextBox.Text == string.Empty)
            {
                operationTextBox.Text = label.Text + $" {btnMult.Text} ";
                label.Text = "0";
            }
            else if (label.Text != "Cannot divide by zero")
            {
                string[] numberTextBox = operationTextBox.Text.Split(' ');

                if (!numberTextBox.Contains("="))
                {
                    switch (numberTextBox[1])
                    {
                        case "+":
                            result = double.Parse(numberTextBox[0], CultureInfo.InvariantCulture) + double.Parse(label.Text, CultureInfo.InvariantCulture);
                            operationTextBox.Text = result.ToString(CultureInfo.InvariantCulture) + $" {btnMult.Text} ";
                            label.Text = "0";
                            break;
                        case "-":
                            result = double.Parse(numberTextBox[0], CultureInfo.InvariantCulture) - double.Parse(label.Text, CultureInfo.InvariantCulture);
                            operationTextBox.Text = result.ToString(CultureInfo.InvariantCulture) + $" {btnMult.Text} ";
                            label.Text = "0";
                            break;
                        case "÷":
                            result = double.Parse(numberTextBox[0], CultureInfo.InvariantCulture) / double.Parse(label.Text, CultureInfo.InvariantCulture);
                            operationTextBox.Text = result.ToString(CultureInfo.InvariantCulture) + $" {btnMult.Text} ";
                            label.Text = "0";
                            break;
                        case "^":
                            result = Math.Pow(double.Parse(numberTextBox[0], CultureInfo.InvariantCulture), double.Parse(label.Text, CultureInfo.InvariantCulture));
                            operationTextBox.Text = result.ToString(CultureInfo.InvariantCulture) + $" {btnMult.Text} ";
                            label.Text = "0";
                            break;
                        case "%":
                            operationTextBox.Text = (double.Parse(numberTextBox[0]) / 100).ToString(CultureInfo.InvariantCulture) + $" {btnMult.Text} ";
                            label.Text = "0";
                            break;
                        case "√":
                            operationTextBox.Text = Math.Sqrt(double.Parse(numberTextBox[2], CultureInfo.InvariantCulture)).ToString("F2", CultureInfo.InvariantCulture) + $" {btnMult.Text} ";
                            label.Text = "0";
                            break;
                        default:
                            result = double.Parse(numberTextBox[0], CultureInfo.InvariantCulture) * double.Parse(label.Text, CultureInfo.InvariantCulture);
                            operationTextBox.Text = result.ToString(CultureInfo.InvariantCulture) + $" {btnMult.Text} ";
                            label.Text = "0";
                            break;
                    }
                }
                else
                {
                    operationTextBox.Text = double.Parse(label.Text, CultureInfo.InvariantCulture).ToString(CultureInfo.InvariantCulture) + $" {btnMult.Text} ";
                    label.Text = "0";
                }
            }
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            if (operationTextBox.Text == string.Empty)
            {
                operationTextBox.Text = label.Text + $" {btnDivision.Text} ";
                label.Text = "0";
            }
            else if (label.Text != "Cannot divide by zero")
            {
                string[] numberTextBox = operationTextBox.Text.Split(' ');

                if (!numberTextBox.Contains("="))
                {
                    switch (numberTextBox[1])
                    {
                        case "+":
                            result = double.Parse(numberTextBox[0], CultureInfo.InvariantCulture) + double.Parse(label.Text, CultureInfo.InvariantCulture);
                            operationTextBox.Text = result.ToString(CultureInfo.InvariantCulture) + $" {btnDivision.Text} ";
                            label.Text = "0";
                            break;
                        case "-":
                            result = double.Parse(numberTextBox[0], CultureInfo.InvariantCulture) - double.Parse(label.Text, CultureInfo.InvariantCulture);
                            operationTextBox.Text = result.ToString(CultureInfo.InvariantCulture) + $" {btnDivision.Text} ";
                            label.Text = "0";
                            break;
                        case "x":
                            result = double.Parse(numberTextBox[0], CultureInfo.InvariantCulture) * double.Parse(label.Text, CultureInfo.InvariantCulture);
                            operationTextBox.Text = result.ToString(CultureInfo.InvariantCulture) + $" {btnDivision.Text} ";
                            label.Text = "0";
                            break;
                        case "^":
                            result = Math.Pow(double.Parse(numberTextBox[0], CultureInfo.InvariantCulture), double.Parse(label.Text, CultureInfo.InvariantCulture));
                            operationTextBox.Text = result.ToString(CultureInfo.InvariantCulture) + $" {btnDivision.Text} ";
                            label.Text = "0";
                            break;
                        case "%":
                            operationTextBox.Text = (double.Parse(numberTextBox[0]) / 100).ToString(CultureInfo.InvariantCulture) + $" {btnDivision.Text} ";
                            label.Text = "0";
                            break;
                        case "√":
                            operationTextBox.Text = Math.Sqrt(double.Parse(numberTextBox[2], CultureInfo.InvariantCulture)).ToString("F2", CultureInfo.InvariantCulture) + $" {btnDivision.Text} ";
                            label.Text = "0";
                            break;
                        default:
                            if (label.Text == "0")
                            {
                                operationTextBox.Text = result.ToString(CultureInfo.InvariantCulture) + $" {btnDivision.Text} ";
                                label.Text = "0";
                            }
                            else
                            {
                                result = double.Parse(numberTextBox[0], CultureInfo.InvariantCulture) / double.Parse(label.Text, CultureInfo.InvariantCulture);
                                operationTextBox.Text = result.ToString(CultureInfo.InvariantCulture) + $" {btnDivision.Text} ";
                                label.Text = "0";
                            }
                            break;
                    }
                }
                else
                {
                    operationTextBox.Text = double.Parse(label.Text, CultureInfo.InvariantCulture).ToString(CultureInfo.InvariantCulture) + $" {btnDivision.Text} ";
                    label.Text = "0";
                }
            }
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            if (operationTextBox.Text.Contains("="))
            {
                operationTextBox.Text = string.Empty;
            }
            else if (operationTextBox.Text != string.Empty)
            {
                operationTextBox.Text += label.Text;

                string[] numberTextBox = operationTextBox.Text.Split(' ');

                if (numberTextBox[2] == "")
                {
                    numberTextBox[2] = "0";
                }

                operationTextBox.Text += " =";

                if (numberTextBox.Length == 3)
                {
                    switch (numberTextBox[1])
                    {
                        case "+":
                            result2 = double.Parse(numberTextBox[0], CultureInfo.InvariantCulture) + double.Parse(label.Text, CultureInfo.InvariantCulture);
                            if (result2 == 0)
                            {
                                erase = true;
                            }
                            else
                            {
                                erase = false;
                            }
                            label.Text = result2.ToString(CultureInfo.InvariantCulture);
                            break;
                        case "-":
                            result2 = double.Parse(numberTextBox[0], CultureInfo.InvariantCulture) - double.Parse(label.Text, CultureInfo.InvariantCulture);
                            if (result2 == 0)
                            {
                                erase = true;
                            }
                            else
                            {
                                erase = false;
                            }
                            label.Text = result2.ToString(CultureInfo.InvariantCulture);
                            break;
                        case "x":
                            result2 = double.Parse(numberTextBox[0], CultureInfo.InvariantCulture) * double.Parse(label.Text, CultureInfo.InvariantCulture);
                            if (result2 == 0)
                            {
                                erase = true;
                            }
                            else
                            {
                                erase = false;
                            }
                            label.Text = result2.ToString(CultureInfo.InvariantCulture);
                            break;
                        case "÷":
                            if (numberTextBox[2] == "0")
                            {
                                label.Text = "Cannot divide by zero";
                                label.TextAlign = ContentAlignment.MiddleCenter;
                                label.Font = new Font("Gadugi", 20, FontStyle.Bold);
                            }
                            else
                            {
                                result2 = double.Parse(numberTextBox[0], CultureInfo.InvariantCulture) / double.Parse(label.Text, CultureInfo.InvariantCulture);
                                if (result2 == 0)
                                {
                                    erase = true;
                                }
                                else
                                {
                                    erase = false;
                                }
                                label.Text = result2.ToString(CultureInfo.InvariantCulture);
                            }
                            break;
                        case "^":
                            result2 = Math.Pow(double.Parse(numberTextBox[0], CultureInfo.InvariantCulture), double.Parse(label.Text, CultureInfo.InvariantCulture));
                            if (result2 == 0)
                            {
                                erase = true;
                            }
                            else
                            {
                                erase = false;
                            }
                            label.Text = result2.ToString(CultureInfo.InvariantCulture);
                            break;
                    }
                }
                else
                {
                    if (numberTextBox.Contains("√"))
                    {
                        switch (numberTextBox[1])
                        {
                            case "+":
                                result2 = double.Parse(numberTextBox[0], CultureInfo.InvariantCulture) + Math.Sqrt(double.Parse(numberTextBox[4], CultureInfo.InvariantCulture));
                                if (result2 == 0)
                                {
                                    erase = true;
                                }
                                else
                                {
                                    erase = false;
                                }
                                label.Text = result2.ToString(CultureInfo.InvariantCulture);
                                break;
                            case "-":
                                result2 = double.Parse(numberTextBox[0], CultureInfo.InvariantCulture) - Math.Sqrt(double.Parse(numberTextBox[4], CultureInfo.InvariantCulture));
                                if (result2 == 0)
                                {
                                    erase = true;
                                }
                                else
                                {
                                    erase = false;
                                }
                                label.Text = result2.ToString(CultureInfo.InvariantCulture);
                                break;
                            case "x":
                                result2 = double.Parse(numberTextBox[0], CultureInfo.InvariantCulture) * Math.Sqrt(double.Parse(numberTextBox[4], CultureInfo.InvariantCulture));
                                if (result2 == 0)
                                {
                                    erase = true;
                                }
                                else
                                {
                                    erase = false;
                                }
                                label.Text = result2.ToString(CultureInfo.InvariantCulture);
                                break;
                            case "÷":
                                if (numberTextBox[4] == "0")
                                {
                                    label.Text = "Cannot divide by zero";
                                    label.TextAlign = ContentAlignment.MiddleCenter;
                                    label.Font = new Font("Gadugi", 20, FontStyle.Bold);
                                }
                                else
                                {
                                    result2 = double.Parse(numberTextBox[0], CultureInfo.InvariantCulture) / Math.Sqrt(double.Parse(numberTextBox[4], CultureInfo.InvariantCulture));
                                    if (result2 == 0)
                                    {
                                        erase = true;
                                    }
                                    else
                                    {
                                        erase = false;
                                    }
                                    label.Text = result2.ToString(CultureInfo.InvariantCulture);
                                }
                                break;
                            case "^":
                                result2 = Math.Pow(double.Parse(numberTextBox[0], CultureInfo.InvariantCulture), Math.Sqrt(double.Parse(numberTextBox[4], CultureInfo.InvariantCulture)));
                                if (result2 == 0)
                                {
                                    erase = true;
                                }
                                else
                                {
                                    erase = false;
                                }
                                label.Text = result2.ToString(CultureInfo.InvariantCulture);
                                break;
                        }
                    }
                    else if (numberTextBox.Contains("%"))
                    {
                        switch (numberTextBox[1])
                        {
                            case "+":
                                result2 = double.Parse(numberTextBox[0], CultureInfo.InvariantCulture) + double.Parse(numberTextBox[0], CultureInfo.InvariantCulture) * double.Parse(numberTextBox[2], CultureInfo.InvariantCulture) / 100;
                                if (result2 == 0)
                                {
                                    erase = true;
                                }
                                else
                                {
                                    erase = false;
                                }
                                label.Text = result2.ToString(CultureInfo.InvariantCulture);
                                break;
                            case "-":
                                result2 = double.Parse(numberTextBox[0], CultureInfo.InvariantCulture) - double.Parse(numberTextBox[0], CultureInfo.InvariantCulture) * double.Parse(numberTextBox[2], CultureInfo.InvariantCulture) / 100;
                                if (result2 == 0)
                                {
                                    erase = true;
                                }
                                else
                                {
                                    erase = false;
                                }
                                label.Text = result2.ToString(CultureInfo.InvariantCulture);
                                break;
                            case "x":
                                result2 = double.Parse(numberTextBox[0], CultureInfo.InvariantCulture) * (

                                    double.Parse(numberTextBox[2], CultureInfo.InvariantCulture) / 100);
                                if (result2 == 0)
                                {
                                    erase = true;
                                }
                                else
                                {
                                    erase = false;
                                }
                                label.Text = result2.ToString(CultureInfo.InvariantCulture);
                                break;
                            case "÷":
                                if (numberTextBox[4] == "0")
                                {
                                    label.Text = "Cannot divide by zero";
                                    label.TextAlign = ContentAlignment.MiddleCenter;
                                    label.Font = new Font("Gadugi", 20, FontStyle.Bold);
                                }
                                else
                                {
                                    result2 = double.Parse(numberTextBox[0], CultureInfo.InvariantCulture) / (double.Parse(numberTextBox[0], CultureInfo.InvariantCulture) * double.Parse(numberTextBox[2], CultureInfo.InvariantCulture) / 100);
                                    if (result2 == 0)
                                    {
                                        erase = true;
                                    }
                                    else
                                    {
                                        erase = false;
                                    }
                                    label.Text = result2.ToString(CultureInfo.InvariantCulture);
                                }
                                break;
                            case "^":
                                result2 = Math.Pow(double.Parse(numberTextBox[0], CultureInfo.InvariantCulture), (double.Parse(numberTextBox[2], CultureInfo.InvariantCulture) / 100));
                                if (result2 == 0)
                                {
                                    erase = true;
                                }
                                else
                                {
                                    erase = false;
                                }
                                label.Text = result2.ToString(CultureInfo.InvariantCulture);
                                break;
                        }
                    }
                    else if (numberTextBox.Contains("/"))
                    {
                        switch (numberTextBox[1])
                        {
                            case "+":
                                result2 = double.Parse(numberTextBox[0], CultureInfo.InvariantCulture) + (1 / double.Parse(numberTextBox[5], CultureInfo.InvariantCulture));
                                if (result2 == 0)
                                {
                                    erase = true;
                                }
                                else
                                {
                                    erase = false;
                                }
                                label.Text = result2.ToString(CultureInfo.InvariantCulture);
                                break;
                            case "-":
                                result2 = double.Parse(numberTextBox[0], CultureInfo.InvariantCulture) - (1 / double.Parse(numberTextBox[5], CultureInfo.InvariantCulture));
                                if (result2 == 0)
                                {
                                    erase = true;
                                }
                                else
                                {
                                    erase = false;
                                }
                                label.Text = result2.ToString(CultureInfo.InvariantCulture);
                                break;
                            case "x":
                                result2 = double.Parse(numberTextBox[0], CultureInfo.InvariantCulture) * (1 / double.Parse(numberTextBox[5], CultureInfo.InvariantCulture));

                                if (result2 == 0)
                                {
                                    erase = true;
                                }
                                else
                                {
                                    erase = false;
                                }
                                label.Text = result2.ToString(CultureInfo.InvariantCulture);
                                break;
                            case "÷":
                                if (numberTextBox[4] == "0")
                                {
                                    label.Text = "Cannot divide by zero";
                                    label.TextAlign = ContentAlignment.MiddleCenter;
                                    label.Font = new Font("Gadugi", 20, FontStyle.Bold);
                                }
                                else
                                {
                                    result2 = double.Parse(numberTextBox[0], CultureInfo.InvariantCulture) / (1 / double.Parse(numberTextBox[5], CultureInfo.InvariantCulture));
                                    if (result2 == 0)
                                    {
                                        erase = true;
                                    }
                                    else
                                    {
                                        erase = false;
                                    }
                                    label.Text = result2.ToString(CultureInfo.InvariantCulture);
                                }
                                break;
                            case "^":
                                result2 = Math.Pow(double.Parse(numberTextBox[0], CultureInfo.InvariantCulture), (1 / double.Parse(numberTextBox[5], CultureInfo.InvariantCulture)));
                                if (result2 == 0)
                                {
                                    erase = true;
                                }
                                else
                                {
                                    erase = false;
                                }
                                label.Text = result2.ToString(CultureInfo.InvariantCulture);
                                break;
                        }
                    }
                    else if (numberTextBox.Contains("^"))
                    {
                        switch (numberTextBox[1])
                        {
                            case "+":
                                operationTextBox.Text = operationTextBox.Text.Remove(operationTextBox.Text.IndexOf("="));
                                operationTextBox.Text += ") =";
                                result2 = double.Parse(numberTextBox[0], CultureInfo.InvariantCulture) + Math.Pow(double.Parse(numberTextBox[3], CultureInfo.InvariantCulture), double.Parse(numberTextBox[5], CultureInfo.InvariantCulture));
                                if (result2 == 0)
                                {
                                    erase = true;
                                }
                                else
                                {
                                    erase = false;
                                }
                                label.Text = result2.ToString(CultureInfo.InvariantCulture);
                                break;
                            case "-":
                                operationTextBox.Text = operationTextBox.Text.Remove(operationTextBox.Text.IndexOf("="));
                                operationTextBox.Text += ") =";
                                result2 = double.Parse(numberTextBox[0], CultureInfo.InvariantCulture) - Math.Pow(double.Parse(numberTextBox[3], CultureInfo.InvariantCulture), double.Parse(numberTextBox[5], CultureInfo.InvariantCulture));
                                if (result2 == 0)
                                {
                                    erase = true;
                                }
                                else
                                {
                                    erase = false;
                                }
                                label.Text = result2.ToString(CultureInfo.InvariantCulture);
                                break;
                            case "x":
                                operationTextBox.Text = operationTextBox.Text.Remove(operationTextBox.Text.IndexOf("="));
                                operationTextBox.Text += ") =";
                                result2 = double.Parse(numberTextBox[0], CultureInfo.InvariantCulture) * Math.Pow(double.Parse(numberTextBox[3], CultureInfo.InvariantCulture), double.Parse(numberTextBox[5], CultureInfo.InvariantCulture));

                                if (result2 == 0)
                                {
                                    erase = true;
                                }
                                else
                                {
                                    erase = false;
                                }
                                label.Text = result2.ToString(CultureInfo.InvariantCulture);
                                break;
                            case "÷":
                                if (numberTextBox[4] == "0")
                                {
                                    label.Text = "Cannot divide by zero";
                                    label.TextAlign = ContentAlignment.MiddleCenter;
                                    label.Font = new Font("Gadugi", 20, FontStyle.Bold);
                                }
                                else
                                {
                                    operationTextBox.Text = operationTextBox.Text.Remove(operationTextBox.Text.IndexOf("="));
                                    operationTextBox.Text += ") =";
                                    result2 = double.Parse(numberTextBox[0], CultureInfo.InvariantCulture) / Math.Pow(double.Parse(numberTextBox[3], CultureInfo.InvariantCulture), double.Parse(numberTextBox[5], CultureInfo.InvariantCulture));
                                    if (result2 == 0)
                                    {
                                        erase = true;
                                    }
                                    else
                                    {
                                        erase = false;
                                    }
                                    label.Text = result2.ToString(CultureInfo.InvariantCulture);
                                }
                                break;
                            case "^":
                                operationTextBox.Text = operationTextBox.Text.Remove(operationTextBox.Text.IndexOf("="));
                                operationTextBox.Text += ") =";
                                result2 = Math.Pow(double.Parse(numberTextBox[0], CultureInfo.InvariantCulture), Math.Pow(double.Parse(numberTextBox[3], CultureInfo.InvariantCulture), double.Parse(numberTextBox[5], CultureInfo.InvariantCulture)));

                                if (result2 == 0)
                                {
                                    erase = true;
                                }
                                else
                                {
                                    erase = false;
                                }
                                label.Text = result2.ToString(CultureInfo.InvariantCulture);
                                break;
                        }
                    }
                }
            }
        }

        private void btnCancelEntry_Click(object sender, EventArgs e)
        {
           
            label.Text = "0";
            label.TextAlign = ContentAlignment.BottomRight;
           
        }

        private void btnDs_Click(object sender, EventArgs e)
        {
            if (!label.Text.Contains("."))
            {
                label.Text += ".";
            }
        }

        private void btnPm_Click(object sender, EventArgs e)
        {
            if (!label.Text.Contains("-") && label.Text != "0")
            {
                label.Text = '-' + label.Text;
            }
            else if (label.Text.Contains("-") && label.Text != "0")
            {
                label.Text = label.Text.Remove(0, 1);
            }
        }

        private void btnPwr_Click(object sender, EventArgs e)
        {
            if (operationTextBox.Text == string.Empty)
            {
                operationTextBox.Text = label.Text + " ^ ";
                label.Text = "0";
            }
            else if(operationTextBox.Text.Contains("=") && operationTextBox.Text != string.Empty)
            {
                operationTextBox.Text = label.Text + " ^ ";
                label.Text = "0";
            }
            else
            {
                operationTextBox.Text += "( " + label.Text + " ^ ";
                label.Text = "0";
            }

        }

        private void btnSqrt_Click(object sender, EventArgs e)
        {
            if (operationTextBox.Text == string.Empty)
            {
                operationTextBox.Text = $"( √ {label.Text} )";
                result2 = Math.Sqrt(double.Parse(label.Text, CultureInfo.InvariantCulture));
                if (result2 == 0)
                {
                    erase = true;
                    label.Text = result2.ToString(CultureInfo.InvariantCulture);
                }
                else
                {
                    erase = false;
                    label.Text = result2.ToString(CultureInfo.InvariantCulture);
                }
            }else if(operationTextBox.Text != string.Empty && operationTextBox.Text.Contains("="))
            {
                operationTextBox.Text = $"( √ {label.Text} ) =";
                label.Text = Math.Sqrt(double.Parse(label.Text, CultureInfo.InvariantCulture)).ToString(CultureInfo.InvariantCulture);
            }
            else if (operationTextBox.Text.Length >= 4)
            {
                operationTextBox.Text += $"( √ {label.Text} )";

                label.Text = Math.Sqrt(double.Parse(label.Text, CultureInfo.InvariantCulture)).ToString(CultureInfo.InvariantCulture);

            }
        }

        private void btnToFraction_Click(object sender, EventArgs e)
        {
            if (operationTextBox.Text == string.Empty)
            {
                if (label.Text != "0")
                {
                    operationTextBox.Text = $"1 / ({label.Text})";
                    result2 = 1 / double.Parse(label.Text, CultureInfo.InvariantCulture);
                    if (result2 == 0)
                    {
                        erase = true;
                        label.Text = result2.ToString(CultureInfo.InvariantCulture);
                    }
                    else
                    {
                        erase = false;
                        label.Text = result2.ToString(CultureInfo.InvariantCulture);
                    }
                }
            }else if (operationTextBox.Text.Contains("="))
            {
                operationTextBox.Text = $"1 / ( {label.Text} ) =";
                label.Text = $"{(1 / double.Parse(label.Text, CultureInfo.InvariantCulture)).ToString(CultureInfo.InvariantCulture)}";
            }
            else
            {
                operationTextBox.Text += $"1 / ( {label.Text} )";
                label.Text = $"{(1 / double.Parse(label.Text, CultureInfo.InvariantCulture)).ToString(CultureInfo.InvariantCulture)}";
            }
        }

        private void btnPrcnt_Click(object sender, EventArgs e)
        {
            if (operationTextBox.Text == string.Empty)
            {
                operationTextBox.Text = $"{label.Text} % =";
                result2 = double.Parse(label.Text, CultureInfo.InvariantCulture) / 100;
                if (result2 == 0)
                {
                    erase = true;
                    label.Text = result2.ToString(CultureInfo.InvariantCulture);
                }
                else
                {
                    erase = false;
                    label.Text = result2.ToString(CultureInfo.InvariantCulture);
                }
            }else if (operationTextBox.Text.Contains("="))
            {
                operationTextBox.Text = $"{label.Text} %";
                label.Text = (double.Parse(label.Text, CultureInfo.InvariantCulture) / 100).ToString(CultureInfo.InvariantCulture);
            }
            else
            {
                if (operationTextBox.Text.Contains("+") || operationTextBox.Text.Contains("-"))
                {
                    operationTextBox.Text += $"{label.Text} %";

                    string[] numberTextBox = operationTextBox.Text.Split(' ');

                    label.Text = (double.Parse(numberTextBox[0], CultureInfo.InvariantCulture) * double.Parse(numberTextBox[2], CultureInfo.InvariantCulture) / 100).ToString(CultureInfo.InvariantCulture);

                }
                else if (operationTextBox.Text.Contains("x") || operationTextBox.Text.Contains("÷") || operationTextBox.Text.Contains("^"))
                {
                    operationTextBox.Text += $"{label.Text} %";

                    string[] numberTextBox = operationTextBox.Text.Split(' ');

                    label.Text = (double.Parse(label.Text, CultureInfo.InvariantCulture) / 100).ToString(CultureInfo.InvariantCulture);
                }
            }
        }
    }
}
