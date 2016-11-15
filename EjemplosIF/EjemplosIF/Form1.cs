using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjemplosIF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt16(L1.Text) > Convert.ToInt16(L2.Text) & Convert.ToInt16(L1.Text) > Convert.ToInt16(L3.Text)) 
            {
                MessageBox.Show("L1 es mayor");
            }
            else if (Convert.ToInt16(L2.Text) > Convert.ToInt16(L1.Text) & Convert.ToInt16(L2.Text) > Convert.ToInt16(L3.Text))
            {
                MessageBox.Show("L2 es mayor");
            }
            else if (Convert.ToInt16(L3.Text) > Convert.ToInt16(L1.Text) & Convert.ToInt16(L3.Text) > Convert.ToInt16(L2.Text))
            {
                MessageBox.Show("L3 es mayor");
            }
            else if (Convert.ToInt16(L3.Text) == Convert.ToInt16(L1.Text) &
                     Convert.ToInt16(L3.Text) == Convert.ToInt16(L2.Text) &
                     Convert.ToInt16(L2.Text) == Convert.ToInt16(L1.Text))
            {
                MessageBox.Show("El triángulo es equilatero");
            }
            else
            {
                MessageBox.Show("No hay un lado mayor");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }
    }
}
