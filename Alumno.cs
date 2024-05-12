using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    public partial class Alumno
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public string Carnet { get; set; }
        public Carreras Carrera { get; set; }
        public List<double> Calificaciones { get; set; }

        public enum Carreras
        {
            Ingeneria_de_sistemas,
            Ingeneria_en_computacion,
            Telecomunicaciones,
            Ingeneria_electronica,
        }

        public Alumno(string nombre, int edad, string carnet, Carreras carrera)
        {
            this.Nombre = nombre;
            this.Edad = edad;
            this.Carnet = carnet;
            this.Carrera = carrera;
            Calificaciones = new List<double>();
        }
        public double CalcularPromedioCalificaciones()
        {
            if (Calificaciones.Count == 0)
            {
                return 0;
            }
            double sumaCalificacxiones = 0;
            foreach (var calificacion in Calificaciones)
            {
                sumaCalificacxiones += calificacion;
            }
            return sumaCalificacxiones / Calificaciones.Count;
        }
         public string EstadoAprobacion() 
         {
            double promedio = CalcularPromedioCalificaciones();
            if (promedio >= 60)
            {
                return "Aprobado";
            }
            else 
            {
                return "Reprobado";
            }


         }
        

        

}   }   
