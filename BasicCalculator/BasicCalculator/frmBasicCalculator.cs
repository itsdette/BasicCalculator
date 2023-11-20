using ClassLibrary2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicCalculator
{
    public partial class frmBasicCalculator : Form
    {
        public frmBasicCalculator()
        {
            InitializeComponent();
        }

        private void btnCompute_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == " " && textBox2.Text == " ")
            {
                MessageBox.Show("Error: Please Input a number to compute");

            }
            else if (comboBox1.Text == " ")
            {
                MessageBox.Show("Error: Please Choose Operator");
            }
            else
            {
                float num1 = (float)Convert.ToDouble(textBox1.Text);
                float num2 = (float)Convert.ToDouble(textBox2.Text);

                if (comboBox1.Text == "+")
                {
                    float total = BasicComputation.Addition(num1, num2);
                    string totals = total.ToString();
                    label3.Text = totals;
                }
                else if (comboBox1.Text == "-")
                {
                    float total = BasicComputation.Subtraction(num1, num2);
                    string totals = total.ToString();
                    label3.Text = totals;
                }
                else if (comboBox1.Text == "*")
                {
                    float total = BasicComputation.Multiplication(num1, num2);
                    string totals = total.ToString();
                    label3.Text = totals;
                }
                else if (comboBox1.Text == "/")
                {
                    
                    float total = BasicComputation.Division(num1, num2);
                    string totals = total.ToString();
                    label3.Text = totals;
                }
            }

        }
    }
}
