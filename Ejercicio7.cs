/*
 * Created by SharpDevelop.
 * User: leo_r
 * Date: 21/4/2023
 * Time: 22:30
 * 
 * Continuando con el ejercicio 6 se pide calcular  el valor promedio de los numeros ingresados.
 */
using System;

namespace Ejercicio7
{
	class Program
	{
		public static void Main(string[] args)
		{
			double valorMaximo = Double.MinValue;
            double valorMinimo = Double.MaxValue;
            double suma = 0;

            Console.WriteLine("Por favor, ingresa una secuencia de 10 números:");

            for (int i = 1; i <= 10; i++)
            {
                Console.Write("Número " + i + ": ");
                string numeroStr = Console.ReadLine();
                double numero = Double.Parse(numeroStr);

                if (numero > valorMaximo)
                {
                    valorMaximo = numero;
                }

                if (numero < valorMinimo)
                {
                    valorMinimo = numero;
                }

                suma += numero;
            }

            double promedio = suma / 10;

            Console.WriteLine("El valor máximo es: " + valorMaximo);
            Console.WriteLine("El valor mínimo es: " + valorMinimo);
            Console.WriteLine("El valor promedio es: " + promedio);
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}
