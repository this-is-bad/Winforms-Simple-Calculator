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
            try
            {
                Bitmap bmp = new Bitmap(@"..\..\Images\Bernoulli_computation.bmp");
                this.BackgroundImage = bmp;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message.ToString());
            }
            InitializeComponent();
            DisplayResult(calculatedValue);
        }

        public SolutionForm(CalcResult calculatedValue)
        {
            try
            {
                Bitmap bmp = new Bitmap(@"..\..\Images\Bernoulli_computation.bmp");
                this.BackgroundImage = bmp;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message.ToString());
            }
            InitializeComponent();
            DisplayResult(calculatedValue.ResultText);
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

        private void SolutionForm_Load(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(this, "The first algorithm for a computer program was published in 1843.");
        }
    }
}
