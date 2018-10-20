using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms_SimpleCalculator
{
    public partial class CalculatorForm : Form
    {

        public delegate void passNumberDelegate(TextBox txt);

        public CalculatorForm()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            cmb_UnitOfMeasure.DataSource = Enum.GetValues(typeof(EnMet));
        }

        enum EnMet
        {
            feet,
            meters
        }

        private void Btn_Num0_Click(object sender, EventArgs e)
        {
            InsertCharacter('0');
        }

        private void Btn_Num1_Click(object sender, EventArgs e)
        {
            InsertCharacter('1');
        }

        private void Btn_Num2_Click(object sender, EventArgs e)
        {
            InsertCharacter('2');
        }

        private void Btn_Num3_Click(object sender, EventArgs e)
        {
            InsertCharacter('3');
        }

        private void Btn_Num4_Click(object sender, EventArgs e)
        {
            InsertCharacter('4');
        }

        private void Btn_Num5_Click(object sender, EventArgs e)
        {
            InsertCharacter('5');
        }

        private void Btn_Num6_Click(object sender, EventArgs e)
        {
            InsertCharacter('6');
        }

        private void Btn_Num7_Click(object sender, EventArgs e)
        {
            InsertCharacter('7');
        }

        private void Btn_Num8_Click(object sender, EventArgs e)
        {
            InsertCharacter('8');
        }

        private void Btn_Num9_Click(object sender, EventArgs e)
        {
            InsertCharacter('9');
        }

        private void Btn_DecPoint_Click(object sender, EventArgs e)
        {
            InsertCharacter('.');
        }

        /// <summary>
        /// Adds a character to txt_Value1's text value
        /// </summary>
        /// <param name="s"></param>
        public void InsertCharacter(Char s)
        {
            if (s == '.' && txt_Value1.Text.Contains("."))
            {
                int old_index = txt_Value1.Text.IndexOf(".");
                int new_index = txt_Value1.SelectionStart;

                if (old_index != -1)
                {
                    txt_Value1.Text = txt_Value1.Text.Replace(".", "");
                    new_index = (old_index < new_index) ? new_index - 1 : new_index;
                }

                txt_Value1.Text = txt_Value1.Text.Insert(new_index, s.ToString());
            }
            else
            {
                txt_Value1.Paste(s.ToString());
            }
        }

        /// <summary>
        /// Validates a control's text value as a numeric value
        /// </summary>
        /// <param name="control"></param>
        /// <param name="message"></param>
        /// <returns>bool</returns>
        public bool ValidateNumeric(Control control, bool checkForEmpty, out string message)
        {
            bool result = false;
            string str = control.Text;
            message = "";

            if (str.Contains("-"))
            {
                message = "This field cannot accept negative values.";
                errorProvider1.SetError(control, message);
            }
            else if (str.Length - str.Replace(".", "").Length > 1)
            {
                message = "There are too many decimal points in this field.";
                errorProvider1.SetError(control, message);
            }
            else if (Regex.IsMatch(str, @"[^\d*\.{0,1}\d*]"))
            {
                message = "Invalid entry.  Please limit input to numbers and a decimal point.";
                errorProvider1.SetError(control, message);
            }
            else if (checkForEmpty && str == "")
            {
                message = "Calculation cannot be performed on an empty value.";
                errorProvider1.SetError(control, message);
            }
            else
            {
                result = true;
            }

            if (result)
            {
                errorProvider1.Clear();
            }
            return result;
        }
        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Click event for btn_Calculate
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Calculate_Click(object sender, EventArgs e)
        {
            ManageErrors(true);

            if (txt_Value1.Text != "")
            {
                //SolutionForm solutionForm = new SolutionForm(GenerateResult(this.txt_Value1.Text));
                SolutionForm solutionForm = new SolutionForm(GenerateResult(this.txt_Value1.Text));
                solutionForm.ShowDialog();
            }
        }

        /// <summary>
        /// Click event for btn_Help
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Help_Click(object sender, EventArgs e)
        {
            HelpForm helpForm = new HelpForm();

            helpForm.ShowDialog();
        }

        /// <summary>
        /// Click event for btn_Clear
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Clear_Click(object sender, EventArgs e)
        {
            txt_Value1.Clear();
        }

        /// <summary>
        /// Text changed event for txt_Value1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txt_Value1_TextChanged(object sender, EventArgs e)
        {
            ManageErrors(false);
        }

        /// <summary>
        /// Determines when to show and hide the error message on txt_Value1
        /// </summary>
        private void ManageErrors(bool checkForEmpty)
        {
            if (!ValidateNumeric(txt_Value1, checkForEmpty, out string error_message))
            {
                lbl_Error.Text = error_message;
                lbl_Error.Visible = true;
            }
            else
            {
                lbl_Error.Text = "";
                lbl_Error.Visible = false;
            }
        }


        /// <summary>
        /// Convert integer to a binary string
        /// </summary>
        /// <param name="baseTenInput"></param>
        /// <returns>string</returns>
        private string ConvertIntegerToBinary(string baseTenInput)
        {
            int baseTenAmount = 0;
            string result = "";
            int remainingAmount = 0;
            int powerOfTwo = 0;

            try
            {
                if (Int32.TryParse(baseTenInput, out baseTenAmount))
                {
                    if (baseTenAmount == 0)
                    {
                        result = "0";
                    }
                    else
                    {
                        // conversion process begins here
                        powerOfTwo = CalcMinPower(baseTenAmount, 2);
                        remainingAmount = baseTenAmount;

                        for (int i = 0; powerOfTwo >= 0; i++)
                        {
                            // Initially, compares value supplied by user against exponent of 2 returned by CalcMaxPower
                            if (remainingAmount >= (Math.Pow(2, powerOfTwo)))
                            {
                                result += "1";
                                remainingAmount -= ((int)Math.Pow(2, powerOfTwo)); 
                            }

                            // If first value of the above if statement is false, this statement prevents the insertion of a leading zero into the string
                            else if (i != 0)
                            {
                                result += "0";
                            }

                            // Apply a space between every four characters of binary number
                            if (powerOfTwo % 4 == 0 && powerOfTwo > 0 && i != 0) 
                            {
                                result += " ";
                            }

                            powerOfTwo--;
                            i++;
                        }                                              
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n\n" +
                    ex.GetType().ToString() + "\n" +
                    ex.StackTrace, "Exception");
            }
            return result;
        }

        /// <summary>
        /// Convert integer to a hexadecimal string
        /// </summary>
        /// <param name="baseTenInput"></param>
        /// <returns>string</returns>
        private string ConvertIntegerToHex(string baseTenInput)
        {
            string result = "";

            try
            {
                result = int.Parse(baseTenInput).ToString("X"); 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n\n" +
                    ex.GetType().ToString() + "\n" +
                    ex.StackTrace, "Exception");
            }
            return result;
        }

        /// <summary>
        /// Calculate the minimum exponent of a given base necessary to contain an integer value
        /// </summary>
        /// <param name="baseTenAmount"></param>
        /// <param name="baseN"></param>
        /// <returns>int</returns>
        public int CalcMinPower(int baseTenAmount, int baseN)
        {
            int p;
            for (p = 0; Math.Pow(baseN, p) < baseTenAmount; p++)
            { }
            return p;
        }

        /// <summary>
        /// Create a string that holds the formatted result of a calculation
        /// </summary>
        /// <param name="input"></param>
        /// <returns>string</returns>
        private string GenerateResult(string input)
        {
            string result = "";
            result = ConvertIntegerToHex(input);
            return result;
        }

        private string GenerateAreaFromCircleRadiusAnswer()
        {
            string result= "";

            return result;
        }

    }
}
