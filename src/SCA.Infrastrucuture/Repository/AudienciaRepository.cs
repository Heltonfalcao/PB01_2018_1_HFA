using SCA.ApplicationCore.Entity;
using SCA.Infrastrucuture.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace SCA.Infrastrucuture.Repository
{


    public class AudienciaRepository : EFRepository<Audiencia>, IAudicenciaRepository
    {
        public AudienciaRepository(PessoaContext dbContext) : base(dbContext)
        {

        
        }

    }
}
