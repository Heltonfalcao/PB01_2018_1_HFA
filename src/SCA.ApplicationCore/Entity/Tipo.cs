using System;
using System.Collections.Generic;
using System.Text;

namespace SCA.ApplicationCore.Entity
{
    public class Tipo
    {
        public Tipo()
        {
        }


        public int TipoId { get; set; }
        public String Descricao { get; set; }
        public int ProcessoId { get; set; }
        public Processo Processo { get; set; }
    }
}
