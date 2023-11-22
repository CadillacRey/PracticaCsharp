using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TareaClase5Consola
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Tarea 5 Reynoso
            Console.Beep();
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("###################################\n" +
                              "#        TESTING AUTOMATION       #\n" +
                              "###################################");
            Console.ResetColor();



            //Primer bucle
            while (true)

            {
                try
                {
                    Console.WriteLine("Seleccione una opción:");
                    Console.WriteLine("1. Fecha de Mundiales o Juegos Olimpicos");
                    Console.WriteLine("2. Salir");
                    Console.Write("Opción: ");
                    int opcion = int.Parse(Console.ReadLine());
                    switch (opcion)

                    {

                        case 1:
                            Console.WriteLine("Ingrese un año entre 1930 y 2022:");
                            int year = Convert.ToInt32(Console.ReadLine());

                            if (year >= 1930 && year <= 2022)
                            {
                                //Juegos
                                if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0) // || year % 400 == 0 Por si año bisiesto
                                    Console.WriteLine("En el año {0} se realizó un Juego Olímpico de Verano.", year);

                                //Mundial-- 1942 y 1946 no hubo mundial por la 2da guerra.
                                else if (year != 1942 || year != 1946)
                                    Console.WriteLine("En el año {0} no se realizó un Mundial de Fútbol por la 2da Guerra Mundial", year);
                                else if (year >= 1950 && year <= 2018 && year % 4 == 0)
                                    Console.WriteLine("En el año {0} se realizó un Mundial de Fútbol", year);
                                //Solo para Argentina
                                else if (year == 2022)
                                {
                                    Console.WriteLine("En el año {0} se realizo un Mundial de Fútbol. ¡Argentina al fin fue campeón! ¡Vamos Argentina!", year);
                                
                                }


                                else
                                    Console.WriteLine("En el año {0} no se realizó un Juego Olímpico de Verano ni un Mundial de Fútbol.", year);
                            }
                            else
                            {
                                Console.WriteLine("El año ingresado no está en el rango permitido.");
                            }
                            break;

                        case 2:
                            //Salir del programa
                            Console.WriteLine("¡Hasta luego!");
                            return;
                        default:
                            Console.WriteLine("Y esa opcion?");
                            break;
                    }
                }


                catch (FormatException)
                {
                    Console.WriteLine("Ingreso inválido. Por favor, ingrese un número entero. Intente nuevamente.");
                }

                Console.ReadKey();

            }
      

        }
  

    }

}


   



