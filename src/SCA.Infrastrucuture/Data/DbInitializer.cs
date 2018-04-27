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
            var Audiencias = new Audiencia[]
           {
                new Audiencia{
                    Data = new DateTime (01,05,2016),
                    Detalhes = "Processo em Analise do juiz da primeira vara civil",
                    Processo = Processos [0]
                },
               new Audiencia{
                    Data = new DateTime (25,05,2016),
                    Detalhes = "Processo Arquivado" ,
                    Processo = Processos [1]
                 }
               };
            context.AddRange(Audiencias);
            var Enderecos = new Endereco[]
           {
                new Endereco{

                    Lougradouro = "quadra 21 setor 3",
                    Bairro = "CPA ",
                    Cep ="78058400",
                    Numero = "41",

                },
               new Endereco{
                     Lougradouro = "quadra 54 setor 3",
                    Bairro = "CPA 4 ",
                    Cep ="78058300",
                    Numero = "1",
                    

               }
               };
            context.AddRange(Enderecos);
            var Tipos = new Tipo[]
           {
                new Tipo{

                   Descricao = "Jugado e condenado"                   
                },
               new Tipo{
                    Descricao = "Jugado e condenado",


               }
               };
            context.AddRange(Tipos);
            context.SaveChanges();








        }



    }
}
