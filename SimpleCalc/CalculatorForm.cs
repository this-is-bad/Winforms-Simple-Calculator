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
            English,
            Metric
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

        public bool ValidateNumeric(Control control, out string message)
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

        private void btn_Calculate_Click(object sender, EventArgs e)
        {
            SolutionForm solutionForm = new SolutionForm();
            passNumberDelegate pnd = new passNumberDelegate(solutionForm.DisplayResult);
            pnd(this.txt_Value1);
            solutionForm.ShowDialog();
        }

        private void btn_Help_Click(object sender, EventArgs e)
        {
            HelpForm helpForm = new HelpForm();

            helpForm.ShowDialog();
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            txt_Value1.Clear();
        }

        private void txt_value1_TextChanged(object sender, EventArgs e)
        {
            if (!ValidateNumeric(txt_Value1, out string error_message))
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
    }
}
