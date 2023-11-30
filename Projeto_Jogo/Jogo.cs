using System;

namespace Projeto_Jogo
{
    public class Jogo
    {
        //declaração dos atributos
        public string nomeJogador { set; get; }
        public string cpfJogador { set; get; }
        public string loginJogador { set; get; }
        public string senhaJogador { set; get; }
        public string emailJogador { set; get; }
        public DateTime dataNascimento { set; get; }
        public DateTime dataAposta { set; get; }
        public double valorAposta { set; get; }
        public double premio { set; get; }
        public double idadeJogador { set; get; }
        //método construtor para a classe
        public Jogo()
        {
            this.nomeJogador = "";
            this.cpfJogador = "";
            this.loginJogador = "";
            this.senhaJogador = "";
            this.emailJogador = "";       
            this.dataNascimento = DateTime.Today;
            this.dataAposta = DateTime.Today;
            this.valorAposta = 0;
            this.premio = 0;
            this.idadeJogador = 0;

        }




        // Área dos Métodos  (Ações da Classe)

        public void verificaIdade()
        {
            this.idadeJogador = DateTime.Today.Year - dataNascimento.Year;
        }
    }
}