using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Culturacalendario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPreencherDiasSemana_Click(object sender, EventArgs e)
        {
            try
            {
                cbxDiasSemana.Items.Clear();
                DateTime dia = DateTime.Now;
                CultureInfo idioma = new CultureInfo("pt-BR");
                for (int d = 1; d <= 7; d++)
                {
                    dia = dia.AddDays(1);
                    cbxDiasSemana.Items.Add(dia.ToString("D", idioma));
                }
            }
            catch { 
            
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DateTime dia = DateTime.Now;
            lblDia.Text = dia.ToString("dd/MM/yyyy");
        }

        private void bntCalendario_Click(object sender, EventArgs e)
        {
            Calendario calendario = new Calendario();
            calendario.Show();
        }

        private void bntCalculadora_Click(object sender, EventArgs e)
        {
            Calculadora calculadora = new Calculadora();
            calculadora.Show();
        }
    }
}
