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
            //if (Convert.ToInt16(L1.Text) > Convert.ToInt16(L2.Text) & Convert.ToInt16(L1.Text) > Convert.ToInt16(L3.Text))
            //{
            //    MessageBox.Show("L1 es mayor");
            //}
            //else if (Convert.ToInt16(L2.Text) > Convert.ToInt16(L1.Text) & Convert.ToInt16(L2.Text) > Convert.ToInt16(L3.Text))
            //{
            //    MessageBox.Show("L2 es mayor");
            //}
            //else if (Convert.ToInt16(L3.Text) > Convert.ToInt16(L1.Text) & Convert.ToInt16(L3.Text) > Convert.ToInt16(L2.Text))
            //{
            //    MessageBox.Show("L3 es mayor");
            //}
            //else if (Convert.ToInt16(L3.Text) == Convert.ToInt16(L1.Text) &
            //         Convert.ToInt16(L3.Text) == Convert.ToInt16(L2.Text) &
            //         Convert.ToInt16(L2.Text) == Convert.ToInt16(L1.Text))
            //{
            //    MessageBox.Show("El triángulo es equilatero");
            //}
            //else
            //{
            //    MessageBox.Show("No hay un lado mayor");
            //    MessageBox.Show((false) ? "Es verdadero" : "Es falso");
            //}

            //MessageBox.Show((Convert.ToInt16(L1.Text)> Convert.ToInt16(L2.Text)&& Convert.ToInt16(L1.Text)> Convert.ToInt16(L3.Text)) ? "L1 es mayor" : (Convert.ToInt16(L2.Text)> Convert.ToInt16(L1.Text)&& Convert.ToInt16(L2.Text)> Convert.ToInt16(L3.Text)) ? "L2 es verdadero": (Convert.ToInt16(L3.Text)> Convert.ToInt16(L1.Text)&& Convert.ToInt16(L3.Text)> Convert.ToInt16(L2.Text)) ?"L3 es mayor": (Convert.ToInt16(L1.Text)== Convert.ToInt16(L2.Text) && Convert.ToInt16(L2.Text)== Convert.ToInt16(L3.Text) && Convert.ToInt16(L1.Text)== Convert.ToInt16(L3.Text)) ?"El triangulo es equilatero":"No se encontró un lado mayor");

            //declarando mi instancia de la clase con un constructor vacio
            Triangulo MiTriangulo = new Triangulo();

            //asigno valores a los aributos
            MiTriangulo.Lado1 = Convert.ToInt16(L1.Text);
            MiTriangulo.Lado2 = Convert.ToInt16(L2.Text);
            MiTriangulo.Lado3 = Convert.ToInt16(L3.Text);

            //mando llamar a los métodos
            MessageBox.Show((MiTriangulo.EsEquilatero()) ? "Es equilatero" : MiTriangulo.Ladomayor());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }
    }
}
