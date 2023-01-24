using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Encapsulacion
{
    class Program
    {
        static void Main(string[] args)
        {
            CPersona persona = new CPersona();
            persona.Nombre = "Oscar Galindo";
            persona.FechaNacimiento = Convert.ToDateTime("10/10/1990");
            persona.Registrar();
            Console.WriteLine(persona.Nombre + " " + persona.Edad);
            Console.ReadLine();


            // Con esto nos damos cuenta la importancia de el encapsulamiento en el cual no se pueda acceder a 
            // las propiedades que no queramos que se modifiquen, por ejemplo el atributo edad no se puede cambiar 
            // su valor desde la instancia de la clase es decir CPersona persona  = new CPersona();
            // persona.Edad = 33; nos marca un error en tiempo de ejecucion por el tipo de acceso que en este caso es
            // privado.

            CLibro libro = new CLibro();
            libro.Nombre = "los 4 fantasticos";
            libro.Pagina = 23;
            libro.Suma(23, 34);
        }
    }
}
