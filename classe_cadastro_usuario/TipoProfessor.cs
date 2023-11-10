using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classe_cadastro_usuario
{
    public class TipoProfessor:Professor
    {
        public string tipomProfessor { set; get; }

        public TipoProfessor() 
        {
            this.tipomProfessor = "";
        }
    }
}
