namespace classeImovel
{
    public partial class Form0 : Form
    {
        public Form0()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void bntImovel_Click(object sender, EventArgs e)
        {
            CadImovel imovel = new CadImovel();
            imovel.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}