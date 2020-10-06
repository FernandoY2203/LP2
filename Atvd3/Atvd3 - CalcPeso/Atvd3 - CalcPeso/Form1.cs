using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atvd3___CalcPeso
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mtbAlt.Clear();
            mtbPeso.Clear();
            mtbAlt.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double Altura, Peso;

            if (double.TryParse(mtbAlt.Text, out Altura) && (double.TryParse(mtbPeso.Text, out Peso)))
            {
                double Result;

                if(rbMasc.Checked)
                {
                    Result = (72.7 * Altura) - 58;

                    if (Result < Peso)
                    {
                        MessageBox.Show("Regime  Obrigatorio Jà");
                        textResult.Text = Result.ToString("N2");
                    }
                    if (Result > Peso)
                    {
                        MessageBox.Show("Coma Bastente Massas e Doces");
                        textResult.Text = Result.ToString("N2");
                    }
                    if(Result == Peso)
                    {
                        MessageBox.Show("Voce esta com o Peso Ideal");
                        textResult.Text = Result.ToString("N2");
                    }
                }
                if(rbFem.Checked)
                {
                    Result = (62.1 * Altura) - 44.7;

                    if (Result < Peso)
                    {
                        MessageBox.Show("Regime  Obrigatorio Jà");
                        textResult.Text = Result.ToString("N2");
                    }
                    if (Result > Peso)
                    {
                        MessageBox.Show("Coma Bastente Massas e Doces");
                        textResult.Text = Result.ToString("N2");
                    }
                    if (Result == Peso)
                    {
                        MessageBox.Show("Voce esta com o Peso Ideal");
                        textResult.Text = Result.ToString("N2");
                    }
                }
                    
            }
            else
                MessageBox.Show("Valores Invalidos");

            
        }
    }
}
