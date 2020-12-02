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
    public partial class frmExercicio3 : Form
    {
        public frmExercicio3()
        {
            InitializeComponent();
        }

        private void frmExercicio3_Load(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox1.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String Texto, B;
            char[] Vet;
            
            Texto = textBox1.Text.ToUpper().Replace(" ", "");
            B = Texto;
            Vet = B.ToCharArray();
            B = "";

            Array.Reverse(Vet);
       
            foreach (char C in Vet)
            {
                B = B + C.ToString();
            }

            if (Texto == B)
            {
                MessageBox.Show("É um Palindromo");
            }
            else
            {
                MessageBox.Show("Não é um Palindromo");
            }

            Texto = B;
        }
    }
}
