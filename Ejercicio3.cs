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

	class Program {
    	static void Main(string[] args) {
        	Console.Write("Ingresa tu nombre: ");
        	string nombre = Console.ReadLine();

        	Console.Write("Ingresa tu apellido: ");
        	string apellido = Console.ReadLine();

        	int longitudNombre = nombre.Length;

        	if (longitudNombre <= 4) {
            	Console.WriteLine("HOLA {0} {1}, BIENVENIDO!!!", nombre, apellido);
        	} else if (longitudNombre <= 8) {
            	Console.WriteLine("HOLA {0} {1}, VOLVISTE!", nombre, apellido);
        	} else {
            	Console.WriteLine("HOLA {0} {1}, ME ALEGRA VERTE POR ACÁ DE NUEVO!", nombre, apellido);
        	}
        	Console.Write("Press any key to continue . . . ");
        	Console.ReadKey(true);
    	}
	}
}
