using SCA.ApplicationCore.Entity;
using SCA.Infrastrucuture.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace SCA.Infrastrucuture.Repository
{


    public class PessoaRepository : EFRepository<Processo>, AudicenciaRepository
    {
        public PessoaRepository(PessoaContext dbContext) : base(dbContext)
        {

        }
        public Processo ObterPorPessoa(int PessoaId)
        {
            return Buscar(x => x.Pessoa.Any(p => p.ClienteId == PessoaId))
                .FirstOrDefault();
        }

    }
}
