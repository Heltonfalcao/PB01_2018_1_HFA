using SCA.ApplicationCore.Entity;
using SCA.Infrastrucuture.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace SCA.Infrastrucuture.Repository
{


    public class ProcessoRepository : EFRepository<Processo>, ProcessoRepository
    {
        public ProcessoRepository(PessoaContext dbContext) : base(dbContext)
        {

        
        }

    }
}
