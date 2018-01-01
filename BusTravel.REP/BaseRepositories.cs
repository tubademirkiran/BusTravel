using BusTravel.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace BusTravel.REP
{
    public class BaseRepositories<T> : InterfaceRepository<T> where T : class, new()
    {
        BusModel db = DbSingleTone.GetInstance();
        public T Bul(int id)
        {
            return Set().Find(id);
        }

        public T Bul(string id)
        {
            return Set().Find(id);
        }

        public void Ekle(T entity)
        {
            db.Entry(entity).State = EntityState.Added;
        }

        public IQueryable<T> GenelListe()
        {
            return Set().AsQueryable();
        }

        public void Guncelle(T entity)
        {
            db.Entry(entity).State = EntityState.Modified;
        }

        public void Save()
        {
            db.SaveChanges();
        }

        public DbSet<T> Set()
        {
            return db.Set<T>();
        }

        public void Sil(T entity)
        {
            db.Entry(entity).State = EntityState.Deleted;
        }
        public List<T> Listele()
        {
            return Set().ToList();
        }

        DbSet<T> InterfaceRepository<T>.Set()
        {
            throw new NotImplementedException();
        }
    }
}
