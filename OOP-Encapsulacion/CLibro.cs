using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Encapsulacion
{
    class CLibro
    {
        // Definimos los atributos de libro 
        public string Nombre { set; get; }
        private int NumeroPaginas { set; get; }

        public int Pagina
        {
            get
            {
                return NumeroPaginas;
            }
            set
            {
                NumeroPaginas = value;
            }
        }

        public int Suma(int numero1, int numero2)
        {
            return numero1 + numero2;
        }
    }
}
