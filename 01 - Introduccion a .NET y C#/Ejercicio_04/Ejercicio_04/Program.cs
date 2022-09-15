using System;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Title = "Ejercicio I04 - Un número perfecto";
        int numero = int.MaxValue;
        
        Program.NumeroPerfecto(numero);
        
    }
    private static int ValidarNumero()
    {
        int retorno = 0;
        int numero;
        while (!(int.TryParse(Console.ReadLine(), out numero)) || numero <= 0)
        {
            Console.WriteLine("ERROR! Reingrese un numero válido (o escriba ´salir´): ");
            if (Console.ReadLine() == "salir")
            {
                break;
            }
        }
        retorno = numero;
        return retorno;
    }
    private static void NumeroPerfecto(int numero)
    {
        int j, b;
        string divisores = "";
        for (int i = 1; i <= numero; i++)
        {
            b = 0;

            for (j = 1; j <= (i / 2); j++)
            {
                if (i % j == 0)
                {
                    b += j;
                    divisores += j + " ";
                }
            }
            if (b == i)
                Console.WriteLine($"El numero {i} es perfecto y su divisores son: {divisores}");
            divisores = "";
        }
    }
}