using SCA.ApplicationCore.Entity;
using SCA.Infrastrucuture.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace SCA.Infrastrucuture.Repository
{


    public class EnderecoRepository : EFRepository<Endereco>, EnderecoRepository
    {
        public EnderecoRepository(PessoaContext dbContext) : base(dbContext)
        {

        
        }

    }
}
