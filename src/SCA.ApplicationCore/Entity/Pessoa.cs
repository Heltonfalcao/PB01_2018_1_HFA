using System;
using System.Collections.Generic;
using System.Text;

namespace SCA.ApplicationCore.Entity
{
    public class Pessoa
    {
        public Pessoa()
        {
                    
        }

        public int Pessoaid { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public ICollection<Processo> Processos { get; set; }
        public ICollection<Endereco> Enderecos { get; set; }
    }

}
