using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atvd7
{
    public partial class frmExercicio4 : Form
    {
        public frmExercicio4()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox1.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double Sal, Grat, Prod, SalBrut, A, B, C, D;
            String Nome;

            Prod = Convert.ToDouble(textBox4.Text);
            Sal = Convert.ToDouble(textBox5.Text);
            Grat = Convert.ToDouble(textBox6.Text);
            
            Nome = textBox1.Text;


            if (Prod >= 100)
            {
                B = 1;
            }
            else
            {
                B = 0;
            }

            if (Prod >= 120)
            {
                C = 1;
            }
            else
            {
                C = 0;
            }

            if (Prod >= 150)
            {
                D = 1;
            }
            else
            {
                D = 0;
            }

            SalBrut = Sal + Sal * (0.05 * B + 0.1 * C + 0.1 * D) + Grat;

            if (SalBrut > 7000)
            {
                if (Prod >= 150 && Grat > 0)
                {
                    SalBrut = SalBrut;
                }
                else
                {
                    SalBrut = 7000;
                }
            }
            MessageBox.Show("O Salario Bruto de " + Nome + " é de: " + SalBrut);
        }
    }
}
