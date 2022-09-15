using System;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Title = "Ejercicio I03 - Los primos";

        int numero;

        Console.WriteLine("Ingrese un numero: ");
        numero = Program.ValidarNumero();
        for(int i = numero; i >= 0; i--)
        {
            if(Program.EsPrimo(i) > 0)
            {
                Console.WriteLine($"Numeros Primos {i}");
            }
        }
    }
    private static int ValidarNumero()
    {
        int retorno = 0;
        int numero;
        while (!(int.TryParse(Console.ReadLine(), out numero)) || numero <= 0)
        {
            Console.WriteLine("ERROR! Reingrese un numero válido (o escriba ´salir´): ");
            if(Console.ReadLine() == "salir")
            {
                break;
            }
        }
        retorno = numero;
        return retorno;
    }
    private static int EsPrimo(int num)
    {
        int auxiliar = 0;
        int retorno;
        for (int i = 1; i < (num + 1); i++)
        {
            if (num % i == 0)
            {
               auxiliar++;
            }
        }
        if (auxiliar != 2)
        {
           retorno = 0;
        }
        else
        {
           retorno = num;
        }
        return retorno;
    }
}