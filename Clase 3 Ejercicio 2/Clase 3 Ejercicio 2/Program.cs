using System;
public class Clase_3_Ejercicio_2
{
    public static void Main()
    {
        Random dado1 = new Random();
        Random dado2 = new Random();
        int aleatorio1 = dado1.Next(1, 11);
        int aleatorio2 = dado2.Next(11, 21);

        Console.WriteLine("\nEl número del 1º dado es {0}", aleatorio1);
        Console.WriteLine("El número del 2º dado es {0}", aleatorio2);
        Console.ReadKey();
    }
}