using BakeryApp.DataAccess.Repository.IRepository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BakeryApp.DataAccess.Repository
{
    public class Repository<T> : IRepository<T> where T:class
    {
        private readonly BakeryContext _db;
        public DbSet<T> dbSet;

        public Repository(BakeryContext db)
        {
            _db = db;
            dbSet = _db.Set<T>();
     
        }
        public void Add(T entity)
        {

            dbSet.Add(entity);
        }

        public IQueryable<T> FindAll()
        {
            return _db.Set<T>();
        }

        public IQueryable<T> FindByCondition(Expression<Func<T, bool>> filter)
        {
            return _db.Set<T>().Where(filter);
        }

        public IEnumerable<T> GetAll()
        {
            IQueryable<T> query = dbSet;
            return query.ToList();
        }

        public T getOrDefault(Expression<Func<T, bool>> filter)
        { 
            IQueryable<T> query = dbSet;
            query = query.Where(filter);

            return query.FirstOrDefault();
        }

        public void Remove(T entity)
        {
            dbSet?.Remove(entity);
        }

        public async Task SaveAsync()
        {
            await _db.SaveChangesAsync();   
        }
    }
}
