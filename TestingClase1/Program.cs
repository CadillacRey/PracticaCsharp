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
                              "#       TESTING AUTOMATION        #\n" +
                              "###################################");

            Console.WriteLine("\n");
            Console.WriteLine("¡Hola!, Ingresa tu nombre por favor:");
            var nombre = Console.ReadLine();
            Console.WriteLine("\n");
            Console.WriteLine($"Mucho gusto, {nombre}");
            Console.WriteLine("\n");
            Console.WriteLine("Ingresa tu apellido, por favor:");
            var apellido = Console.ReadLine();
            Console.WriteLine("\n");
            Console.WriteLine("Necesito ahora que ingreses tu E-mail, por favor:");
            var email = Console.ReadLine();
            Console.WriteLine("\n");
            Console.WriteLine("Tambien tu fecha de nacimiento:");
            var fecha = Console.ReadLine();
            Console.WriteLine("\n");
            Console.WriteLine("Ahora que ingreses tu dirección, por favor:");
            var direccion = Console.ReadLine();
            Console.WriteLine("\n");
            Console.WriteLine("Por ultimo necesito tu telefono, por favor:");
            var telefono = Console.ReadLine();
            Console.WriteLine("\n");
            Console.WriteLine("Se ha registrado correctamente.");
            Console.WriteLine("\n");
            Console.WriteLine("\n");
            Console.WriteLine($"¡Bienvenido! Sus datos son:" +

                $"\n"+
                $"\nNombre:{nombre} " +
                $"\nApellido: {apellido} " +
                $"\nE-Mail: {email} " +
                $"\nFecha de nacimiento: {fecha} " +
                $"\nDirección:{direccion} " +
                $"\nTelefono: {telefono} ");



            Console.ReadKey();


        }


    }


}




