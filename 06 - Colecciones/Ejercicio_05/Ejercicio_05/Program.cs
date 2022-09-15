using Ejercicio_05.Class;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.Title = "Ejercicio C02 - Enciendan sus motores";
        AutoF1 a1 = new AutoF1(1, "MERCEDES");
        AutoF1 a2 = new AutoF1(2, "RENAULT");
        AutoF1 a3 = new AutoF1(3, "FERRARI");
        AutoF1 a4 = new AutoF1(4, "HONDA");

        Competencia c = new Competencia(3, 5);
        if(c + a1)
        {
            Console.WriteLine($"SUMADO A LA COMPETENCIA: {a1.MostrarDatos()}");
        }
        else
        {
            Console.WriteLine($"NO FUE SUMADO A LA COMPETENCIA: {a1.MostrarDatos()}");
        }
        if (c + a2)
        {
            Console.WriteLine($"SUMADO A LA COMPETENCIA: {a2.MostrarDatos()}");
        }
        else
        {
            Console.WriteLine($"NO FUE SUMADO A LA COMPETENCIA: {a2.MostrarDatos()}");
        }
        if (c + a3)
        {
            Console.WriteLine($"SUMADO A LA COMPETENCIA: {a3.MostrarDatos()}");
        }
        else
        {
            Console.WriteLine($"NO FUE SUMADO A LA COMPETENCIA: {a3.MostrarDatos()}");
        }
        if (c + a4)
        {
            Console.WriteLine($"SUMADO A LA COMPETENCIA: {a4.MostrarDatos()}");
        }
        else
        {
            Console.WriteLine($"NO FUE SUMADO A LA COMPETENCIA: {a4.MostrarDatos()}");
        }
        if (c - a1)
        {
            Console.WriteLine($"ELIMINADO DE LA COMPETENCIA: {a1.MostrarDatos()}");
        }
        else
        {
            Console.WriteLine($"NO FUE ELIMINADO DE LA COMPETENCIA: {a1.MostrarDatos()}");
        }
        Console.WriteLine($"{c.MostrarDatos()}");
    }
}