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
    public partial class calculator : Form
    {
        public calculator(double i)
        {
            InitializeComponent();
            
            label2.Text = i.ToString() + " " + $"₾";
            if (string.IsNullOrEmpty(textBox1.Text))
            label4.Text = 0.ToString()+" "+$"₾";
            else
            label4.Text = i.ToString() + " " + $"₾";
        }
       
        private void button13_Click(object sender, EventArgs e)
        {
            Close();
        }

        int count = 0;
        public void bttclic(object sender, EventArgs e)
        {
            Button b = sender as Button;
            textBox1.Text += b.Text;
            
            if  ( char.IsDigit( textBox1.Text.ToString(), 0))
                button1.Enabled = true;

            if (b.Text==".")
            {
                count++;
            }
            if (textBox1.Text.Length >= 1 && count == 0)
                button15.Enabled = true;
            else
                button15.Enabled = false;

            if (textBox1.Text.Length >= 1)
                button12.Enabled = true;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.ToString().Remove(textBox1.Text.ToString().Length - 1, 1);
            if (string.IsNullOrEmpty( textBox1.Text))
            {
                button1.Enabled = false;
                button12.Enabled = false;
                button15.Enabled = false;
                count = 0;
            }   
        }
    }
}
