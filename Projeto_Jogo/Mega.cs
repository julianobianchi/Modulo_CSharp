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
    public partial class Mega : Form
    {
        public Mega()
        {
            InitializeComponent();
        }

        private void label63_Click(object sender, EventArgs e)
        {

        }

        private void lbtSorteio_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Jogos jogos = new Jogos();
            jogos.Show();
        }
    }
}

