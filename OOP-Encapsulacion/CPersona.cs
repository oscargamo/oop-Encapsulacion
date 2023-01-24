using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Encapsulacion
{
    class CPersona
    {
        // se refiere al ocultamiento de los datos miembros de un objeto, es decir, encapsular los atributos
        // y métodos del objeto, de manera que sólo se pueda cambiar mediante las operaciones definidas para ese objeto.
        // Indicamos los atributos de la clase persona
        public string Nombre;
        public DateTime FechaNacimiento;
        private int _edad;

        // Es una manera de tener el set y get 
        public int Edad
        {
            // Encapsulacion nivel abierto, por defecto es public la propiedad es publico 
            get { return _edad; }
            // Encapsulacion nivel cerrado-privado 
            private set { _edad = value; }
        }
        // Creamos los metodos  de Registrar
        public void Registrar()
        {
            CalcularEdad(FechaNacimiento);
            Console.WriteLine(Nombre + " con " + Edad + " años, ha sido registrado correctamente");
        }

        private void CalcularEdad(DateTime fechaNacimiento)
        {
            DateTime fechaActual = DateTime.Now;
            Edad = fechaActual.Year - fechaNacimiento.Year;
        }
    }
}
