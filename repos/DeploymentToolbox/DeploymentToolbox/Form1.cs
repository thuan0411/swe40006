using System;
using System.Windows.Forms;
using DeploymentToolbox.MathEngine;
using DeploymentToolbox.TextUtils;

namespace DeploymentToolbox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtA.Text, out double a) && double.TryParse(txtB.Text, out double b))
            {
                double result = Arithmetic.Add(a, b);
                lblMathResult.Text = "Result: " + result;
            }
            else
            {
                MessageBox.Show("Please enter valid numbers in both fields.", "Deployment Toolbox",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnReverse_Click(object sender, EventArgs e)
        {
            string reversed = StringTools.Reverse(txtInput.Text);
            lblTextResult.Text = "Result: " + reversed;
        }
    }
}
