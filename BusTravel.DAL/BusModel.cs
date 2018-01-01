namespace BusTravel.DAL
{
    using System;
    using System.Data.Entity;
    using System.Linq;
    using static BusTravel.ENT.Entities;

    public class BusModel : DbContext
    {
        public BusModel()
            : base("Baglanti")
        {
        }

        public virtual DbSet<Bilet> Bilet { get; set; }
        public virtual DbSet<Kullanicilar> Kullanicilar { get; set; }
        public virtual DbSet<Otobusler> Otobusler { get; set; }
        public virtual DbSet<Seferler> Seferler { get; set; }
        public virtual DbSet<Sehirler> Sehirler { get; set; }
    }

}