using System;
namespace Clase_3_Ejercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int numero, aleatorio;
            int intentos = 13;
            aleatorio = r.Next(1, 10001);
            Console.WriteLine("Intenta adivinar el numero escondido!");
            Console.WriteLine("Tienes {0} intentos! Mucha suerte!!", intentos);
            do
            {
                Console.WriteLine("\n¿Qué número crees que sea?");
                numero = Convert.ToInt32(Console.ReadLine());

                if (numero == aleatorio)
                    Console.WriteLine("\nCORRECTO! Has GANADO");
                else
                {
                    intentos -= 1;

                    Console.WriteLine("\nIncorrecto! Te quedan {0} intentos", intentos);
                    if (numero < aleatorio && intentos != 0)
                        Console.WriteLine("El número es más grande, vuelve a intentarlo");
                    if (numero > aleatorio && intentos != 0)
                        Console.WriteLine("El número es más chico, vuelve a intentarlo");

                    if (intentos == 0)
                    {
                        Console.WriteLine("Perdiste!!");
                        Console.WriteLine("La solucion es {0}", aleatorio);
                    }
                }
            } while (numero != aleatorio && intentos != 0);
            Console.ReadKey();
        }
    }
}