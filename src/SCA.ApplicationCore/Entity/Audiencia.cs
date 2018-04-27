using System;
using System.Collections.Generic;
using System.Text;

namespace SCA.ApplicationCore.Entity
{
    public class Audiencia
    {
        public Audiencia()
        {
        }

        public int AudienciaId { get; set; }
        public DateTime Data { get; set; }
        public string Detalhes { get; set; }

        public int ProcessoId { get; set; }
        public Processo Processo { get; set; }



    }
}
