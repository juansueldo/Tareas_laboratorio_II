using Ejercicio_03.Class;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.Title = "Ejercicio I03 - Conversor binario";
        int numero;
        Console.WriteLine("Ingrese el numero entero: ");
        numero = Validador.ValidarNumero();
        Console.WriteLine($"Conversion a binario: {Conversor.ConvertirDecimalABinario(numero)}");

       
        Console.WriteLine("Ingrese el numero binario: ");
        numero = Validador.ValidarNumero();
        Console.WriteLine($"Conversion a decimal {Conversor.ConvertirBinarioADecimal(numero)}");
        
    }
}