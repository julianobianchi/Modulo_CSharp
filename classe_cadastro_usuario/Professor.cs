using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classe_cadastro_usuario
{
    public class Professor:Usuario
    {
        public int cargaHoraria { set; get; }
        public string tipo { set; get; }


        public Professor()
        {
            this.cargaHoraria = 0;
            this.tipo = "";
        }

        //método para atribuir valor ao tipo
        public void setTipo()
        {
            if (this.cargaHoraria >= 50)
            {
                this.tipo = "Dedicação Integral";
            }
            else
            {
                this.tipo = "Convidado";
            }
        }

    }
}
