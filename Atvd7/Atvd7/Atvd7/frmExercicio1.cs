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
    public partial class frmExercicio1 : Form
    {
        public frmExercicio1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            richTextBox1.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Contador, Tamanho, Cont;
            String Texto; 

            Contador = 0;
            Texto = richTextBox1.Text;
            Tamanho = richTextBox1.Text.Length;

            for (Cont = 0; Cont < Tamanho; Cont++)
            {
                if (char.IsWhiteSpace(Texto[Cont]))
                {
                    Contador += 1;
                }
            }
            MessageBox.Show("O Numero de Espaços em Branco é: " + Contador);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int Contador, Tamanho, Cont;
            String Texto;

            Contador = 0;
            Tamanho = richTextBox1.Text.Length;
            Texto = richTextBox1.Text.ToLower();

            for (Cont = 0; Cont < Tamanho; Cont++)
            {
                if ((Texto[Cont]) == 'r')
                {
                    Contador += 1;
                }
            }
            MessageBox.Show("A Quantidade de Vezes que R Aparece é: " + Contador);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int Contador, Tamanho, Cont;
            String Texto, Letra;

            Contador = 0;
            Texto = richTextBox1.Text;
            Tamanho = richTextBox1.Text.Length;
            Letra = "";

            for (Cont = 0; Cont < Tamanho; Cont++)
            {
                if ((Texto.Substring(Cont, 1) != "") && (Texto.Substring(Cont, 1) == Letra))
                {
                    Contador += 1;
                }
                Letra = Texto.Substring(Cont, 1);
            }
            MessageBox.Show("O Numeros de Letras Pares é: " + Contador);
        }
    }
}
