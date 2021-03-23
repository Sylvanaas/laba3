using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace labauniver3
{
    public partial class fmain : Form
    {
        public fmain()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbX1.Text) ||
(String.IsNullOrEmpty(tbX2.Text)))
            {
                tbY.Text = "Не введено даних!";
                return;
            }
            double x1 = double.Parse(tbX1.Text);
            double x2 = double.Parse(tbX2.Text);
            double y = Math.Cos(Math.Sqrt(x2)) + 34*x1 - 4 * Math.Sin(x2);
            tbY.Text = y.ToString("0.######");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbX1.Text = string.Empty;
            tbX2.Text = string.Empty;
            tbY.Text = string.Empty;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tbX1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbX2_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbY_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
