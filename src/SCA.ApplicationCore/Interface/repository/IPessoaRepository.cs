using SCA.ApplicationCore.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace SCA.ApplicationCore.Interface.repository
{
    interface IPessoaRepository : IRepository<Processo>
    {
        Processo ObterPorPessoa(int PessoaId);




    }
}
