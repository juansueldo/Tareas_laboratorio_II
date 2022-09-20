using Clases;

internal class Program
{
    private static void Main(string[] args)
    {
        AutoF1 a1 = new AutoF1(1, "FORD");
        AutoF1 a2 = new AutoF1(2, "FERRARI");

        MotoCross m1 = new MotoCross(1, "HONDA");
        MotoCross m2 = new MotoCross(2, "YAMAHA");

        Competencia c1 = new(3, 2, TipoCompetencia.F1);
        if (c1 + a1)
        {
            Console.WriteLine($"SUMADO A LA COMPETENCIA: {a1.MostrarDatos()}");
        }
        else
        {
            Console.WriteLine($"NO FUE SUMADO A LA COMPETENCIA: {a1.MostrarDatos()}");
        }
        Console.WriteLine("Hello, World!");
    }
}