using System;
using System.Collections.Generic;
using System.Text;

namespace SCA.ApplicationCore.Entity
{
    public class Processo
    {
        public Processo()
        {
        }

        public int ProcessoId { get; set; }
        public DateTime DataEntrada { get; set; }
        public DateTime DataSaida { get; set; }
        public Boolean Situacao { get; set; }

        public int PessoaId { get; set; }
        public Processo Pessoa { get; set; }

        public ICollection<Tipo> Tipos { get; set; }
        public ICollection<Processo> Audiencias { get; set; }
       

            }
}
