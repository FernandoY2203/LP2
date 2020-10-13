using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atvd5___Desconto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textName.Clear();
            mtbSalBrut.Clear();
            mtbNumFilhos.Clear();
            mtbAliINSS.Clear();
            mtbAliIRPF.Clear();
            mtbSalFam.Clear();
            mtbSalLiq.Clear();
            mtbDescINSS.Clear();
            mtbDescIRPF.Clear();
            lbDescri.Text = "";
            textName.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double SalBrut;
            int NumFilhos;

            if (int.TryParse(mtbNumFilhos.Text, out NumFilhos))
            {
                if (double.TryParse(mtbSalBrut.Text, out SalBrut))
                {
                    string Nome;
                    double descINSS1, descINSS2, descINSS3, descINSS4, Desc, descIRPF = 0, salFami = 0, SalBase, SalLiq;

                    Nome = textName.Text;

                    if(rbSexFem.Checked)
                    {
                        if(rbEstCivSolt.Checked)
                        {
                            lbDescri.Text = "Os Descontos do Salario da Sra." + Nome + "\n" +
                                "que è Solteira \n" +
                                "e tem " + NumFilhos + " Filhos(s) Sao: ";
                        }
                        else
                        {
                            lbDescri.Text = "Os Descontos do Salario da Sra." + Nome + "\n" +
                                "que è Casada \n" +
                                "e tem " + NumFilhos + " Filhos(s) Sao: ";
                        }
                    }
                    else
                        if(rbEstCivSolt.Checked)
                    {
                        lbDescri.Text = "Os Descontos do Salario do Sr." + Nome + "\n" +
                                "que è Solteiro \n" +
                                "e tem " + NumFilhos + " Filhos(s) Sao: ";
                    }
                    else
                    {
                        lbDescri.Text = "Os Descontos do Salario do Sr." + Nome + "\n" +
                                "que è Casado \n" +
                                "e tem " + NumFilhos + " Filhos(s) Sao: ";
                    }

                    if(SalBrut > 1045.00)
                    {
                        descINSS1 = 1045.00 * 0.075;

                        if(SalBrut > 2089.61)
                        {
                            descINSS2 = (2089.61 - 1045.00) * 0.09;

                            if(SalBrut > 3134.41)
                            {
                                descINSS3 = (3134.41 - 2089.61) * 0.12;

                                if(SalBrut > 6101.06)
                                {
                                    descINSS4 = (6101.06 - 3134.41) * 0.14;
                                    mtbAliINSS.Text = "TETO";
                                    Desc = descINSS1 + descINSS2 + descINSS3 + descINSS4;
                                    mtbDescINSS.Text = Desc.ToString("N2");
                                }
                                else
                                {
                                    mtbAliINSS.Text = "14,00%";
                                    descINSS4 = (SalBrut - 3134.41) * 0.14;
                                    Desc = descINSS1 + descINSS2 + descINSS3 + descINSS4;
                                    mtbDescINSS.Text = Desc.ToString("N2");
                                }
                            }
                            else
                            {
                                mtbAliINSS.Text = "12,00%";
                                descINSS3 = (SalBrut - 2089.61) * 0.12;
                                Desc = descINSS1 + descINSS2 + descINSS3;
                                mtbDescINSS.Text = Desc.ToString("N2");
                            }
                        }
                        else
                        {
                            mtbAliINSS.Text = "9,00%";
                            descINSS2 = (SalBrut - 1045.00) * 0.09;
                            Desc = descINSS1 + descINSS2;
                            mtbDescINSS.Text = Desc.ToString("N2");

                        }
                    }
                    else
                    {
                        mtbAliINSS.Text = "7,50%";
                        descINSS1 = SalBrut * 0.075;
                        Desc = descINSS1;
                        mtbDescINSS.Text = Desc.ToString("N2");
                    }

                    SalBase = SalBrut - Desc - (NumFilhos * 189.59);

                    if(SalBase > 1903.98 && SalBase <= 2826.65)
                    {
                        mtbAliIRPF.Text = "7,50%";
                        descIRPF = SalBase * 0.075 - 142.80;
                        mtbDescIRPF.Text = descIRPF.ToString("N2");

                    }
                    else if(SalBase > 2826.65 && SalBase <= 3751.05)
                    {
                        mtbAliIRPF.Text = "15,00%";
                        descIRPF = SalBase * 0.15 - 354.80;
                        mtbDescIRPF.Text = descIRPF.ToString("N2");
                    }
                    else if(SalBase > 3751.05 && SalBase <= 4664.68)
                    {
                        mtbAliIRPF.Text = "22,50%";
                        descIRPF = SalBase * 0.225 - 636.13;
                        mtbDescIRPF.Text = descIRPF.ToString("N2");
                    }
                    else if(SalBase > 4664.68)
                    {
                        mtbAliIRPF.Text = "27.50%";
                        descIRPF = SalBase * 0.275 - 869.36;
                        mtbDescIRPF.Text = descIRPF.ToString("N2");
                    }
                    else
                    {
                        mtbAliIRPF.Text = "0,00%";
                        mtbDescIRPF.Text = "00,00";
                    }

                    if(SalBrut <= 1425.56)
                    {
                        salFami = 48.62 * NumFilhos;
                        mtbSalFam.Text = salFami.ToString("N2");
                    }
                    else
                        mtbSalFam.Text = "00,00";

                    SalLiq = SalBrut - Desc - descIRPF + salFami;
                    mtbSalLiq.Text = SalLiq.ToString("N2");

                }
                else
                    MessageBox.Show("ERRO");
            }
        }
    }
}
