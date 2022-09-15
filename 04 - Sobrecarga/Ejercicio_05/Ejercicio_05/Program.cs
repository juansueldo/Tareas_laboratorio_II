using Temperatura;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.Title = "Ejercicio A01 - Fahrenheit 451";


        Fahrenheit f = new Fahrenheit(0);
        Celsius c = new Celsius(1);
        Kelvin k = new Kelvin(405);

        Celsius aux = c + f;

        Console.WriteLine(aux.GetCelsius);
    }
}