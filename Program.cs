using System;

namespace T09_Ejercicio8
{
    class Password
    {
        private string contraseña;
        private int longitud;

        public Password()
        {
            longitud = 8;
        }

        public Password(int newlongitud)
        {
            Random rdn = new Random();
            string caracteres = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890%$#@";
            int listaCaracteres = caracteres.Length;
            for (int i = 0; i < newlongitud; i++)
            {
                char letra = caracteres[rdn.Next(listaCaracteres)];
                contraseña += letra;
            }
            Console.WriteLine(contraseña);
        }
    }
}