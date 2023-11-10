using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace classeImovel
{
    public partial class CadImovel : Form
    {
        public CadImovel()
        {
            InitializeComponent();
        }
        int i = 0;
        //Criando Array de Classes
        Imovel[] objImovel = new Imovel[10];
        // Construtor
        

        private void bntCadastro_Click(object sender, EventArgs e)
        {
            try
            {
                // Construtor
                objImovel[i] = new Imovel();

                // atribui valor aos atributos com os set's

                objImovel[i].setId(Convert.ToInt16(txtId.Text));
                objImovel[i].setTipo(cbxTipo.Text);
                objImovel[i].setProprietario(txtNome.Text);
                objImovel[i].setEndereco(txtEndereco.Text);
                objImovel[i].setPreco(Convert.ToDouble(txtPreco.Text));
                objImovel[i].setNumQuarto(Convert.ToInt16(txtNumQ.Text));
                objImovel[i].setNumBanheiro(Convert.ToInt16(txtNumB.Text));
                objImovel[i].setNumGaragem(Convert.ToInt16(txtNumG.Text));
                objImovel[i].setArea(Convert.ToDouble(txtArea.Text));



                // acessando os métodos get's
                ltbResultado.Items.Add("ID: " + objImovel[i].getId());
                ltbResultado.Items.Add("Tipo: " + objImovel[i].getTipo());
                ltbResultado.Items.Add("Proprietário: " + objImovel[i].getProprietario());
                ltbResultado.Items.Add("Endereço: " + objImovel[i].getEndereco());
                ltbResultado.Items.Add("Preço: " + objImovel[i].getPreco().ToString("C"));//formatação monetaria
                ltbResultado.Items.Add("Número de Quarto: " + objImovel[i].getNumQuarto());
                ltbResultado.Items.Add("Número de Banheiro: " + objImovel[i].getNumBanheiro());
                ltbResultado.Items.Add("Vaga de Garagem: " + objImovel[i].getNumGaragem());
                ltbResultado.Items.Add("Área Contruida: " + objImovel[i].getArea().ToString("N") + " m²"); //Formatação numeros
                ltbResultado.Items.Add("=================================");

                i++;


            }

            catch (FormatException)
            {
                MessageBox.Show("Erro de Inclusão");
            }

        }

        private void bntLimpar_Click(object sender, EventArgs e)
        {
            txtId.Text = string.Empty;
            cbxTipo.Text = string.Empty;
            txtNome.Text = string.Empty;
            txtEndereco.Text = string.Empty;
            txtPreco.Text = string.Empty;
            txtNumQ.Value = 0;
            txtNumB.Value = 0;
            txtNumG.Value = 0;
            txtArea.Text = string.Empty;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bntCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                 // Construtor
                objImovel[i] = new Imovel();
                objImovel[i].calcula(Convert.ToDouble(txtPreco.Text), Convert.ToDouble(txtArea.Text));
                ltbResultado.Items.Add("Preço por m²: " + objImovel[i].getPrecoM().ToString("C") + " m²");
                ltbResultado.Items.Add("=================================");

                i++;
            }
            catch (FormatException)
            {
                MessageBox.Show("Erro de Inclusão");
            }
        }
    }
}
