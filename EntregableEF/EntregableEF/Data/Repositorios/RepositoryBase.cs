using EntregableEF.Modelos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntregableEF.Data.Repositorios
{
    public class RepositoryBase<T> : IRepository<T>
    where T : class, IEntity
    {
        protected readonly ApplicationDbContext _context;
        protected readonly DbSet<T> _dbSet;

        public RepositoryBase(ApplicationDbContext context)
        {
            _context = context;
            _dbSet = context.Set<T>();
        }

        public virtual List<T> GetAll()
        {
            return _dbSet
            .AsNoTracking()
            .Where(x => x.Deleted == null)
            .ToList();
        }

        public virtual T GetById(int id)
        {
            return _dbSet.Find(id);
        }

        public virtual void Insert(T entity)
        {
            entity.Created = DateTime.Now;

            _dbSet.Add(entity);

            _context.SaveChanges();
        }

        public virtual void Update(T entity)
        {
            entity.Updated = DateTime.Now;

            _context.Entry(entity).State = EntityState.Modified;

            _context.SaveChanges();
        }

        public virtual void Delete(int id)
        {
            var entity = _dbSet.Find(id);

            if (entity == null)
            {
                return;
            }

            entity.Deleted = DateTime.Now;
            entity.Updated = DateTime.Now;

            _context.SaveChanges();
        }
    }
}
