using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace DLLFILE
{
   public static class chacerisclasi
    {
        public static string monacemischacera { get; set; }
    }

    class sql
    {
        SQLiteConnection chacera_ { get; }

        public sql()
        {
            //string chacera = chacerisclasi.monacemischacera;
            chacera_ = new SQLiteConnection(chacerisclasi.monacemischacera);
            chacera_.CreateTable<archeuliproduqti>();
        }

        public void add(orderitem o)
        {
            chacera_.Insert(new archeuliproduqti() { Name = o.name, Price = o.pric, Raodenoba = o.raodenoba, Gadaxdistarigi=DateTime.Now, Gadaxdilitanxa=o.raodenoba*o.pric });
        }

    }

    public class gayiduliproduqti
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Name { get; set; }
    }

    public class archeuliproduqti
    {
        [PrimaryKey,AutoIncrement]
        public int ID { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int Raodenoba { get; set; }
        public double Gadaxdilitanxa { get; set; }
        public DateTime Gadaxdistarigi { get; set; }
    }
}
