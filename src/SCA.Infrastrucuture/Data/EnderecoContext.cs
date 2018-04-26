using Microsoft.EntityFrameworkCore;
using SCA.ApplicationCore.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace SCA.Infrastrucuture.Data
{
   public class EnderecoContext : DbContext
    {
        public EnderecoContext(DbContextOptions<EnderecoContext> options) : base(options)
        {

        }

        public DbSet<Endereco> Enderecos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Endereco>().ToTable("Endereco");
        }
    }

}





    
