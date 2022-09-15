using Ejercicio_03.Class;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.Title = "Ejercicio C01 - Conversor binario recargado";
        NumeroBinario nb = (NumeroBinario)"1001";
        NumeroDecimal nd = (NumeroDecimal)9;
        Console.WriteLine($"El numero binario: {nb.Numero} sumado al numero decimal es {nb + nd}");
        Console.WriteLine($"El numero decimal: {nd.Numero} sumado al numero decimal es {nd + nb}");
    }
}