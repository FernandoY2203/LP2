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
    public partial class frmExercicio3 : Form
    {
        public frmExercicio3()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textPalavra1.Clear();
            textPalavra2.Clear();
            textPalavra1.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String Palavra1, Palavra2, Result;
            int NumPosicao;

            Palavra1 = textPalavra1.Text;
            Palavra2 = textPalavra2.Text;

            if(Palavra1 == "" && Palavra2 == "")
            {
                MessageBox.Show("Digite Uma Palavra");
            }
            else
            {
                NumPosicao = Palavra2.IndexOf(Palavra1);

                while(NumPosicao >= 0)
                {
                    Result = Palavra2.Substring(0, NumPosicao) + Palavra2.Substring(NumPosicao + Palavra1.Length, Palavra2.Length - Palavra1.Length - NumPosicao);

                    Palavra2 = Result;

                    textPalavra2.Text = Result;

                    NumPosicao = Palavra2.IndexOf(Palavra1);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String Palavra1, Palavra2;

            Palavra1 = textPalavra1.Text;
            Palavra2 = textPalavra2.Text;

            if(Palavra2 == "")
            {
                MessageBox.Show("Escreva Uma Palavra");
            }
            else
            {
                Palavra1 = Palavra1.Replace(Palavra2, "");

                textPalavra1.Text = Palavra1;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            String Palavra1;
            char[] Arr;

            Palavra1 = textPalavra1.Text;

            Arr = Palavra1.ToCharArray();

            Array.Reverse(Arr);

            foreach (char c in Arr)

                textPalavra2.Text += c;
        }
    }
}
