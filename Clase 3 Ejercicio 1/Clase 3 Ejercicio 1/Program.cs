using System;
namespace Clase_3_Ejercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int miliseg = DateTime.Now.Millisecond;
            int numero = miliseg % 100 + 1;
            Console.WriteLine("\nNúmero al azar del 1 al 100: {0}", numero);
        }
    }
}
