using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusTravel.REP
{
    interface InterfaceRepository<T> where T : class, new()
    {
        DbSet<T> Set();
        void Sil(T entity);
        void Ekle(T entity);
        T Bul(int id);
        T Bul(string id);
        void Guncelle(T entity);
        void Save();
        IQueryable<T> GenelListe();


    }


}
