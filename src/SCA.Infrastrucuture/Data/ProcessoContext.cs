using Microsoft.EntityFrameworkCore;
using SCA.ApplicationCore.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace SCA.Infrastrucuture.Data
{
    public class ProcessoContext : DbContext
    {

        public ProcessoContext(DbContextOptions<ProcessoContext> options) : base(options)
        {

        }

        public DbSet<Processo> Processos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Processo>().ToTable("Processo");
        }



    }
}
