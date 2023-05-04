/*
 * Created by SharpDevelop.
 * User: leo_r
 * Date: 21/4/2023
 * Time: 22:09
 * 
 * Escriba un programa de aplicación que calcule la suma de dos números reales introducidos por teclado
 * y muestre el resultado en la consola.
 */
using System;

namespace Ejercicio4
{
	class Program
	{
		public static void Main(string[] args)
		{
			double suma, num1, num2;

			Console.WriteLine("Porfavor ingrese un numero real ");
			num1=double.Parse(Console.ReadLine());

			Console.WriteLine("Porfavor ingrese otro numero real");
			num2=double.Parse(Console.ReadLine());
			
			suma=num1 + num2;
			Console.WriteLine("La suma de ambos valores es: {0}", suma);
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}
