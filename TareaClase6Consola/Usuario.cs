using System;

namespace TareaClase6Consola
{
    public class Usuario
    {
        /*Tarea 6 Reynoso
         * Crear la clase "Usuario" con las propiedades "nombre del usuario", "apellido del usuario", "mail del usuario", "contraseña",
         * "fecha de nacimiento del usuario", "dirección del usuario" y "teléfono del usuario'", y
         * el método "Comprar" (con un WriteLine que diga el nombre y apellido, "esta comprando").
         */
        public string NombreDelUsuario { get; set; }
        public string ApellidoDelUsuario { get; set; }
        public string Mail { get; set; }
        public string Contraseña { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Direccion { get; set; }
        public int Telefono { get; set; }

        public void Comprar()
        {
            Console.WriteLine($"{NombreDelUsuario} {ApellidoDelUsuario} está comprando:");         
        }
    }


}
