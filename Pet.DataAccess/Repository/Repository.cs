﻿using Pet.DataAccess.Repository.IRepository;
using System.Linq.Expressions;
using Pet.DataAccess.Data;
using Microsoft.EntityFrameworkCore;

namespace Pet.DataAccess.Repository {
    public class Repository<T> : IRepository<T> where T : class {
        private readonly ApplicationDbContext _db;
        internal DbSet<T> dbSet;
        public Repository(ApplicationDbContext db)
        {
            _db = db;
            this.dbSet = _db.Set<T>();
            //_db.Categories == dbSet
            _db.Animals.Include(u => u.Category).Include(u => u.CategoryId);
            _db.Comments.Include(u => u.Animal).Include(u => u.AnimalId);
        }
        public void Add(T entity) {
            dbSet.Add(entity);
        }

        public T Get(Expression<Func<T, bool>> filter, string? includeProperties = null) {
            IQueryable<T> query = dbSet;
            query = query.Where(filter);
            if (!string.IsNullOrEmpty(includeProperties)) {
                foreach (var includeProp in includeProperties.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries)) {
                    query = query.Include(includeProp);
                }
            }
            return query.FirstOrDefault();
        }

        public IEnumerable<T> GetAll(string? includeProperties = null) {
            IQueryable<T> query = dbSet;
            if (!string.IsNullOrEmpty(includeProperties)) {
                foreach(var includeProp in includeProperties.Split(new char[] { ','}, StringSplitOptions.RemoveEmptyEntries)) {
                    query = query.Include(includeProp);
                }
            }
            return query.ToList();

        }

        public void Remove(T entity) {
           dbSet.Remove(entity);
        }

        public void RemoveRange(IEnumerable<T> entity) {
            dbSet.RemoveRange(entity);
        }
    }
}