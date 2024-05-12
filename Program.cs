using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Universidad miUniversidad = new Universidad();

            // Crear y agregar alumnos
            Alumno alumno1 = new Alumno("FERNANDA LOPEZ", 23, "2023-1654U", Alumno.Carreras.Ingeneria_de_sistemas);
            alumno1.Calificaciones.Add(85);
            alumno1.Calificaciones.Add(90);
            miUniversidad.AgregarAlumno(alumno1);

            Alumno alumno2 = new Alumno("MICHELLE DIAZ", 22, "2021-1098U", Alumno.Carreras.Telecomunicaciones);
            alumno2.Calificaciones.Add(50);
            alumno2.Calificaciones.Add(59);
            miUniversidad.AgregarAlumno(alumno2);

            // Mostrar detalles de los alumnos
            miUniversidad.MostrarDetallesAlumnos();
           
        }
    }
}
    

