using System;
using static System.Console;

namespace Inciso2;
class Program
{
    private static List<Profesor> ListadoProfesor = new List<Profesor>();
    private static List<Alumno> ListadoAlumno = new List<Alumno>();
    static void Main(string[] args)
    {
        var cantidad = 0;
        while (cantidad < 5)
        {
            WriteLine("Ingrese nombre:");
            var nombre = ReadLine().ToString();
            WriteLine($"Ingrese edad de {nombre}:");
            var edad = Convert.ToInt32(ReadLine());
            WriteLine($"Ingrese \"P\" si es profesor y \"A\" si es alumno:");
            var tipo = ReadLine().ToLower();
            switch (tipo)
            {
                case "p":
                    EsProfesor(nombre, edad);
                    cantidad++;
                    break;
                case "a":
                    EsAlumno(nombre, edad);
                    cantidad++;
                    break;
                default:
                    WriteLine($"No ingresó el tipo de persona correcto, el dato no se guardo...");
                    break;
            }

        }
        ImprimirListado();
        ReadKey();
    }
    public static void EsAlumno(string Nombre, int Edad)
    {
        WriteLine("Ingrese el número de alumno:");
        var numAlumno = Convert.ToInt32(ReadLine());
        ListadoAlumno.Add(new Alumno(Nombre, Edad, numAlumno));
    }

    public static void EsProfesor(string Nombre, int Edad)
    {
        WriteLine("Ingrese materia:");
        var materia = ReadLine().ToString();
        ListadoProfesor.Add(new Profesor(Nombre, Edad, materia));
    }

    public static void ImprimirListado()
    {
        WriteLine("\n\n############## PROFESORES ##############");
        foreach (var persona in ListadoProfesor)
        {
            WriteLine($"{persona.nombre} - {persona.edad} - {persona.materia}");
        }

        WriteLine("\n\n############## ALUMNOS ##############");
        foreach (var persona in ListadoAlumno)
        {
            WriteLine($"{persona.nombre} - {persona.edad} - {persona.numeroAlumno}");
        }
    }
}

/*
 * 2- Desarrollar el ejercicio anterior, pero ahora al introducir el nombre, 
 * se especificara si es Alumno o Profesor, con lo que se crearan 2 clases nuevas 
 * que Heredaran ambas de "Persona". Si es Alumno, 
 * se pedirá el numero de alumno, si es profesor, se pedirá la materia que imparte.
 */