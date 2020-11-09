using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atvd6___Menu_e_Metodos
{
    public partial class frmExercicio5 : Form
    {
        public frmExercicio5()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox1.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "" && textBox2.Text == "")
            {
                MessageBox.Show("Digite os Numeros");
            }
            else
            {
                int Num1, Num2, Result;

                if(int.TryParse(textBox1.Text, out Num1) && (int.TryParse(textBox2.Text, out Num2)))
                {
                    Random Aleatorio = new Random();

                    Result = Aleatorio.Next(Num1, Num2 + 1);

                    MessageBox.Show("O Sorteio deu: " + Result);
                }
            }
        }
    }
}
