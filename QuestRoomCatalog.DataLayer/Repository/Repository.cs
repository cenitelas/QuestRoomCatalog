using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using QuestRoomCatalog.DataLayer;
using DataLayer.Repositories;
using QuestRoomCatalog.DataLayer.Repository;

namespace DataLayer.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly DbContext db = null;
        private readonly DbSet<T> table = null;
        public Repository()
        {
            db = new Model1();
            table = db.Set<T>();
        }

        public Repository(DbContext db)
        {
            this.db = db;
            table = db.Set<T>();
        }
        public void Add(T entity)
        {
            table.Add(entity);
        }

        public void Delete(int id)
        {
            T existingEntity = table.Find(id);
            table.Remove(existingEntity);
        }

        public T Get(int? id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> GetAll()
        {
            return table.ToList();
        }

        public void Save()
        {
            db.SaveChanges();
        }

        public void Update(T entity)
        {
            db.Entry(entity).State = EntityState.Modified;
        }
    }
}