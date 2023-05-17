using System;
namespace RetoSemanal3
{
    public class Alumno
    {
        public string nombre {get;set;}
        public string apellido { get; set; }
        public int numeroIdentificacion { get; set; }
        public string carrera { get; set; }
        public List<double> notas { get; private set; }

        public Alumno()
        {
            nombre = "";
            apellido = "";
            numeroIdentificacion = 0;
            carrera = "";
            notas = new List<double>();
        }

        public Alumno(string Nombre, string Apellido, int NumeroIdentificacion, string Carrera)
        {
            nombre = Nombre;
            apellido = Apellido;
            numeroIdentificacion = NumeroIdentificacion;
            carrera = Carrera;
            notas = new List<double>();
        }

        public bool IngresoDeNotas(List<double> notasIngresadas)
        {
            foreach (var nota in notasIngresadas)
            {
                if (nota > 0 && nota <= 100)           
                {
                    notas.Add(nota);
                }
                else
                {
                    return false;
                }
            }
            return true;
        }

        public double SacarPromedio()
        {
            var ResultadoNotas = 0.0;
            foreach (var nota in notas)
            {
                ResultadoNotas += nota;
            }

            return ResultadoNotas / notas.Count();
        }
    }
}			

