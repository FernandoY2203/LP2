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
    public partial class frmExercicio2 : Form
    {
        public frmExercicio2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox1.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double N, H, Cont;

            N = Convert.ToDouble(textBox1.Text);
            H = 0;

            for (Cont = N; Cont > 0; Cont--)
            {
                H += 1 / Cont;
            }
            MessageBox.Show("O Numero Gerado é: " + H);
        }
    }
}
