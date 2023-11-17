using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaClase4ConsolaYTablaDeVerdad
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Tarea 4 Reynoso
            Console.Beep();
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("###################################\n" +
                              "#        TESTING AUTOMATION       #\n" +
                              "###################################");
            Console.WriteLine("\n");
            Console.ResetColor();
            while (true)
            {
                try
                {
                    Console.WriteLine("Seleccione una opción:");
                    Console.WriteLine("1. Machete de tablas del 1 al 10");
                    Console.WriteLine("2. Salir");

                    // Solicito al usuario que seleccione una opción para entrar al bucle
                    Console.Write("Opción: ");
                    int opcion = int.Parse(Console.ReadLine());

                    switch (opcion)
                    {
                        case 1:
                            //Acá ya en el machete solicito al usuario que ingrese un número
                            Console.Write("Ingrese un número entre 1 y 10: ");
                            int numero = int.Parse(Console.ReadLine());

                            //Verificar el número
                            if (numero >= 1 && numero <= 10)
                            {
                                //Mostrar las multiplicaciones del número ingresado del 0 al 10
                                Console.WriteLine($"Tabla de multiplicar del {numero}:");
                                for (int i = 0; i <= 10; i++)
                                {
                                    int resultado = numero * i;
                                    Console.WriteLine($"{numero} x {i} = {resultado}");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Ingreso inválido. El número debe estar entre 1 y 10. Intente nuevamente.");
                            }
                            break;

                        case 2:
                            //Salir del programa
                            Console.WriteLine("¡Hasta luego!");
                            return;

                        default:
                            Console.WriteLine("Opción inválida. Intente nuevamente.");
                            break;
                    }

                    Console.ReadKey();
                }
                catch (FormatException)
                {
                    Console.WriteLine("Ingreso inválido. Por favor, ingrese un número entero. Intente nuevamente.");
                }
            }
        }
    }
}
