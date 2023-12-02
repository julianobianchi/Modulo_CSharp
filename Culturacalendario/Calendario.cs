using System;
using System.Collections;
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
    public partial class Calendario : Form
    {
        public Calendario()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Calendario_Load(object sender, EventArgs e)
        {
            // define as propriedades do ComboBox 
            cboCultura.DisplayMember = "DisplayName";
            cboCultura.ValueMember = "LCID";
            cboCultura.Sorted = true; // cria um array lista para os locales 
            ArrayList _locales = new ArrayList(); // percorre as cultures 
            foreach (CultureInfo culture in
           CultureInfo.GetCultures(CultureTypes.AllCultures))
            {
                // adiciona o objeto cultureinfo no arraylist 
                _locales.Add(culture);
            } // vincula o arraylist com o combobox 
            cboCultura.DataSource = _locales;
        }

        private void btnExibirData_Click(object sender, EventArgs e)
        {
            CultureInfo idioma = new CultureInfo(cboCultura.Text);
            string formato = cboFormato.Text;
            txtDataSelecionada.Text = mcal1.SelectionRange.Start.ToString(formato,
           idioma);
        }

        private void mcal1_DateChanged(object sender, DateRangeEventArgs e)
        {
            txdDataFormatada.Text = mcal1.SelectionRange.Start.ToLongDateString();
        }

        private void cboCultura_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
