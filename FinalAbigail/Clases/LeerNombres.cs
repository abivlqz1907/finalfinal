using System;
namespace FinalAbigail.Clases
{
    public class LeerNombres
    {



        public static string GetNames()
        {
            string cadena = null;
            string[] separados = null;

            try
            {
                Console.WriteLine("Escribe tu nombre y apellido separados por espacios ");
                cadena = Console.ReadLine();

                separados = cadena.Split(' ');
                if (separados[0].Length >= 2 || separados[1].Length >= 2)
                {
                    string nombre = separados[0];
                    string apellido = separados[1];
                    if (separados[0].Length >= 2 && separados[1].Length >= 2)
                        Console.WriteLine("Tu nombre es:{0} y tu apellido es: {1}", nombre, apellido);


                }
                else separados = null;

                return separados[3];

            }
            catch (IndexOutOfRangeException)
            {
                if (separados[0].Length <= 2 || separados[1].Length <= 2)
                {
                    Console.WriteLine("nombre/apellido no valido");
                }


                return null;

            }


        }
    }
}
