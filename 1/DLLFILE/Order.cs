using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DLLFILE
{
   public class Order
    {
        public List<orderitem> produqtisdamateba = new List<orderitem>();

        //totalCount() funqcia unda daiceros romelic daajamebs archeul produqtebis fass
        //buy() unda daiceros funqcia romelic sheadarebs gadaxdil tanxas totalcountis tanxas
        /// <summary>
        /// es funqcia aketebs produqtis damatebas
        /// </summary>
        /// <param name="p">produqtis agwera</param>
        /// <returns></returns>
            public List<orderitem> DamatebaProduqtis(Product p)
        {
            if (produqtisdamateba.Any(o => o.Producti == p))
            {
                var ProduqtisRaodenobisGazrda = produqtisdamateba.SingleOrDefault(o => o.Producti==p);
                ProduqtisRaodenobisGazrda.raodenoba++;
                //TODO gavaketo washlis punqcia
            }
            else
            {
                orderitem o = new orderitem();
                o.Producti = p;
                produqtisdamateba.Add(o);
                o.name = p.Name;
            }
            return produqtisdamateba;
        }

        public double TotalCount()
        {
            return produqtisdamateba.Sum(oo=>oo.pric);
        }

        public List<orderitem> removeproduqts(orderitem p, int cbraodenoba)

        {
            produqtisdamateba.Remove(p);
            return produqtisdamateba;
        }
    }
}
