using Ejercicio_03.Class;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.Title = "Ejercicio I03 - El ejemplo universal";

        Estudiante e1 = new Estudiante("Juan", "Sueldo", "111");
        e1.SetNotaPrimerParcial(5);
        e1.SetNotaSgundoParcial(10);
        Console.WriteLine($"{e1.Mostrar()}");

        Estudiante e2 = new Estudiante("Alan", "Ortiz", "222");
        e2.SetNotaPrimerParcial(2);
        e2.SetNotaSgundoParcial(4);
        Console.WriteLine($"{e2.Mostrar()}");

        Estudiante e3 = new Estudiante("Natalia", "Fernandez", "333");
        e3.SetNotaPrimerParcial(9);
        e3.SetNotaSgundoParcial(10);
        Console.WriteLine($"{e3.Mostrar()}");
    }
}