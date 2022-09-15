using Ejercicio_01.Class;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.Title = "Ejercicio I01 - Creo que necesito un préstamo";

        Cuenta cuenta = new Cuenta("Juan", 35);
        Console.WriteLine($"Cuenta creada:\n{cuenta.Mostrar()}");
        cuenta.Retirar(5);
        Console.WriteLine($"Movimiento:\n{cuenta.Mostrar()}");
        cuenta.Ingresar(20);
        Console.WriteLine($"Movimiento:\n{cuenta.Mostrar()}");
    }
}