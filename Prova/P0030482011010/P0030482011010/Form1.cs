using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace P0030482011010
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double[,] Matriz = new double[1,4];
            double[] totalMes = new double[1];
            double Total, somaAux;
            int Cont, Cont2;
            string Aux;
            

            Total = 0;
            somaAux = 0;

            Aux = "";

            for (Cont = 0; Cont < 1; Cont++)
            {
                for (Cont2 = 0; Cont2 < 4; Cont2++)
                {
                    Aux = Interaction.InputBox("Digite o Valor Vendido na Semana " + (Cont2 + 1).ToString(), "Mes " + (Cont + 1).ToString());

                    if (double.TryParse(Aux, out Matriz[Cont, Cont2]))
                    {
                        Matriz[Cont,Cont2] = Convert.ToDouble(Aux);
                        Total = Total + Matriz[Cont,Cont2];
                        somaAux = somaAux + Matriz[Cont,Cont2];
                    }
                    else
                    {
                        MessageBox.Show("Apenas Numeros, Verifique Novamente");
                        break;
                    }
                }
                totalMes[Cont] = somaAux;
                somaAux = 0;
            }

            for (Cont = 0; Cont < 1; Cont++)
            {
                listBox1.Items.Add("Mes: " + (Cont + 1).ToString());

                for (Cont2 = 0; Cont2 < 4; Cont2++)
                {
                    listBox1.Items.Add("Semana " + (Cont2 + 1) + (": ") + (" ") + (String.Format("{0:C2}", Matriz[Cont,Cont2])));
                }

                listBox1.Items.Add("Total do Mês: " + (String.Format("{0:C2}", totalMes[Cont])));
                listBox1.Items.Add("\n");
            }

            listBox1.Items.Add("Soma dos Meses: " + (String.Format("{0:C2}", Total)));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }
    }
}
