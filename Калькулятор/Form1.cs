using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Калькулятор
{
    public partial class Form1 : Form
    {
        Double resultValue = 0;
        String opPerformed = "";
        bool isOpPerformed = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void n_click(object sender, EventArgs e)
        {

            if ((textBox.Text == "0") || (isOpPerformed))
                textBox.Clear();

            isOpPerformed = false;
            Button n = (Button)sender;
            if (n.Text == ".")
            {
                if (!textBox.Text.Contains("."))
                    textBox.Text = textBox.Text + n.Text;
            }
            else
                textBox.Text = textBox.Text + n.Text;

        }

        private void op_click(object sender, EventArgs e)
        {
            Button n = (Button)sender;
            if (resultValue != 0)
            {
                nequal.PerformClick();
                opPerformed = n.Text;

                resultValue = Double.Parse(textBox.Text);
                isOpPerformed = true;
            }
            else
            {
                opPerformed = n.Text;
                resultValue = Double.Parse(textBox.Text);
                isOpPerformed = true;
            }
        }

        private void nce_Click(object sender, EventArgs e)
        {
            textBox.Text = "0";
        }

        private void nc_Click(object sender, EventArgs e)
        {
            textBox.Text = "0";
            resultValue = 0;
        }

        private void nequal_Click(object sender, EventArgs e)
        {
            switch (opPerformed)
            {
                case "+":
                    textBox.Text = (resultValue + Double.Parse(textBox.Text)).ToString();
                    break;
                case "-":
                    textBox.Text = (resultValue - Double.Parse(textBox.Text)).ToString();
                    break;
                case "*":
                    textBox.Text = (resultValue * Double.Parse(textBox.Text)).ToString();
                    break;
                case "/":
                    textBox.Text = (resultValue / Double.Parse(textBox.Text)).ToString();
                    break;
                default:
                    break;
            }
            resultValue = Double.Parse(textBox.Text);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            int x = (int)numericUpDown1.Value;
            Button[] x1 = { n0, n1, n2, n3, n4, n5, n6, n7, n8, n9 };
            for (int i = x; i < 10; i++) x1[i].Enabled = false;
            for (int i = 0; i < x; i++) x1[i].Enabled = true;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            int i = Convert.ToInt32(textBox.Text);
            textBox1.Text = Convert.ToString(i, 2);
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            int i = Convert.ToInt32(textBox.Text);
            textBox1.Text = Convert.ToString(i, 8);
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            int i = Convert.ToInt32(textBox.Text);
            textBox1.Text = Convert.ToString(i, 10);
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            int i = Convert.ToInt32(textBox.Text);
            textBox1.Text = Convert.ToString(i, 16);
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            int i = 0;

            if (radioButton1.Checked == true)
            {
                textBox1.Text = Convert.ToString(i, 2);
            }

            else if (radioButton2.Checked == true)
            {
                textBox1.Text = Convert.ToString(i, 8);
            }
            else if (radioButton3.Checked == true)
            {
                textBox1.Text = Convert.ToString(i, 10);
            }
            else if (radioButton3.Checked == true)
            {
                textBox1.Text = Convert.ToString(i, 16);
            }
        }
    }
}