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
    public partial class SolutionForm : Form
    {
        public SolutionForm()
        {
            InitializeComponent();
        }

        public SolutionForm(string calculatedValue)
        {
            InitializeComponent();
            DisplayResult(calculatedValue);
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void DisplayResult(TextBox txt)
        {
            lbl_Result.Text = txt.Text;
        }

        public void DisplayResult(string result)
        {
            lbl_Result.Text = result;
        }
    }
}
