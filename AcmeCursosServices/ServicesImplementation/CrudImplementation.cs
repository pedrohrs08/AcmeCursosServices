using AcmeCursosServices.DAL;
using AcmeCursosServices.ServicesIntefaces;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using AcmeCursos.Models;

namespace AcmeCursosServices.ServicesImplementation
{
    public class CrudImplementation<T> : ICrud<T> where T : GenericEntity
    {
        protected DbSet<T> Collection { get; set; }
        protected AppDbContext db = AppDbContext.db;

        public CrudImplementation(DbSet<T> collection) {
            this.Collection = collection;
        }

        public T Get(int id)
        {
            T entity = Collection.Find(id);
            return entity;
        }

        public List<T> GetAll()
        {
            return Collection.ToList();
        }

        public bool Delete(int id)
        {
            T entity = this.Get(id);
            Collection.Remove(entity);
            db.SaveChanges();
            return true;
        }

        public T Save(T entity)
        {
            if (entity.GetId() == 0)
            {
                Collection.Add(entity);
            }
            else 
            {
                T dbEntity = Get(entity.GetId());
                db.Entry(dbEntity).CurrentValues.SetValues(entity);
            }
            db.SaveChanges();
            return entity;
        }
    }
}