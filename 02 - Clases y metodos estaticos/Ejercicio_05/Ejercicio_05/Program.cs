using Ejercicio_05.Class;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.Title = "Ejercicio I05 - Aprendete las tablas";
        int numero;
        Console.WriteLine($"Ingrese un numero: ");
        numero = Tablas.ValidarNumero();

        Console.WriteLine($"{Tablas.MostrarTablas(numero)}");
    }
}