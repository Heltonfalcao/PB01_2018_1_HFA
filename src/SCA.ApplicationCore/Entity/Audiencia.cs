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
        public String Detalhes { get; set; }


    }
}
