/*
 * Created by SharpDevelop.
 * User: leo_r
 * Date: 21/4/2023
 * Time: 22:22
 * 
 * Escriba un programa de aplicación que lea por teclado una secuencia de números ( 10)
 * y que imprima el valor máximo, el  valor mínimo de dicho conjunto.
 */
using System;

namespace Ejercicio6
{
	class Program
	{
		public static void Main(string[] args)
		{
			double valorMaximo = Double.MinValue;
            double valorMinimo = Double.MaxValue;

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
            }
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}
