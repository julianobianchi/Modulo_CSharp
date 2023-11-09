using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classe_cadastro_usuario
{
    public class Aluno:Usuario
    {
        public string turma { set; get; }
        public double nota1 { set; get; }
        public double nota2 { set; get; }
        public double media { set; get; }

        public Aluno()
        {
            this.turma = "";
            this.nota1 = 0;
            this.nota2 = 0;
            this.media = 0;
        }



        //método para calcular a media
        public void calculaMedia()
        {
            this.media = (this.nota1 + this.nota2) / 2;
        }
        //método para retornar a média
        public double retornaMedia()
        {
            return this.media;
        }
        //método para verificar a aprovação
        public string verificaAprovacao()
        {
            if (this.media >= 7)
                return "Aprovado";
            else
                return "Reprovado";
        }

    }
}
