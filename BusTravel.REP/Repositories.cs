using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BusTravel.ENT.Entities;

namespace BusTravel.REP
{
    public class Repositories
    {
        public class KullanicilarRepositories : BaseRepositories<Kullanicilar> { }
        public class BiletRepositories : BaseRepositories<Bilet> { }
        public class OtobuslerRepositories : BaseRepositories<Otobusler> { }
        public class SeferlerRepositories : BaseRepositories<Seferler> { }
        public class SehirlerRepositories : BaseRepositories<Sehirler> { }
    }
}
