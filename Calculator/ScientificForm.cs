using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class ScientificForm : Form
    {
        double Temp;
        double Result;
        string operatorSign;

        public ScientificForm()
        {
            InitializeComponent();
        }
        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void standardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StandardForm std = new StandardForm();
            std.Show();
            this.Hide(); // Hides the current ScientificForm
        }

        private void txtOutput_TextChanged(object sender, EventArgs e)
        {

        }
        private void btnSquare_Click(object sender, EventArgs e)
        {
            double num = double.Parse(txtOutput.Text);
            txtOutput.Text = Math.Pow(num, 2).ToString();
        }

        private void btnSquareRoot_Click(object sender, EventArgs e)
        {
            double num = double.Parse(txtOutput.Text);
            txtOutput.Text = Math.Sqrt(num).ToString();
        }

        private void btnPower_Click(object sender, EventArgs e)
        {
            operatorSign = "xʸ";
            Temp = double.Parse(txtOutput.Text);
            txtOutput.Text = "0";
        }

        private void btnE_Click(object sender, EventArgs e)
        {
            txtOutput.Text = Math.E.ToString();
        }

        private void btnSin_Click(object sender, EventArgs e)
        {
            double num = double.Parse(txtOutput.Text);
            txtOutput.Text = Math.Sin(num * Math.PI / 180).ToString();
        }

        private void btnCos_Click(object sender, EventArgs e)
        {
            double num = double.Parse(txtOutput.Text);
            txtOutput.Text = Math.Cos(num * Math.PI / 180).ToString();
        }

        private void btnTan_Click(object sender, EventArgs e)
        {
            double num = double.Parse(txtOutput.Text);
            txtOutput.Text = Math.Tan(num * Math.PI / 180).ToString();
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            double num = double.Parse(txtOutput.Text);
            txtOutput.Text = Math.Log10(num).ToString();
        }

        private void btnLn_Click(object sender, EventArgs e)
        {
            double num = double.Parse(txtOutput.Text);
            txtOutput.Text = Math.Log(num).ToString();
        }

        private void btnPi_Click(object sender, EventArgs e)
        {
            txtOutput.Text = Math.PI.ToString();
        }

        private void btnFactorial_Click(object sender, EventArgs e)
        {
            int num = int.Parse(txtOutput.Text);
            long factorial = 1;
            for (int i = 1; i <= num; i++)
                factorial *= i;
            txtOutput.Text = factorial.ToString();
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            Result = double.Parse(txtOutput.Text);
            if (!double.TryParse(txtOutput.Text, out Result))
            {
                MessageBox.Show("Please enter a valid number before pressing '='.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            switch (operatorSign)
            {
                case "+":
                    Result = Temp + Result; break;
                case "-":
                    Result = Temp - Result; break;
                case "*":
                    Result = Temp * Result; break;
                case "/":
                    Result = Temp / Result; break;
                case "xʸ":
                    Result = Math.Pow(Temp, Result); break;
            }
            txtOutput.Text = Result.ToString();
        }
        private void txtBack_Click(object sender, EventArgs e)
        {
            if (txtOutput.Text.Length > 1)
                txtOutput.Text = txtOutput.Text.Substring(0, txtOutput.Text.Length - 1);
            else
                txtOutput.Text = "0";
        }

        private void btnNumber_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (txtOutput.Text == "0")
                txtOutput.Text = btn.Text;
            else
                txtOutput.Text += btn.Text;
        }
        private void btnOperator_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            operatorSign = btn.Text;
            Temp = Double.Parse(txtOutput.Text);
            txtOutput.Text = "0";
        }

        private void txtClear_Click(object sender, EventArgs e)
        {
            txtOutput.Text = " ";
            txtOutput.Text = "0";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Temp = 0;
            operatorSign = " ";
            txtOutput.Text = "0";
        }
    }
}

