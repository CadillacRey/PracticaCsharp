using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TareaClase6Consola
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Tarea 6 Reynoso
            Console.Beep();
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("###################################\n" +
                              "#        TESTING AUTOMATION       #\n" +
                              "###################################");
            Console.ResetColor();

            // Instancias de las clases
            Usuario usuario = new Usuario
            {
                NombreDelUsuario = "Emanuel",
                ApellidoDelUsuario = "Reynoso",
                Mail = "emanuel.reynoso@unahurtesting.com",
                Contraseña = "123456",
                FechaNacimiento = new DateTime(1988, 2, 04),
                Direccion = "Av. Gdor. Vergara 2222, Villa Tesei, Provincia de Buenos Aires",
                Telefono = 1141907745
            };
           
            Banana banana1 = new Banana
            {
                Marca = "Dolca",
                Precio = 2000,
                Peso = 20,
                Procedencia = "Uruguay"
            };

            Banana banana2 = new Banana 

            {
                Marca = "Ecuador",
                Precio = 5,
                Peso = 0.02,
                Procedencia = "Colombia"
            };

            Cerveza cerveza1 = new Cerveza
            {
                Marca = "Patagonia",
                Precio = 15,
                Peso = 0.1,
                Procedencia = "Alemania"

            };

            // Realizar la compra
            usuario.Comprar();
            banana1.Comprar2();
            banana2.Comprar2();
            cerveza1.Comprar3();
            Console.ReadKey();
            
            






        }
    }

}


           




