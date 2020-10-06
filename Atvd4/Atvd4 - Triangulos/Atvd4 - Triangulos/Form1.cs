using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atvd4___Triangulos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textLado1.Clear();
            textLado2.Clear();
            textLado3.Clear();
            textResult.Clear();
            textLado1.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double Lado1, Lado2, Lado3;

            if (double.TryParse(textLado1.Text, out Lado1) && (double.TryParse(textLado2.Text, out Lado2) && (double.TryParse(textLado3.Text, out Lado3))))
            {
                if(Math.Abs(Lado2 - Lado3) < Lado1 && Lado1 < (Lado2 + Lado3) && 
                    Math.Abs(Lado1 - Lado3) < Lado2 && Lado2 < (Lado1 + Lado3) && 
                    Math.Abs(Lado1 - Lado2) < Lado3 && Lado3 < (Lado1 + Lado2))
                {
                    if ((Lado1 == Lado2) && (Lado1 == Lado3) && (Lado2 == Lado3))
                    {
                        textResult.Text = ("O Triangulo è Equilatero");
                    }
                    else
                    {
                        if ((Lado1 == Lado2) || (Lado1 == Lado3) || (Lado2 == Lado3))
                        {
                            textResult.Text = ("O Triangulo è Isosceles");
                        }
                        else
                        {
                            textResult.Text = ("O Triangulo è Escaleno");
                        }
                    }
                }
                else
                    MessageBox.Show("Valores Invalidos");
            }
            else
                MessageBox.Show("Valores Invalidos");
        }
    }
}
