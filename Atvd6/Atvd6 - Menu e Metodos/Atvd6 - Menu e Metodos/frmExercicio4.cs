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
    public partial class frmExercicio4 : Form
    {
        public frmExercicio4()
        {
            InitializeComponent();
        }

        private void frmExercicio4_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            richTextBox1.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Cont, Contador, Tam;
            String Texto;

            Contador = 0;
            Texto = richTextBox1.Text;

            Tam = Texto.Length;

            for (Cont = 0; Cont < Tam; Cont++)
            {
                if (char.IsNumber(Texto[Cont]))
                {
                    Contador ++; 
                }
            }
            MessageBox.Show("O texto tem " + Contador + " Numeros");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int Cont, Cont2, Posicao, Tam;
            String Texto;
            
            Texto = richTextBox1.Text;
            Tam = Texto.Length;
            Cont = 0;
            Cont2 = 0;
            Posicao = 0;

            if (richTextBox1.Text != "")
            {
                while (Cont < Tam)
                {
                    if (char.IsWhiteSpace(richTextBox1.Text[Cont2]))
                    {
                        Posicao = Cont2;
                        Cont = Tam;
                    }
                    else
                    {
                        Posicao++;
                    }

                    Cont2++;
                    Cont++;
                }
                MessageBox.Show("O primeiro espaco em branco esta na posicao: " + (Posicao + 1));
            }
            else
            {
                MessageBox.Show("O primeiro espaco em branco esta na 0");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            String Texto;
            int Cont;
            char[] Arr;

            Cont = 0;

            Texto = richTextBox1.Text;

            Arr = Texto.ToCharArray();

            foreach (char Letras in Arr)
            {
                if (Char.IsLetter(Letras))
                {
                    Cont++;
                }
            }
            MessageBox.Show("O numero de Letras Contida sao: " + Cont);
        }
    }
}
