using Microsoft.EntityFrameworkCore;
using SCA.ApplicationCore.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace SCA.Infrastrucuture.Data
{
    public class PessoaContext : DbContext
    {
        public PessoaContext(DbContextOptions<PessoaContext> options) : base(options)
        {

        }

        public DbSet<Pessoa> Pessoas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Pessoa>().ToTable("Pessoa");
        }

        internal void AddRange(object pessoas)
        {
            throw new NotImplementedException();
        }
    }

}
