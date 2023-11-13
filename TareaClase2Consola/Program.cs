using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaClase2Consola
{
    class Calculadora
    {
        
        //Funciones con las operaciones basicas.
        //-------------------------------------------
        // Método para sumar dos números
        public static double Sumar(double a, double b)
        {
            return a + b;
        }

        // Método para restar dos números
        public static double Restar(double a, double b)
        {
            return a - b;
        }

        // Método para multiplicar dos números
        public static double Multiplicar(double a, double b)
        {
            return a * b;
        }

        // Método para dividir dos números
        public static double Dividir(double a, double b)
        {
            if (b == 0)
            {
                Console.WriteLine("Error: No se puede dividir por cero.");
                return double.NaN; // Dividi y .NaN para que devuelva algo
            }
            return a / b;
        }
    }

    class Program
    {
        static void Main()
        {
            //Tarea 2 Reynoso
            Console.Beep();
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("###################################\n" +
                              "#        TESTING AUTOMATION       #\n" +
                              "###################################");
            Console.WriteLine("\n");
            // Ejemplo de uso de los métodos de la Calculadora
            Console.WriteLine("Ingresa 2 números para realizar las 4 operaciones basicas\n" +
                "Presiona ENTER despues de cada número que elijas.");
            double num1 = int.Parse(Console.ReadLine());
            double num2 = int.Parse(Console.ReadLine());
            Console.Beep();
            Console.WriteLine("Suma: " + Calculadora.Sumar(num1, num2));
            Console.WriteLine("Resta: " + Calculadora.Restar(num1, num2));
            Console.WriteLine("Multiplicación: " + Calculadora.Multiplicar(num1, num2));
            Console.WriteLine("División: " + Calculadora.Dividir(num1, num2));


            // Prueba de división por cero
            double resultado = Calculadora.Dividir(num1, 0);

            Console.ReadKey();
        }
    }
}