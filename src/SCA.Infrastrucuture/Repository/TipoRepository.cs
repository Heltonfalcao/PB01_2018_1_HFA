using SCA.ApplicationCore.Entity;
using SCA.Infrastrucuture.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace SCA.Infrastrucuture.Repository
{


    public class TipoRepository : EFRepository<Tipo>, TipoRepository
    {
        public TipoRepository(PessoaContext dbContext) : base(dbContext)
        {

        
        }

    }
}
