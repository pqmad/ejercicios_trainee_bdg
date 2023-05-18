using System;
using static System.Console;


namespace Inciso1;
class Program
{
    private static  List<Persona> ListadoPersonas = new List<Persona>();
    static void Main(string[] args)
    {
        var cantidad = 0;
        while (cantidad < 5)
        {
            WriteLine("Ingrese nombre:");
            var nombre = ReadLine().ToString();
            WriteLine($"Ingrese edad de {nombre}:");
            var edad = Convert.ToInt32(ReadLine());

            ListadoPersonas.Add(new Persona(nombre, edad));
            cantidad++;
        }
        ImprimeMayorEdad();
        ReadKey();
    }

    public static void ImprimeMayorEdad()
    {
        WriteLine("\n\n############## MAYORES DE EDAD ##############");
        foreach (var persona in ListadoPersonas)
        {
            if(persona.edad >= 18){
                WriteLine(persona.nombre);
            }
        }
    }
}

/*
 * 1- Desarrollar un programa que permita cargar 5 nombres de personas y 
 * sus edades respectivas. Luego de realizar la carga por teclado de todos 
 * los datos imprimir los nombres de las personas mayores de edad (mayores o iguales a 18 años), 
 * se tendrá que crear una clase "Persona" que contenga las propiedades "Nombre" y "Edad". 
 * Utilizar todos los componentes vistos hasta la fecha (bucles, funciones, clases).
 */