using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemplosIF
{
    //declaro una clase
    public class Triangulo
    {
        //declarar el constructor con el mismo nombre de la clase
        public Triangulo()
        {
        }

        //declaración de variables que solo van a usarse internamente con la clase
        private int L1;
        private int L2;
        private int L3;

        //declaración de propiedades o atributos publicos, son los reciben los valores de los 
        //que se guardan en el objeto
        public int Lado1
        {
            get { return L1; }
            set { L1 = value; }
        }
        public int Lado2
        {
            get { return L2; }
            set { L2 = value; }
        }

        public int Lado3
        {
            get { return L3; }
            set { L3 = value; }
        } 

        //declaración de los métodos públicos (aqui se guardan las reglas de cálculo)
      public bool EsEquilatero()
        {
            return (L1 == L2 && L1 == L3 && L2 == L1 ? true : false);
        }
        public string Ladomayor()
        {
            return (L1 > L2 && L1 > L3 ? "Lado 1 es mayor" : (L2>L1&&L2>L3)?"Lado 2 es mayor":(L3>L2&&L3>L1)?"Lado 1 es mayor":"Ningún lado es mayor");
        }
    }
}
