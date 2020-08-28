using System;
namespace Clase_3_Ejercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int numero, vidas = 3;
            int aleatorio = r.Next(1, 7);
            do
            {
                Console.WriteLine("\n¿Qué número es?");
                numero = Convert.ToInt32(Console.ReadLine());
                if (numero == aleatorio)
                {
                    Console.WriteLine("\nHas acertado!");
                    vidas = 0;
                }
                else
                {
                    vidas -= 1;
                    Console.WriteLine("\nIncorrecto!");
                    Console.WriteLine("Te quedan: {0} vidas", vidas);
                    if (numero > aleatorio && vidas != 0)
                        Console.WriteLine("\nPrueba con un numero mas chico!");
                    if (numero < aleatorio && vidas != 0)
                        Console.WriteLine("\nPrueba con un numero mas grande!");
                    if (vidas == 0)
                        Console.WriteLine("Has perdido");
                }
            } while (vidas != 0);
            Console.ReadKey();
        }
    }
}