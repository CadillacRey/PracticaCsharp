using System;
using System.Collections.Generic;



namespace Program
{

    static class Program
    {

        static void Main(string[] args)
        {

            //Calculadora creada en clase
            //Capaz con la logica crear un forms


            bool quieroSalir = false;
            const int cantDeVeces = 35;

            while (quieroSalir == false)
            {
                quieroSalir = Calculadora(quieroSalir, cantDeVeces);
            }
        }

        private static bool Calculadora(bool quieroSalir, int cantDeVeces)
        {
            int operador1, operador2, tipoOperacion;
            int resultado = 0;

            Console.Clear();
            try
            {
                Encabezado(cantDeVeces);

                Console.WriteLine("Ingrese primer operador:");
                operador1 = int.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese segundo operador:");
                operador2 = int.Parse(Console.ReadLine());

                Menu();

                tipoOperacion = int.Parse(Console.ReadLine());

                if (tipoOperacion <= 4 && tipoOperacion >= 0)
                {
                    switch (tipoOperacion)
                    {
                        case 1:
                            resultado = Sumar(operador1, operador2);
                            break;
                        case 2:
                            resultado = Restar(operador1, operador2);
                            break;
                        case 3:
                            resultado = Multiplicar(operador1, operador2);
                            break;
                        case 4:
                            resultado = Dividir(operador1, operador2);
                            break;
                        case 0:
                            quieroSalir = true;
                            break;

                    }

                    if (quieroSalir == false)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        DibujarLinea("*", cantDeVeces);
                        Console.WriteLine($"El resultado es {resultado}");
                        DibujarLinea("*", cantDeVeces);
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.White;

                    }
                    else
                    {

                        Console.WriteLine("Gracias por usar la calculadora");
                    }

                }
                else
                {
                    Console.WriteLine("Dato ingresado incorrecto");
                }
            }
            catch (Exception error)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"ERROR, mensaje: {error.Message}");
                Console.WriteLine($"Ruta del error: {error.StackTrace}");
                Console.Beep();
                Console.ForegroundColor = ConsoleColor.White;
            }

            Console.ReadKey();
            return quieroSalir;
        }

        private static void Menu()
        {
            Console.WriteLine("Ingrese la opcion requerida:");
            Console.WriteLine("-1- Suma");
            Console.WriteLine("-2- Resta");
            Console.WriteLine("-3- Multiplicacion");
            Console.WriteLine("-4- Division");
            Console.WriteLine("-0- Salir");
        }

        private static void Encabezado(int cantDeVeces)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            DibujarLinea("=", cantDeVeces);
            Console.WriteLine("Mi maravillosa Super Calculadora");
            DibujarLinea("=", cantDeVeces);
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
        }

        #region operaciones
        public static int Sumar(int numero1, int numero2)
        {
            return numero1 + numero2;
        }

        public static int Restar(int numero1, int numero2)
        {
            return numero1 - numero2;
        }
        public static int Multiplicar(int numero1, int numero2)
        {
            return numero1 * numero2;
        }

        public static int Dividir(int numero1, int numero2)
        {
            return numero1 / numero2;
        }
        #endregion

        public static void DibujarLinea(string caracter, int cantDeVeces)
        {
            for (int i = 1; i <= cantDeVeces; i++)
            {
                Console.Write(caracter);
            }
            Console.WriteLine();
        }

        


    }

    

}

