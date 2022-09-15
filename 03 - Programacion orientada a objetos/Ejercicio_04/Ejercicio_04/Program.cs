using Ejercicio_04.Class;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.Title = "Ejercicio I04 - Invento argentino";

        string diubjo;
        Boligrafo b1 = new Boligrafo(ConsoleColor.Blue, 100);
        Boligrafo b2 = new Boligrafo(ConsoleColor.Red, 50);

        Console.ForegroundColor = b1.GetColor();
        b1.Pintar(5, out diubjo);

        Console.ForegroundColor = b2.GetColor();
        b1.Pintar(89, out diubjo);

    }
}