﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace RetoSemanal3;
class Program
{
    public static List<Alumno> ListadoAlumnos = new List<Alumno>();
    static void Main(string[] args)
    {
        WriteLine("Bienvenido al Ingreso de notas");
        var cantidad = 0;
        while (cantidad < 5)
        {
            var nombre = $"NombrePersona {cantidad}";
            var apellido = $"ApellidoPersona {cantidad}";
            Random rnd = new Random(); // para carnet y notas
            var carrera = $"Carrera {cantidad}";
            // Se hace la instacia del alumno y se inicializa
            Alumno alumno = new Alumno(nombre, apellido, rnd.Next(1000, 10000), carrera);

            // se piden las notas y se agregan a un List
            List<double> notas = new List<double>();
            PedirNotas(ref notas, rnd);

            if (alumno.IngresoDeNotas(notas)) //ingreso de notas correctamente
            {
                WriteLine("La información del alumno se ingreso con éxito");
                ListadoAlumnos.Add(alumno); //Se agrega el alumno al listado general
                cantidad++;
            }
            else
            {
                WriteLine("La información del alumno No se ingreso con éxito, recuerde que el rango de las notas es de 0 a 100");
            }

            
        }

        //Inciso 1: Imprimir la información de todos los estudiantes de la lista, incluyendo su nombre completo, número de identificación, carrera y promedio de notas.
        ImprimeDatosEstudiantes();
        //Inciso 2: Imprimir el nombre completo y número de identificación de todos los estudiantes que tengan un promedio de notas mayor o igual a 6.
        ImprimeEstudiantesPromedio60();
        //Inciso 3: Imprimir promedio de toda la clase.
        ImprimePromedioGeneral();
        ReadKey();
    }

 

    public static void PedirNotas(ref List<double> notas, Random rnd)
    {
        var i = 0;
        while (i < 5) 
        {
            notas.Add(rnd.Next(0, 100));
            i++;
        }
        
    }

    public static void ImprimeDatosEstudiantes()
    {
        WriteLine($"\n\n\nDATOS DE TODOS LOS ALUMNOS");
        foreach (var alumno in ListadoAlumnos)
        {
            WriteLine($"-------------------------------------------------");
            WriteLine($"NOMBRE: {alumno.nombre}");
            WriteLine($"APELLIDO: {alumno.apellido}");
            WriteLine($"CARNET: {alumno.numeroIdentificacion}");
            WriteLine($"CARRERA: {alumno.carrera}");
            WriteLine($"PROMEDIO: {alumno.SacarPromedio()}");
        }
        WriteLine($"-------------------------------------------------\n\n\n");

    }

    public static void ImprimeEstudiantesPromedio60()
    {
        WriteLine($"\n\n\nALUMNOS CON PROMEDIO MAYOR O IGUAL A 60%");
        foreach (var alumno in ListadoAlumnos)
        {
            if(alumno.SacarPromedio() >= 60)
            {
                WriteLine($"-------------------------------------------------");
                WriteLine($"NOMBRE: {alumno.nombre}");
                WriteLine($"APELLIDO: {alumno.apellido}");
                WriteLine($"CARNET: {alumno.numeroIdentificacion}");
                WriteLine($"CARRERA: {alumno.carrera}");
                WriteLine($"PROMEDIO: {alumno.SacarPromedio()}");
            }
            
        }
        WriteLine($"-------------------------------------------------\n\n\n");

    }

    public static void ImprimePromedioGeneral()
    {
        WriteLine($"\n\n\n-------------------------------------------------\nPROMEDIO GENERAL");
        var resultado = 0.0;
        var cantidad = 0.0;
        foreach (var alumno in ListadoAlumnos)
        {
            resultado += alumno.SacarPromedio();
            cantidad++;
        }
        resultado = resultado / cantidad;
        WriteLine($"{resultado} %\n-------------------------------------------------");

    }
}

