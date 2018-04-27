using System;
using System.Collections.Generic;
using System.Text;

namespace SCA.ApplicationCore.Entity
{
    public class Endereco
    {
        public Endereco()
        {
        }

        public int EnderecoId { get; set; }
        public String Lougradouro { get; set; }
        public String Bairro { get; set; }
        public String Cep { get; set; }
        public String Numero { get; set; }

        public int PessoaId { get; set; }
        public Pessoa Pessoa { get; set; }


    }



}
