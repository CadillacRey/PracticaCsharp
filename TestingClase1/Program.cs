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





            //GIT TESTING AUTOMATION
            //Tarea 1
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("###################################\n" +
                              "#             SYSTEM              #\n" +
                              "###################################");


            Console.WriteLine("Hola!, Ingresa tu nombre por favor:");
            var nombre = Console.ReadLine();

            Console.WriteLine($"Mucho gusto {nombre}");

            Console.WriteLine("Ingresa tu apellido, por favor:");
            var apellido = Console.ReadLine();
            
            Console.WriteLine("Necesito ahora que ingreses tu E-mail, por favor:");
            var email = Console.ReadLine();

            Console.WriteLine("Tambien tu fecha de nacimiento:");
            var fecha = Console.ReadLine();

            Console.WriteLine("Ahora que ingreses tu dirección, por favor:");
            var direccion = Console.ReadLine();

            Console.WriteLine("Por ultimo necesito tu telefono, por favor:");
            var telefono = Console.ReadLine();

            Console.WriteLine("Se ha registrado correctamente.");
            Console.WriteLine($"¡Bienvenido! Su datos son:" +
                $"\nNombre:{nombre} " +
                $"\nApellido: {apellido} " +
                $"\nE-Mail: {email} " +
                $"\nFecha de nacimiento: {fecha} " +
                $"\nDirección:{direccion} " +
                $"\nTelefono: {telefono} ");



            Console.ReadKey();




            /*
             * 
             * Proyecto para Dante desde aca
            Console.BackgroundColor = ConsoleColor.DarkBlue;

            Console.WriteLine("###################################\n" +
                              "#       PORTAL A GATONEKO         #\n" +
                              "###################################");

            Console.WriteLine("Hola, ¿como te llamas?");

            var usuario = Console.ReadLine();  //Si es dante ahh oi hablar de vos... 

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

            */



        }


    }


}




