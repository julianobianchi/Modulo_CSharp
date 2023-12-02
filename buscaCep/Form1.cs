using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace buscaCep
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                using (var ws = new WSCorreios.AtendeClienteClient())
                {
                    var resultado = ws.consultaCEP(txbCEP.Text);
                    txbRua.Text = resultado.end;
                    //txbComp1.Text = resultado.complemento;
                    txbComp2.Text = resultado.complemento2;
                    txbCidade.Text = resultado.cidade;
                    txbBairro.Text = resultado.bairro;
                    txbEstado.Text = resultado.uf;
                }
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
