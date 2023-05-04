/*
 * Created by SharpDevelop.
 * User: leo_r
 * Date: 21/4/2023
 * Time: 22:18
 * 
 * Escriba un programa de aplicación que solicite al usuario que ingrese un número de mes (1 a 12)
 * e imprima el nombre  del mes correspondiente.
 * Si el valor ingresado no está en ese rango debe imprimir “Mes inválido ”.
 */
using System;

namespace Ejercicio5
{
	class Program
	{
		public static void Main(string[] args)
		{
			int mes;

			Console.WriteLine("ingrese un valor entre 1 y 12 referido a un mes del año");
			mes=int.Parse(Console.ReadLine());

			switch (mes) {
			case 1:
				Console.WriteLine("enero"); break;
			case 2:
				Console.WriteLine("febrero");break;
			case 3:
				Console.WriteLine("marzo"); break;
			case 4:
				Console.WriteLine("abril"); break;
			case 5:
				Console.WriteLine("mayo");break;
			case 6:
				Console.WriteLine("junio");break;
			case 7:
				Console.WriteLine("julio"); break;
			case 8:
				Console.WriteLine("agosto");break;
			case 9:
				Console.WriteLine("septiembre");break;
			case 10:
				Console.WriteLine("octubre"); break;
			case 11:
				Console.WriteLine("noviembre"); break;
			case 12:
				Console.WriteLine("diciembre"); break;
			default:
				Console.WriteLine("error de tipeo"); break;
			}
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}
