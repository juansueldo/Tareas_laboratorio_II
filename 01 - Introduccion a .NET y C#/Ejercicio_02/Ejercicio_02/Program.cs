internal class Program
{
    private static void Main(string[] args)
    {
        Console.Title = "Ejercicio I02 - Error al cubo";

        int numero;
        Console.WriteLine("Ingrese un numero: ");
        numero = Program.ValidarNumero();
        Console.WriteLine($"El numero al cuadrado es {Math.Pow(numero, 2)}");
        Console.WriteLine($"El numero al cubo es {Math.Pow(numero, 3)}");

    }
    private static int ValidarNumero()
    {
        int retorno = 0;
        int numero;
        while (!(int.TryParse(Console.ReadLine(), out numero)) || numero <= 0)
        {
            Console.WriteLine("ERROR! Reingrese un numero válido: ");
        }
        retorno = numero;
        return retorno;
    }
}