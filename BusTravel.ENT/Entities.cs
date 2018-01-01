using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusTravel.ENT
{
    public class Entities
    {
        [Table("Kullanicilar")]
        public class Kullanicilar
        {
            [Key]
            public int KullaniciId { get; set; }
            public string Ad { get; set; }
            public string Soyad { get; set; }
            public string Cinsiyet { get; set; }
            public string Email { get; set; }
            public DateTime DogumTarihi { get; set; }
            public int Telefon { get; set; }
            public int Sifre { get; set; }
            public int BiletId { get; set; }
            [ForeignKey("BiletId")]
            public virtual Bilet Bilet { get; set; }
        }
        [Table("Bilet")]
        public class Bilet
        {
            [Key]
            public int BiletId { get; set; }
            public int KullaniciId { get; set; }
            public int KoltukNo { get; set; }
            public decimal Fiyat { get; set; }
            [ForeignKey("KullaniciId")]
            public virtual List<Kullanicilar> Kullanicilar { get; set; }
        }
        [Table("Otobusler")]
        public class Otobusler
        {
            [Key]
            public int OtobusId { get; set; }
           
            public string Model { get; set; }
            public string Sofor { get; set; }
         
        }
        [Table("Seferler")]
        public class Seferler
        {
            [Key]
            public int SeferId { get; set; }
            public string KalkisYeri { get; set; }
            public string VarisYeri { get; set; }
            public DateTime SeferTarihi { get; set; }
            public TimeSpan SeferSaati { get; set; }
            public int OtobusId { get; set; }
            public decimal Fiyat { get; set; }
            [ForeignKey("OtobusId")]
            public virtual Otobusler Otobusler { get; set; }
        }
        [Table("Sehirler")]
        public class Sehirler
        {
            [Key]
            public int SehirId { get; set; }
            public string SehirAd { get; set; }
        }
    }
}
