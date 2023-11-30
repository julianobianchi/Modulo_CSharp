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

namespace Projeto_Jogo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bntSelecao_Click(object sender, EventArgs e)
        {
            Jogos jogos = new Jogos();
            jogos.Show();
        }

        private void bntSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bntCadastro_Click(object sender, EventArgs e)
        {
            try
            {
                // Construtor
                Jogo objJogador = new Jogo();
                // atribui valor aos atributos com os set's
                objJogador.nomeJogador = txbNome.Text;
                objJogador.emailJogador = txbEmail.Text;
                objJogador.cpfJogador = txbCPF.Text;
                objJogador.loginJogador = txbLogin.Text;
                objJogador.senhaJogador= txbSenha.Text;
                objJogador.dataNascimento = txbData.Value;



            }

            catch (FormatException)
            {
                MessageBox.Show("Erro de Cadastro!");
            }
        }
    }
}
