using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classe_cadastro_usuario
{
    public class Usuario
    {
        //declaração dos atributos
        public string nome { set; get; }
        public string matricula { set; get; }
        public DateTime dataNasc { set; get; }
        public string endereco { set; get; }
        public int idade { set; get; }
        //método construtor para a classe
        public Usuario()
        {
            this.nome = "";
            this.matricula = "";
            this.dataNasc = DateTime.Today;
            this.endereco = "";
            this.idade = 0;
        }


        //método de funcionalidade
        public void calculaIdade()
        {
            this.idade = DateTime.Today.Year - dataNasc.Year;
        }

        //método getIdade
        public int getIdade()
        {
            return this.idade;
        }

    }

}
