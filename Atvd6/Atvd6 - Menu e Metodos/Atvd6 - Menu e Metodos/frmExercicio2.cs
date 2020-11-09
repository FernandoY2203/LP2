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
    public partial class frmExercicio2 : Form
    {
        public frmExercicio2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String Palavra1, Palavra2;
            int Result;

            Palavra1 = textPalavra1.Text;
            Palavra2 = textPalavra2.Text;

            Result = String.Compare(Palavra1, Palavra2);

            if(Result == 0)
            {
                MessageBox.Show("As Palavras sao Iguais");
            }
            else
            {
                MessageBox.Show("As Palavras sao Diferentes");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String Palavra1, Palavra2, Result ;
            int NumMetade;

            Palavra1 = textPalavra1.Text;
            Palavra2 = textPalavra2.Text;

            NumMetade = Palavra2.Length / 2;

            Result = Palavra2.Substring(0, NumMetade) + Palavra1 + Palavra2.Substring(NumMetade, Palavra2.Length - NumMetade);

            textPalavra2.Text = Result;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            String Palavra1, Result;
            int NumMetade;

            Palavra1 = textPalavra1.Text;

            NumMetade = Palavra1.Length / 2;

            Result = Palavra1.Insert(NumMetade, "**");

            textPalavra2.Text = Result;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textPalavra1.Clear();
            textPalavra2.Clear();
            textPalavra1.Focus();
        }
    }
}
