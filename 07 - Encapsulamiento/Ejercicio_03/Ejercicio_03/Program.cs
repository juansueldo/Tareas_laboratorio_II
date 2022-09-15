using Ejercicio_04.Class;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.Title = "Ejercicio C01 - Jugadores encapsulados";

        Equipo equipo = new Equipo(3, "Hamburgo");
        Jugador j1 = new Jugador(123, "Gustavo", 5, 20);
        Jugador j2 = new Jugador(485, "Ricardo", 3, 5);
        Jugador j3 = new Jugador(123, "Paul", 7, 3);
        Jugador j4 = new Jugador(789, "Edgardo", 3, 5);

        if (equipo + j1)
        {
            Console.WriteLine(j1.MostrarDatos());
        }

        if (equipo + j2)
        {
            Console.WriteLine(j2.MostrarDatos());
        }

        if (equipo + j3)
        {
            Console.WriteLine(j3.MostrarDatos());
        }
        else
        {
            Console.WriteLine("NO SE AGREGO " + j3.MostrarDatos());
        }

        if (equipo + j4)
        {
            Console.WriteLine(j4.MostrarDatos());
        }
        else
        {
            Console.WriteLine("NO SE AGREGO " + j4.MostrarDatos());
        }
    }
}