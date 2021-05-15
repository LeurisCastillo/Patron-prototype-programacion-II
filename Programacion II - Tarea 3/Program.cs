using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Programacion_II___Tarea_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Alumno 1

            Alumnos alumno1 = new Alumnos();

            alumno1.id = 1;
            alumno1.nombre = "Leuris";
            alumno1.apellido = "Castillo";
            alumno1.telefono = "809-123-1324";
            alumno1.curso = "1ro";
            alumno1.matricula = "9892-2831";

            alumno1.padres.nombrePadre = "Oscar";
            alumno1.padres.apellidoPadre = "Aquino";
            alumno1.padres.telefonoPadre = "809-433-3554";

            //Padre 1
            Padres padre1 = new Padres();

            padre1.id = alumno1.id;
            padre1.nombrePadre = alumno1.padres.nombrePadre;
            padre1.apellidoPadre = alumno1.padres.apellidoPadre;
            padre1.telefonoPadre = alumno1.padres.telefonoPadre;
            padre1.lugarDeTrabajo = "Microsoft";
            padre1.correo = "Oscar@gmail.com";


            //Alumno 2

            Alumnos alumno2 = (Alumnos)alumno1.Clone();

            alumno2.id = 2;
            alumno2.nombre = "Andres";
            alumno2.apellido = "De Los Santos";
            alumno2.telefono = "809-453-5565";
            alumno2.curso = "2ro";
            alumno2.matricula = "2123-4356";

            alumno2.padres.nombrePadre = "Manu";
            alumno2.padres.apellidoPadre = "Pepin";
            alumno2.padres.telefonoPadre = "809-454-5555";

            //Padre 2
            Padres padre2 = (Padres)padre1.Clone();

            padre2.id = alumno2.id;
            padre2.nombrePadre = alumno2.padres.nombrePadre;
            padre2.apellidoPadre = alumno2.padres.apellidoPadre;
            padre2.telefonoPadre = alumno2.padres.telefonoPadre;
            padre2.lugarDeTrabajo = "Google";
            padre2.correo = "Manu@gmail.com";

            //Alumno 3

            Alumnos alumno3 = (Alumnos)alumno1.Clone();

            alumno3.id = 3;
            alumno3.nombre = "Liliana";
            alumno3.apellido = "Toribio";
            alumno3.telefono = "809-222-1111";
            alumno3.curso = "3ro";
            alumno3.matricula = "3444-4444";

            alumno3.padres.nombrePadre = "Mary";
            alumno3.padres.apellidoPadre = "Priscilla";
            alumno3.padres.telefonoPadre = "809-534-1111";

            //Padre 3
            Padres padre3 = (Padres)padre1.Clone();

            padre3.id = alumno3.id;
            padre3.nombrePadre = alumno3.padres.nombrePadre;
            padre3.apellidoPadre = alumno3.padres.apellidoPadre;
            padre3.telefonoPadre = alumno3.padres.telefonoPadre;
            padre3.lugarDeTrabajo = "Facebook";
            padre3.correo = "Mary@gmail.com";

            //Alumno 4

            Alumnos alumno4 = (Alumnos)alumno1.Clone();

            alumno4.id = 4;
            alumno4.nombre = "Matt";
            alumno4.apellido = "Murdock";
            alumno4.telefono = "809-111-3224";
            alumno4.curso = "4ro";
            alumno4.matricula = "2121-4344";

            alumno4.padres.nombrePadre = "Nate";
            alumno4.padres.apellidoPadre = "Murdock";
            alumno4.padres.telefonoPadre = "809-434-6780";

            //Padre 4
            Padres padre4 = (Padres)padre1.Clone();

            padre4.id = alumno4.id;
            padre4.nombrePadre = alumno4.padres.nombrePadre;
            padre4.apellidoPadre = alumno4.padres.apellidoPadre;
            padre4.telefonoPadre = alumno4.padres.telefonoPadre;
            padre4.lugarDeTrabajo = "Nike";
            padre4.correo = "Nate@gmail.com";

            List<string> colegio = new List<string>() {alumno1.ToString(), alumno2.ToString(), alumno3.ToString(), alumno4.ToString() };

            using (StreamWriter print = new StreamWriter(@"C:\Lista colegio.txt"))
            {
                foreach (string colegioLista in colegio)
                {
                    print.WriteLine(colegioLista);
                }
            }

            Console.ReadKey();
        }
    }
}
