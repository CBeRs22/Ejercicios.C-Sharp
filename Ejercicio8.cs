/*
 * Created by SharpDevelop.
 * User: leo_r
 * Date: 21/4/2023
 * Time: 22:33
 * 
 * Implemente un programa de aplicación que permita al usuario ingresar números por la consola.
 * A medida que se van ingresando los valores el sistema debe mostrar por la consola la suma acumulada de los mismos.
 * El  proceso termina cuando se ingresa un 0.
 * Informar al final la cantidad total de números ingresados y sumados.
 */
using System;

namespace Ejercicio8
{
	class Program
	{
		public static void Main(string[] args)
		{
			double suma = 0;
            int contador = 0;

            Console.WriteLine("Ingrese un número (ingrese 0 para finalizar):");

            while (true)
            {
                string numeroStr = Console.ReadLine();
                double numero = Double.Parse(numeroStr);

                if (numero == 0)
                {
                    break;
                }

                suma += numero;
                contador++;
                Console.WriteLine("Suma acumulada: " + suma);
            }

            Console.WriteLine("Se ingresaron " + contador + " números y la suma total es " + suma + ".");
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}
