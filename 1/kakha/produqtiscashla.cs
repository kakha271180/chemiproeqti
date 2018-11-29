using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kakha
{
    public partial class produqtiscashla : Form
    {
        public int textboqsisraodenoba { get; set; }

        public produqtiscashla(int a)
        {
            InitializeComponent();
            for (int i = 0; i < a; i++)
            {
                comboBox1.Items.Add(i+1);
            }

           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textboqsisraodenoba = Convert.ToInt16(comboBox1.SelectedItem.ToString());
            Close();
        }
    }
}
