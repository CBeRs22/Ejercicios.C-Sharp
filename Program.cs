/*
 * Created by SharpDevelop.
 * User: leo_r
 * Date: 21/4/2023
 * Time: 22:06
 * 
 * Ídem al ejercicio anterior salvo que se imprima un mensaje de saludo diferente
 * según sea el nombre ingresado por el usuario.

 */
using System;

namespace Ejercicio3
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Write("Ingrese su nombre: ");
        	string nombre = Console.ReadLine();

        	Console.Write("Ingrese su apellido: ");
        	string apellido = Console.ReadLine();

        	string saludo = ObtenerSaludo(nombre);

        	Console.WriteLine(saludo + " " + apellido);
   		}

    	static string ObtenerSaludo(string nombre)
    	{
        	int cantidadCaracteres = nombre.Length;

        	if (cantidadCaracteres <= 3)
        	{
            	return "Hola";
        	}
        	else if (cantidadCaracteres <= 6)
        	{
          		return "Bienvenido";
        	}
        	else
        	{
            	return "Saludos";
        	}

			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}