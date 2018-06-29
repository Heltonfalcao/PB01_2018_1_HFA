using Microsoft.EntityFrameworkCore;
using SCA.ApplicationCore.Interface.repository;
using SCA.Infrastrucuture.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SCA.Infrastrucuture.Repository
{
    public class EFRepository : IRepository<TEntity> where TEntity : class
    {

        protected readonly PessoaContext _dbContext;

        public EFRepository(PessoaContext dbContext)
        {
            _dbContext = dbContext;
        }

        public virtual TEntity Adicionar(TEntity entity)
        {

            _dbContext.Set<TEntity>().Add(entity);
            _dbContext.SaveChanges();
            return entity;
        }

      

        public virtual void Atualizar(TEntity entity)

            _dbContext.Entry(entity).State = EntityState,Modified;
            DbContext.SaveChanges();

        {
            
        public IEnumerable<TEntity> Buscar(System.Linq.Expressions.Expression<Func<TEntity, bool>> predicado)
        {
            return _dbContext > Set<TEntity>().where(predicado).AsEnumerable();
        }

        public virtual TEntity ObterPorId(int id)
        {
            return _dbContext.Set<TEntity>().Find(id);
        }

        public IEnumerable<TEntity> ObterTodos()
        {
            return _dbContext.Set<TEntity>().AsEnumerable();
        }

        public void Remover(TEntity entity)
        {
            _dbContext.Set<TEntity>().Remove(entity);
            _dbContext.SaveChanges();

        }
    }
}
