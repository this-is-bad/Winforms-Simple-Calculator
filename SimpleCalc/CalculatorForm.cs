using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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

        }
        private void btn_num0_Click(object sender, EventArgs e)
        {
            InsertCharacter("0");
        }

        private void btn_num1_Click(object sender, EventArgs e)
        {
            InsertCharacter("1");
        }

        private void btn_num2_Click(object sender, EventArgs e)
        {
            InsertCharacter("2");
        }

        private void btn_num3_Click(object sender, EventArgs e)
        {
            InsertCharacter("3");
        }

        private void btn_num4_Click(object sender, EventArgs e)
        {
            InsertCharacter("4");
        }

        private void btn_num5_Click(object sender, EventArgs e)
        {
            InsertCharacter("5");
        }

        private void btn_num6_Click(object sender, EventArgs e)
        {
            InsertCharacter("6");
        }

        private void btn_num7_Click(object sender, EventArgs e)
        {
            InsertCharacter("7");
        }

        private void btn_num8_Click(object sender, EventArgs e)
        {
            InsertCharacter("8");
        }

        private void btn_num9_Click(object sender, EventArgs e)
        {
            InsertCharacter("9");
        }

        private void btn_dec_point_Click(object sender, EventArgs e)
        {
            InsertCharacter(".");
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_subtract_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_multiply_Click(object sender, EventArgs e)
        {

        }

        private void btn_divide_Click(object sender, EventArgs e)
        {

        }
        public void InsertCharacter(String s)
        {
            if (s == "." && txt_value1.Text.Contains("."))
            {
                int old_index = txt_value1.Text.IndexOf(".");
                int new_index = txt_value1.SelectionStart;

                if (old_index != -1)
                {
                    txt_value1.Text = txt_value1.Text.Replace(".", "");
                    new_index = (old_index < new_index) ? new_index - 1 : new_index;
                }

                
                txt_value1.Text = txt_value1.Text.Insert(new_index, s);
            }
            else
            {
                txt_value1.Paste(s);
            }
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Calculate_Click(object sender, EventArgs e)
        {
            SolutionForm solutionForm = new SolutionForm();
            passNumberDelegate pnd = new passNumberDelegate(solutionForm.DisplayResult);
            pnd(this.txt_value1);
            solutionForm.ShowDialog();
        }

        private void btn_Help_Click(object sender, EventArgs e)
        {
            HelpForm helpForm = new HelpForm();

            helpForm.ShowDialog();
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            txt_value1.Clear();
        }

        private void txt_value1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
