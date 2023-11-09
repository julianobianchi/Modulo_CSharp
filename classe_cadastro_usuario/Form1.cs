namespace classe_cadastro_usuario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                Usuario objUsuario = new Usuario();

                objUsuario.nome = txbNome.Text;
                objUsuario.matricula = txbMatricula.Text;
                objUsuario.endereco = txbEndereco.Text;
                objUsuario.dataNasc = dtpDataNasc.Value;
                //m�todo de funcionalidade da classe usuario
                //s� posso chamar depois de atribuir o valor da data de nasc
                objUsuario.calculaIdade();


                MessageBox.Show("Usu�rio Cadastrado com Sucesso!!!\nNome: " + objUsuario.nome +
                    "\nMatricula: " + objUsuario.matricula + "\nEndere�o: " +
                    objUsuario.endereco + "\nData Nascimento: " +
                    objUsuario.dataNasc.ToString() + "\nIdade: " +
                    objUsuario.getIdade().ToString(), "Confirma��o Cadastro",
                    MessageBoxButtons.OK);


            }
            catch (FormatException)
            {
                MessageBox.Show("Erro de Convers�o!!!", "ERRO", MessageBoxButtons.OK);
            }
        }

        private void btnCadastrarAluno_Click(object sender, EventArgs e)
        {
            try
            {
                Aluno novoAluno = new Aluno();

                novoAluno.nome = txbNome.Text;
                novoAluno.matricula = txbMatricula.Text;
                novoAluno.endereco = txbEndereco.Text;
                novoAluno.dataNasc = dtpDataNasc.Value;
                //m�todo de funcionalidade da classe usuario
                //s� posso chamar depois de atribuir o valor da data de nasc
                novoAluno.calculaIdade();
                novoAluno.turma = txbTurma.Text;
                novoAluno.nota1 = double.Parse(txbNota1.Text);
                novoAluno.nota2 = double.Parse(txbNota2.Text);
                novoAluno.calculaMedia();


                MessageBox.Show("Aluno Cadastrado com Sucesso!!!\nNome: " +
                    novoAluno.nome +
                    "\nMatricula: " + novoAluno.matricula + "\nEndere�o: " +
                    novoAluno.endereco + "\nData Nascimento: " +
                    novoAluno.dataNasc.ToString() + "\nIdade: " +
                    novoAluno.getIdade().ToString() +
                    "\nTurma: " + novoAluno.turma +
                    "\nNota 1 " + novoAluno.nota1.ToString() +
                    "\nNota 2 " + novoAluno.nota2.ToString() +
                    "\nM�dia: " + novoAluno.retornaMedia().ToString() +
                    "\nO aluno est� " + novoAluno.verificaAprovacao(),


                    "Confirma��o Cadastro",
                    MessageBoxButtons.OK);



            }
            catch (FormatException)
            {
                MessageBox.Show("Erro de Convers�o!!!", "ERRO",
                    MessageBoxButtons.OK);
            }
        }

        private void btnCadastrarProfessor_Click(object sender, EventArgs e)
        {
            try
            {
                Professor novoProfessor = new Professor();

                novoProfessor.nome = txbNome.Text;
                novoProfessor.matricula = txbMatricula.Text;
                novoProfessor.endereco = txbEndereco.Text;
                novoProfessor.dataNasc = dtpDataNasc.Value;
                //m�todo de funcionalidade da classe usuario
                //s� posso chamar depois de atribuir o valor da data de nasc
                novoProfessor.calculaIdade();
                novoProfessor.cargaHoraria = int.Parse(txbCargaHoraria.Text);
                novoProfessor.setTipo();

                MessageBox.Show("Professor Cadastrado com Sucesso!!!\nNome: " +
                    novoProfessor.nome +
                    "\nMatricula: " + novoProfessor.matricula + "\nEndere�o: " +
                    novoProfessor.endereco + "\nData Nascimento: " +
                    novoProfessor.dataNasc.ToString() + "\nIdade: " +
                    novoProfessor.getIdade().ToString() +
                    "\nCargaHoraria: " + novoProfessor.cargaHoraria.ToString() +
                    "\nTipo Professor: " + novoProfessor.tipo,


                    "Confirma��o Cadastro",
                    MessageBoxButtons.OK);



            }
            catch (FormatException)
            {
                MessageBox.Show("Erro de Convers�o!!!", "ERRO",
                    MessageBoxButtons.OK);
            }
        }
    }
}