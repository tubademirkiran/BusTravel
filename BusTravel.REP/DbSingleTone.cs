using BusTravel.DAL;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusTravel.REP
{
    public class DbSingleTone
    {
        static BusModel db;
        static public BusModel GetInstance()
        {
            if (db == null)
            {
                db = new DAL.BusModel();
            }
            return db;
        }
    }
}
