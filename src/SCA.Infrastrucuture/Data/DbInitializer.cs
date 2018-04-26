using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using SCA.ApplicationCore.Entity;

namespace SCA.Infrastrucuture.Data
{
    public static class DbInitializer
    {
        
        public static void Initialize (PessoaContext context)
        {

            if (context.Pessoas.Any())
            {
                return;

            }
            var Pessoas = new Pessoa[]
            {
                new Pessoa{
                    Nome = "juca do guarana",
                    Email = "jucadoguarana@hotmail.com"
                },
                 new Pessoa{
                    Nome = " jose silva",
                    Email = "josesilva@hotmail.com"

                 }
                };
            context.AddRange(Pessoas);
            
            var Processos = new Processo[]
           {
                new Processo{
                    DataEntrada = new DateTime (01,03,2015),
                    DataSaida = new DateTime (02,04,2016),
                    Situacao = false,
                    Pessoa = Pessoas [0]
                },
                 new Processo{
                    DataEntrada = new DateTime  (21,05,2011),
                    DataSaida = new DateTime (10,03,2012),
                    Situacao = false ,
                    Pessoa = Pessoas [1]
                 }
               };
            context.AddRange(Processos);
            context.SaveChanges();








        }



    }
}
