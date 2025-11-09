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
    public partial class StandardForm : Form
    {
        double Temp;
        double Result;
        string operatorSign;

        public StandardForm()
        {
            InitializeComponent();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Standard Calculator\nCreated in C# Windows Forms \n\n By Sofonias Dawit and Kalkidan \n 2025", "About Calculator", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void txtOutput_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (txtOutput.Text == "0")
                txtOutput.Text = btn1.Text;
            else
                txtOutput.Text += btn1.Text;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (txtOutput.Text == "0")
                txtOutput.Text = btn2.Text;
            else
                txtOutput.Text += btn2.Text;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (txtOutput.Text == "0")
                txtOutput.Text = btn3.Text;
            else
                txtOutput.Text += btn3.Text;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (txtOutput.Text == "0")
                txtOutput.Text = btn4.Text;
            else
                txtOutput.Text += btn4.Text;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (txtOutput.Text == "0")
                txtOutput.Text = btn5.Text;
            else
                txtOutput.Text += btn5.Text;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (txtOutput.Text == "0")
                txtOutput.Text = btn6.Text;
            else
                txtOutput.Text += btn6.Text;
        }
        private void btn7_Click(object sender, EventArgs e)
        {
            if (txtOutput.Text == "0")
                txtOutput.Text = btn7.Text;
            else
                txtOutput.Text += btn7.Text;
        }
        private void btn8_Click(object sender, EventArgs e)
        {
            if (txtOutput.Text == "0")
                txtOutput.Text = btn8.Text;
            else
                txtOutput.Text += btn8.Text;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (txtOutput.Text == "0")
                txtOutput.Text = btn9.Text;
            else
                txtOutput.Text += btn9.Text;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (txtOutput.Text == "0")
                txtOutput.Text = btn0.Text;
            else
                txtOutput.Text += btn0.Text;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            operatorSign = "+";
            Temp = Double.Parse(txtOutput.Text);
            txtOutput.Text = "0";
        }

        private void btnSubstract_Click(object sender, EventArgs e)
        {
            operatorSign = "-";
            Temp = Double.Parse(txtOutput.Text);
            txtOutput.Text = "0";
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            operatorSign = "*";
            Temp = Double.Parse(txtOutput.Text);
            txtOutput.Text = "0";
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            operatorSign = "/";
            Temp = Double.Parse(txtOutput.Text);
            txtOutput.Text = "0";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Temp = 0;
            operatorSign = " ";
            txtOutput.Text = "0";
        }

        private void txtClear_Click(object sender, EventArgs e)
        {
            txtOutput.Text = " ";
            txtOutput.Text = "0";
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            Result = double.Parse(txtOutput.Text);

            switch (operatorSign)
            {
                case "+":
                    Result = Temp + Result;
                    txtOutput.Text = Result.ToString();
                    break;
                case "-":
                    Result = Temp - Result;
                    txtOutput.Text = Result.ToString();
                    break;
                case "*":
                    Result = Temp * Result;
                    txtOutput.Text = Result.ToString();
                    break;
                case "/":
                    Result = Temp / Result;
                    txtOutput.Text = Result.ToString();
                    break;
            }
        }

        private void txtBack_Click(object sender, EventArgs e)
        {
            txtOutput.Text = txtOutput.Text.Substring(0, txtOutput.Text.Length - 1);
            if (txtOutput.Text.Length == 0)
                txtOutput.Text = "0";
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            if (!txtOutput.Text.Contains("."))
            {
                txtOutput.Text += ".";
            }
        }

        //private void standardToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    var existingForm = Application.OpenForms["StandardForm"];
        //    if (existingForm == null)
        //    {
        //        // Only create and show the form if it’s not already open
        //        StandardForm std = new StandardForm();
        //        std.Show();
        //    }

        //    // Hide the current form (ScientificForm or any other form)
        //    this.Hide();
        //}

        private void scientificToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ScientificForm sci = new ScientificForm();
            sci.Show();
            this.Hide(); // Hides the current StandardForm
        }
    }
}
