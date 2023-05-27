using System;
using static System.Console;
using System.IO;
using System.Text;


namespace Inciso1;
class Program
{
    static void Main(string[] args)
    {
        var nombre = "";
        var edad = 0;
        var localidad = "";
        var seguir = "s";
        while (!seguir.ToLower().Contains("n"))
        {
            WriteLine("Escriba un nombre:");
            nombre = ReadLine();
            WriteLine("Escriba la edad:");
            edad = Convert.ToInt32(ReadLine());
            WriteLine("Escriba una localidad:");
            localidad = ReadLine() ;
            Persona persona = new Persona(nombre, edad, localidad);
            EscrbirArchivo(persona.CrearCadena());

            WriteLine("Quiere seguir agregando? \"S\" para si y \"N\" para no");
            seguir = ReadLine();
        }
        LeerArchivo();
        ReadKey();

    }
    public static void EscrbirArchivo(string cadena)
    {
        var ruta = "personas.txt";
        FileStream archivo;
        if (File.Exists(ruta))
        {
            archivo = new FileStream(ruta, FileMode.Append);
        }
        else
        {
            archivo = new FileStream(ruta, FileMode.Create);
        }
        archivo.Write(ASCIIEncoding.ASCII.GetBytes(cadena), 0, cadena.Length);
        archivo.Close();
    }

    public static void LeerArchivo()
    {
        var ruta = "personas.txt";
        byte[] contenido = new byte[10000];
        FileStream archivo = new FileStream(ruta, FileMode.Open);
        archivo.Read(contenido, 0, (int)archivo.Length);
        ImprimirArchivo(ASCIIEncoding.ASCII.GetString(contenido));
    }

    public static void ImprimirArchivo(string cadena)
    {
        WriteLine("\nCONTENIDO DEL ARCHIVO");

        var splitCadena = cadena.Split(";");
        foreach (var persona in splitCadena)
        {
            var splitPersona = persona.Split("|");
            if (splitPersona.Length == 3)
            {
                Persona tipoPersona = new Persona(
                splitPersona[0],
                Convert.ToInt32(splitPersona[1]),
                splitPersona[2]);
                tipoPersona.InformacionAlmacenada();
            }
            
        }
    }
}

