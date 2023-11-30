using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Jogo
{
    public partial class Jogos : Form
    {
        public Jogos()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Mega mega = new Mega();
            mega.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Bicho bicho = new Bicho();
            bicho.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 inicio = new Form1();
            inicio.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

