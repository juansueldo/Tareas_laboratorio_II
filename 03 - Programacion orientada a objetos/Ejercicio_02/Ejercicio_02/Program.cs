using Ejercicio_02.Class;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.Title = "Ejercicio I02 - ¿Vos cuántas primaveras tenés?";

        DateTime fecha = new DateTime(1989, 03, 29);
        Persona p1 = new Persona("Juan",fecha, "34502341");

        if (p1.EsMayorDeEdad() == "Es mayor de edad")
        {
            Console.WriteLine($"{p1.Mostrar()}");
        }

        DateTime fecha2 = new DateTime(2019, 05, 06);
        Persona p2 = new Persona("Emilia", fecha2, "34502341");

        if (p2.EsMayorDeEdad() == "Es mayor de edad")
        {
            Console.WriteLine($"{p2.Mostrar()}");
        }


    }
}