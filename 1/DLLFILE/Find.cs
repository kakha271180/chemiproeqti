using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DLLFILE
{
    public static class Find_
    {
        public static int find_(string name)

        {
          return DataBase.products.FindIndex(e => e.Equals(name));
        }

        public static Product Obieqti(string name)
        {
            return DataBase.products.SingleOrDefault(o => o.Name == name);
        }
    }
}
