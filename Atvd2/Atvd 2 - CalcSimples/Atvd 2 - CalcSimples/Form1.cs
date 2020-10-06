using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atvd_2___CalcSimples
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            double Num1, Num2;

            if (double.TryParse(textNum1.Text, out Num1) && (double.TryParse(textNum2.Text, out Num2)))
            {
                double Num3;

                Num3 = Num1 * Num2;

                textNum3.Text = Num3.ToString("N2");
            }
            else
                MessageBox.Show("Valores Invalidos");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textNum1.Clear();
            textNum2.Clear();
            textNum3.Clear();
            textNum1.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double Num1, Num2;

            if (double.TryParse(textNum1.Text, out Num1) && (double.TryParse(textNum2.Text, out Num2)))
            {
                double Num3;

                Num3 = Num1 + Num2;

                textNum3.Text = Num3.ToString("N2");
            }
            else
                MessageBox.Show("Valores Invalidos");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double Num1, Num2;

            if (double.TryParse(textNum1.Text, out Num1) && (double.TryParse(textNum2.Text, out Num2)))
            {
                double Num3;

                Num3 = Num1 - Num2;

                textNum3.Text = Num3.ToString("N2");
            }
            else
                MessageBox.Show("Valores Invalidos");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            double Num1, Num2;

            if (double.TryParse(textNum1.Text, out Num1) && (double.TryParse(textNum2.Text, out Num2)))
            {
                double Num3;

                Num3 = Num1 / Num2;

                textNum3.Text = Num3.ToString("N2");
            }
            else
                MessageBox.Show("Valores Invalidos");
        }

        private void textNum1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)13)
            {
                SendKeys.Send("{TAB}");
                e.Handled = true;
            }
        }

        private void textNum2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
