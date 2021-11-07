using System;

namespace Conversiones_de_sistemas_numéricos
{
    class Program
    {
        static void Main(string[] args)
        {
            string salir = "n";  // este es el caracter clave para no detener el programa y seguir ejecutandolo.

            Console.WriteLine("CONVERSIÓN DE UN NUMERO DECIMAL A BINARIO");

            while (salir == "n")                    // esto es para que se repita el programa si el que lo ejecuta quiere seguir en el.
            {

                Console.Write("\nIngresar numero a convertir:");    // Aqui se ingresa la cantidad que queremos converitir a binario

                int numero = Convert.ToInt32(Console.ReadLine());
                    String binario = "";

                if (numero > 0)
                {
                    while (numero > 0)
                    {

                        if (numero % 2 == 0)
                        {

                            binario = "0" + binario;
                        }
                        else
                        {

                            binario = "1" + binario;
                        }

                        numero = (int)numero / 2;
                    }
                    Console.WriteLine("En binario es:" + binario);
                }
                else
                {
                    if (numero == 0)
                    {
                        Console.WriteLine("0");
                    }
                    else
                    {
                        Console.WriteLine("Solo se aceptan numero positivos");
                    }
                }

                Console.WriteLine("\n¿Desea salir [s|n]");
                    salir = Console.ReadLine();
                
            }
        }
    }
}




