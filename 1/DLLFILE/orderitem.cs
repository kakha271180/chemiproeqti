using System;
using System.Collections.Generic;
using System.Text;

namespace DLLFILE
{
    public class orderitem
    {
        public Product Producti { get; set; }
        public double pric { get => Producti.Pricey * raodenoba; }
        public string name { get; set; }
        public int raodenoba { get; set; } = 1;
    }
}
