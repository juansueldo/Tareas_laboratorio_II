using Ejercicio_06.Class;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.Title = "Ejercicio A01 - Vienen con sistema de auto-navegación";
        Conductores c1 = new Conductores("Juan", 25, 35, 40, 30, 33, 29, 0);
        Conductores c2 = new Conductores("Manuel", 22, 38, 41, 30, 22, 11, 0);

        Conductores c3 = Conductores.MasKm(c1, c2);
        Console.WriteLine($"{c3.Mostrar()}");
    }
}