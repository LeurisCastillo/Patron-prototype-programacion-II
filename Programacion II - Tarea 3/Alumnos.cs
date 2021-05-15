using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programacion_II___Tarea_3
{
    class Alumnos : ICloneable
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string telefono { get; set; }
        public string curso { get; set; }
        public string matricula { get; set; }

        public Padres padres { get; set; }

        public Padres nombrePadre { get; set; }
        public Padres apellidoPadre { get; set; }
        public Padres telefonoPadre { get; set; }

        public Alumnos()
        {
            padres = new Padres();
        }

        public static void AsistirAClase()
        {
            Console.WriteLine("Estoy asistiendo a clase.");
        }

        public static void TomarClase()
        {
            Console.WriteLine("Estoy tomando clase.");
        }

        public static void Merendar()
        {
            Console.WriteLine("Estoy merendando.");
        }

        //PROTOTYPE
        public object Clone()
        {
            Alumnos clon = new Alumnos();
            MemberwiseClone();
            clon.padres.nombrePadre = padres.nombrePadre;
            clon.padres.apellidoPadre = padres.apellidoPadre;
            clon.padres.telefonoPadre = padres.telefonoPadre;
            return clon;
        }

        public override string ToString()
        {
            return $"Alumno: {id} / {nombre} {apellido} / {matricula}\n" +
                   $"Padre: {padres.nombrePadre} {padres.apellidoPadre} / {padres.telefonoPadre}\n";
        }
    }
}
