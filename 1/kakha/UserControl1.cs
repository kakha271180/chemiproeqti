using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DLLFILE;

namespace kakha
{
   // public delegate void Produqtisdamateba(Product p);

    public partial class UserControl1 : UserControl
    {
        public  event EventHandler<Product> daamate ;
        public Product Product_ { get; set; }

        public UserControl1()
        {
            InitializeComponent();
        }

       public UserControl1(Product p ):this()
        {
            
            btt.Text = p.Name;
            lab.Text = p.Pricey.ToString();
            Product_ = p;
        }

        
        private void btt_Click(object sender, EventArgs e)
        {
            daamate?.Invoke(this, Product_);
            
        }
    }
}
