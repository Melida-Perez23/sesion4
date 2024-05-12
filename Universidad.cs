using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    public partial class Universidad
    {
        private List<Alumno> alumnoList;
        public Universidad() 
        {
            alumnoList = new List<Alumno>();
        }
        public void AgregarAlumno(Alumno alumno) 
        {
            alumnoList.Add(alumno);
        }
        public List<Alumno> obtenerlistaAlumnos()
        {
            return alumnoList;
        }


        public void MostrarDetallesAlumnos()
        {
            foreach (var alumno in alumnoList)
            {
                Console.WriteLine($"Nombre: {alumno.Nombre},Edas: {alumno.Edad}, Carnet: {alumno.Carnet}, Promedio: {alumno.CalcularPromedioCalificaciones()}, Estado: {alumno.EstadoAprobacion()}");
            }
        }



    }
}
