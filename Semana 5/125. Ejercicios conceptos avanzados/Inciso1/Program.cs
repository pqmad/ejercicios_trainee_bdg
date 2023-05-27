using System;
using static System.Console;


namespace Inciso1;
class Program
{
    static void Main(string[] args)
    {
        Dictionary<int, string> diccionario = new Dictionary<int, string>();
        var clave = 0;
        var valor = "";
        do
        {
            WriteLine("\nIngresa un numero entero");
            clave = Convert.ToInt32(ReadLine());
            if (clave != 0)
            {
                WriteLine("Ingresa un valor");
                valor = Convert.ToString(ReadLine());
                diccionario.Add(clave, valor);
            }
        } while (clave != 0);

        do
        {
            WriteLine("Ingresa una cadena de 2 letras");
            valor = Convert.ToString(ReadLine());
        } while (valor.Length != 2);

        WriteLine("\n\ntodas las claves que contienen esos 2 caracteres " +
            "en los valores del diccionario.\n\n");

        foreach (KeyValuePair<int, string> item in diccionario)
        {
            if (item.Value.ToLower().Contains(valor))
            {
                WriteLine(item.Key);
            }
        }
        ReadKey();
    }
}



/*
 * 1- Crea un programa que use un diccionario, clave entera y valor string. 
 * Se pedirá por consola, un numero y un a cadena, que se ira insertando 
 * en el diccionario, hasta que se introduzca el valor "0". una vez se pulse "0", 
 * se pedirá por pantalla que se introduzca una cadena de 2 letras.  se mostrara 
 * consultando el diccionario,todas las claves que contienen esos 2 caracteres 
 * en los valores del diccionario.
 */