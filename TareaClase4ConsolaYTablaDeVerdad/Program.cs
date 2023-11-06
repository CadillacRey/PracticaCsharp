using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaClase4ConsolaYTablaDeVerdad
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Beep();
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("###################################\n" +
                              "#        TESTING AUTOMATION       #\n" +
                              "###################################");
            Console.WriteLine("\n");

            int numero;

            while (true)
            {
                Console.WriteLine("Ingrese un número entre 1 y 10:");
                string entradaPorTeclado = Console.ReadLine();

                try
                {
                    numero = int.Parse(entradaPorTeclado);

                    if (numero >= 1 && numero <= 10)
                    {
                        Console.WriteLine($"Tabla de multiplicar del {numero}:");

                        for (int i = 0; i <= 10; i++)
                        {
                            int resultado = numero * i;
                            Console.WriteLine($"{numero} x {i} = {resultado}");
                        }

                        break;  // Salir del bucle si se ingresa un número válido
                    }
                    else
                    {
                        Console.WriteLine("Número fuera del rango permitido. Intente nuevamente.");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Ingreso no es un número válido. Intente nuevamente.");
                }
            }
        }
    }
}
