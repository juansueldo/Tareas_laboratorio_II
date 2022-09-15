internal class Program
{
    private static void Main(string[] args)
    {
        Console.Title = "Ejercicio A01 - Calcular un factorial";

        int numero;
        Console.WriteLine($"Ingrese un numero para calcular el factorial: ");
        numero = ValidarNumero();
        Console.WriteLine($"El factorial de {numero} es: {Factorial(numero)}");
    }
    private static double Factorial(int numero)
    {
        double factorial = 1;
        while (numero != 0)
        {
            factorial = factorial * numero;
            numero--;
        }
        return factorial;
    }
    public static int ValidarNumero()
    {
        int retorno = 0;
        int numero;
        while (!(int.TryParse(Console.ReadLine(), out numero)))
        {
            Console.WriteLine("ERROR! Reingrese un numero válido: ");
        }
        retorno = numero;
        return retorno;
    }
}