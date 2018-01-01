using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BusTravel.REP.Repositories;

namespace BusTravel.BLL
{
    public class BusinessManager
    {
        public class KullanicilarManager : KullanicilarRepositories { }
        public class BiletManager : BiletRepositories { }
        public class OtobuslerManager : OtobuslerRepositories { }
        public class SeferlerManager : SeferlerRepositories { }
        public class SehirlerManager : SehirlerRepositories { }
    }
}
