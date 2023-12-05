namespace Calculado_Basica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private double num1, num2;
        private string operacao;

        private void btn1_Click(object sender, EventArgs e)
        {

        }

        private void btn0_Click(object sender, EventArgs e)
        {

        }

        private void btnNumero(object sender, EventArgs e)
        {
            Button botao = (Button)sender;
            txtVisor.Text += botao.Text;
            lblOperacao.Text += botao.Text;
        }

        private void btnOperacao(object sender, EventArgs e)
        {
            Button botao = (Button)sender;

            if (botao.Text == "+")
            {

                num1 = Convert.ToDouble(txtVisor.Text);
                txtVisor.Clear();
                operacao = "+";
                lblOperacao.Text += operacao;
            }
            else if (botao.Text == "-")
            {
                num1 = Convert.ToDouble(txtVisor.Text);
                txtVisor.Clear();
                operacao = "-";
                lblOperacao.Text += operacao;
            }
            else if (botao.Text == "*")
            {
                num1 = Convert.ToDouble(txtVisor.Text);
                txtVisor.Clear();
                operacao = "*";
                lblOperacao.Text += operacao;
            }
            else if (botao.Text == "/")
            {
                num1 = Convert.ToDouble(txtVisor.Text);
                txtVisor.Clear();
                operacao = "/";
                lblOperacao.Text += operacao;
            }
            else if (botao.Text == "=")
            {
                num2 = Convert.ToDouble(txtVisor.Text);
                txtVisor.Clear();

                if (operacao == "+")
                {
                    txtVisor.Text = Convert.ToString(num1 + num2);
                    lblOperacao.Text += "=" + txtVisor.Text;
                }
                else if (operacao == "-")
                {
                    txtVisor.Text = Convert.ToString(num1 - num2);
                    lblOperacao.Text += "=" + txtVisor.Text;
                }
                else if (operacao == "*")
                {
                    txtVisor.Text = Convert.ToString(num1 * num2);
                    lblOperacao.Text += "=" + txtVisor.Text;
                }
                else if (operacao == "/")
                {
                    txtVisor.Text = Convert.ToString(num1 / num2);
                    lblOperacao.Text += "=" + txtVisor.Text;
                }
            }
        }

        private void btnCe_Click(object sender, EventArgs e)
        {
            txtVisor.Clear();
            lblOperacao.Text = string.Empty;
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            if (txtVisor.Text.Length > 0)
            {
                txtVisor.Text = txtVisor.Text.Substring(0, txtVisor.Text.Length - 1);

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int lenght = txtVisor.TextLength - 1;
            string text = txtVisor.Text;
            txtVisor.Clear();
            lblOperacao.Text = string.Empty;

            for (int i = 0; i < lenght; i++)
                txtVisor.Text = txtVisor.Text + text[i];
            lblOperacao.Text = txtVisor.Text;

        }

        private void btnPorcento_Click(object sender, EventArgs e)
        {
            double porcentagem = Convert.ToDouble(txtVisor.Text) / 100;
            txtVisor.Text = Convert.ToString(porcentagem);
        }

        int check = 1;
        private void btnMaisOuMenos_Click(object sender, EventArgs e)
        {
            if (txtVisor.TextLength > 0)
            {
                string text = txtVisor.Text;
                if (check == 1)
                {
                    txtVisor.Text = "-" + txtVisor.Text;
                    check = 2;
                }
                else if (check == 2)
                {
                    int lenght = txtVisor.TextLength; txtVisor.Clear();
                    for (int i = 1; i < lenght; i++) { txtVisor.Text = txtVisor.Text + text[i]; }
                    check = 1;
                }
            }
        }

        private void btn1x_Click(object sender, EventArgs e)
        {
            txtVisor.Text = (1 / float.Parse(txtVisor.Text)).ToString();
        }

        private void btnXquadrado_Click(object sender, EventArgs e)
        {
            double sqrt = Math.Pow(float.Parse(txtVisor.Text),2);
            txtVisor.Text = sqrt.ToString();
        }

        private void btnRaiz_Click(object sender, EventArgs e)
        {
            double sqrt = Math.Sqrt(float.Parse(txtVisor.Text));
            txtVisor.Text = sqrt.ToString();
        }
    }
}