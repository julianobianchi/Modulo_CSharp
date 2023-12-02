using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jogo_Loteria
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int contClick = 0;
        string[] selectNum = new string[15];
        int[] vetor = new int[30];
        int[] aposta = new int[20];
        int[] numerosEscolhidos = new int[20];
       // int contEscolhido = 0;
        int numSorte = 0;

        private void clickNum(object sender, EventArgs e)
        {
            try
            {
                numSorte = Convert.ToInt16(tbxnumAposta.Text);
                int i = 0;
                Label clickNum = sender as Label;
                
                if (clickNum != null)
                {
                    if (contClick <= numSorte)
                    {
                        i++;
                        contClick++;
                        if (contClick <= numSorte)
                        {
                            clickNum.BackColor = Color.Yellow;
                            selectNum[contClick - 1] = clickNum.Text;
                            numerosEscolhidos[contClick] = Convert.ToInt16(clickNum.Text);
                            numEscolhidos.Text += selectNum[contClick - 1] + "  ";
                            aposta[i]= Convert.ToInt16(clickNum.Text);
                            txtaposta.Text += aposta[i].ToString();
                        }
                    }
                    
                }
                if (numSorte == 6)
                    lbtValorAposta.Text = "R$ 5,00";
                if (numSorte == 7)
                    lbtValorAposta.Text = "R$ 35,00";
                if (numSorte == 8)
                    lbtValorAposta.Text = "R$ 140,00";
                if (numSorte == 9)
                    lbtValorAposta.Text = "R$ 420,00";
                if (numSorte == 10)
                    lbtValorAposta.Text = "R$ 1.050,00";
                if (numSorte == 11)
                    lbtValorAposta.Text = "R$ 2.310,00";
                if (numSorte == 12)
                    lbtValorAposta.Text = "R$ 4.620,00";
                if (numSorte == 13)
                    lbtValorAposta.Text = "R$ 8.580,00";
                if (numSorte == 14)
                    lbtValorAposta.Text = "R$ 15.015,00";
                if (numSorte == 15)
                    lbtValorAposta.Text = "R$ 25.025,00";
                if (numSorte >= 16)
                    lbtValorAposta.Text = "Aposta Inválida";

            }
            catch (FormatException)
            {
                MessageBox.Show("Erro de Sorteio!!!", "ERRO", MessageBoxButtons.OK);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                
                lbtSorteio.Text = string.Empty;

                Random randNum1 = new Random();
                for (int i = 1; i < 7; i++)
                {
                    int numSorteado;

                    do
                    {
                        numSorteado = randNum1.Next(1, 61);
                    } while (Array.Exists(vetor, num => num == numSorteado));

                     vetor[i] = numSorteado;
                     lbtSorteio.Text += vetor[i].ToString();
                     lbtSorteio.Text += "  ";
                 
                }

                comparaJogoResultado();

            }
            catch (FormatException)
            {
                MessageBox.Show("Erro Sorteio");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
           Close();
        }
        private void comparaJogoResultado()
        {
            int contagenDeAcertos = 0;
                 
            for (int i = 0; i < 6;i++)
            {
               for (int j = 0;j < numerosEscolhidos.Length; j++)
                {
                    if (vetor[i] == numerosEscolhidos[j])
                    {
                        contagenDeAcertos++;
                        txtaposta.Text += aposta[j].ToString();
                    }
                }
            }
            switch (contagenDeAcertos)
            {
                case 0:
                    lblResultadoAcertos.Text = "0 ACERTOS";
                    break;
                case 1:
                    lblResultadoAcertos.Text = "1 ACERTOS";
                    break;
                case 2:
                    lblResultadoAcertos.Text = "2 ACERTOS";
                    break;
                case 3:
                    lblResultadoAcertos.Text = "3 ACERTOS";
                    break;
                case 4:
                    lblResultadoAcertos.Text = "4 ACERTOS";
                    break;
                case 5:
                    lblResultadoAcertos.Text = "5 ACERTOS";
                    break;
                case 6:
                    lblResultadoAcertos.Text = "6 ACERTOS";
                    break;
            }

        } 
    }
}
