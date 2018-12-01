using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DLLFILE;


namespace kakha
{
    public  partial  class Form1 : Form
    {
       public List<Product> produqtebi  = new List<Product>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (var item in DataBase.products)
            {
                UserControl1 userControl = new UserControl1(item);
                userControl.daamate += damateba;
                flowLayoutPanel1.Controls.Add(userControl);
            }
            
        }

        Order o = new Order();
        public void damateba(object sender, Product p)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = o.DamatebaProduqtis(p);
            label2.Text = o.TotalCount().ToString();
        }

        public void obieqtiscashla(orderitem k)
        {
            produqtiscashla pc = new produqtiscashla(k.raodenoba);
            pc.ShowDialog();
          
                var raodenoba = pc.textboqsisraodenoba;

                if (o.produqtisdamateba.Any(o => o.raodenoba == raodenoba))
                {

                var h = o.removeproduqts(k, raodenoba);
                dataGridView1.DataSource = null;

                dataGridView1.DataSource = h;
                label2.Text = o.TotalCount().ToString();
                }
            else
                {
                var darcheniliraodenoba = o.produqtisdamateba.Single(o => o == k);
                var g = darcheniliraodenoba.raodenoba - raodenoba;
                o.produqtisdamateba.Single(o => o == k).raodenoba = g;
                dataGridView1.DataSource = null;

                dataGridView1.DataSource = o.produqtisdamateba;
                label2.Text = o.TotalCount().ToString()+'₾';
                }
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count>0)
            {
                var produqtiscashla_ = dataGridView1.SelectedRows[0].DataBoundItem as orderitem;
                obieqtiscashla(produqtiscashla_);
            }
            else
            {
                MessageBox.Show("გთხოვთ შეიყვანოთ პროდუქტი!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var gadasaxdelitanxa = Convert.ToDouble(label2.Text);
            
            calculator cal = new calculator(gadasaxdelitanxa);
            cal.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
