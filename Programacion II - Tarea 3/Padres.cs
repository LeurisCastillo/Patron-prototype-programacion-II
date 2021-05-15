using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programacion_II___Tarea_3
{
    class Padres : ICloneable
    {
        public int id { get; set; }
        public string nombrePadre { get; set; }
        public string apellidoPadre { get; set; }
        public string telefonoPadre { get; set; }
        public string lugarDeTrabajo { get; set; }
        public string correo { get; set; }

        public static void LlevarAMiHijoAlColegio()
        {
            Console.WriteLine("Estoy llevando a mi hijo al colegio.");
        }

        public static void PreguntarSiHizoSuTarea()
        {
            Console.WriteLine("Ya hiciste tu tarea?");
        }

        public static void PreguntarQueTalElDia()
        {
            Console.WriteLine("Que tal tu dia hijo?");
        }

        public object Clone()
        {
            return MemberwiseClone();
        }
    }
}
