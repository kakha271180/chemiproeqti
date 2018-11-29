using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DLLFILE
{
  
    public class DataBase
    {

       public static List<Product> products { get; private set; } = new List<Product>()
        {
            new Product{ ID=1, Name="yava", Pricey=0.6, Raodenoba=5},
            new Product{ ID=2, Name="chai", Pricey=0.5, Raodenoba=5},
            new Product{ ID=3, Name="shokoladi", Pricey=1.6, Raodenoba=20},
            new Product{ ID=4, Name="viski", Pricey=2.5, Raodenoba=5}
        };

        public Product mipoveproduqti(string name)
        {
            var k = products.Where(p => p.Name == name).FirstOrDefault();
            if (k.ID == 3)
            
                k.Raodenoba = 1;
            
            else
            k.Raodenoba = 0.5;
            return k;
        }

        public List<Product> Add(string name)
        {
            List<Product> axaliproduqtebi = new List<Product>();

            var k = axaliproduqtebi.Count;

            var hk = axaliproduqtebi.Select(o => o.ID);

            if (mipoveproduqti(name)!=axaliproduqtebi.Select(n=>n.Name))
            {
                axaliproduqtebi.Add(new Product { ID = k++, Name = name, Pricey = 2.5, Raodenoba=5 });
                return axaliproduqtebi;
            }
            else
            {
                return null;
            }

        }

        public double Remove(string name)
        {
            var perone = products[Find_.find_(name)].Raodenoba - 0.5;

            if (perone >= 0.5)
            {
            
              return products[Find_.find_(name)].Raodenoba = perone; ;
            }
            else
            {
               return products[Find_.find_(name)].Raodenoba ;
            }
        }

        public void All()
        {
            var ProduqtebiDB = from d in products
                               select new { d.Name, d.Pricey };
        }
    }
}
