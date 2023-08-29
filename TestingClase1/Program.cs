using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingClase1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;

            Console.WriteLine("*************************");

            Console.WriteLine("* * PORTAL HACIA GATONEKO * *");

            Console.WriteLine("*************************");

            Console.WriteLine("Hola, ¿como te llamas?");

            var usuario = Console.ReadLine();

            Console.WriteLine($"Bienvenido {usuario}");

            Console.WriteLine("Queres ir a GATONEKO?");

            Console.WriteLine("Escribi, SI o NO");

            String respuesta = Console.ReadLine();



            if (respuesta == "SI" || respuesta == "si" || respuesta == "Si")

            {

                Console.WriteLine("Veni al campito");

            }



            else

            {

                Console.WriteLine("Anda a Dormir");

            }

            Console.ReadKey();
            
            /*
            //Esto es un comentario
            //Otro comentario para ver en git 

            //const string hola = "Emanuel";
            Console.WriteLine("Bienvenido Dante");
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;
            //Console.WriteLine($"Hola {nombre} {apellido}, saludos");
            //esto es en vez de hacer nombre + " " + apellido
            //bool numeroValido = true;
            //while (!numeroValido)
            {

                Console.WriteLine("Ingresa tu Numero por favor: ");

                string userInput = Console.ReadLine();

                if (int.TryParse(userInput, out int numero))
                {
                    if (numero != 21)
                    {
                        Console.WriteLine("Usuario incorrecto");
                        //numeroValido = true;


                    }



                else
                    {
                        Console.WriteLine("Te ganaste una Switch");
                    }

                }
                Console.ReadKey();

            */

        }

        
        
    }


}


