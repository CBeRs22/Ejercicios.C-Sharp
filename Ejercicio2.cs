/*
 * Created by SharpDevelop.
 * User: leo_r
 * Date: 21/4/2023
 * Time: 21:54
 * 
 * Escriba un programa de aplicación que solicite al usuario ingresar su nombre y apellido,
 * e imprima en la consola un saludo personalizado.
 */
using System;

namespace Ejercicio2
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Ingresa tu Nombre: ");
            		string nombre = Console.ReadLine();

            		Console.WriteLine("Ingresa tu Apellido: ");
            		string apellido = Console.ReadLine();

            		Console.WriteLine("HOLA " + nombre + " " + apellido + ", BIENVENIDO!!! ");
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}
