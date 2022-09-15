using Ejercicio_04.Class;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.Title = "Ejercicio I04 - La calculadora";

        int x;
        int y;
        string operacion;
        Console.WriteLine("Ingrese el primer operando: ");
        x = Calculadora.ValidarNumero();
        Console.WriteLine("Ingrese el segundo operando: ");
        y = Calculadora.ValidarNumero();
        Console.WriteLine("Ingrese la operacion a realizar: ");
        operacion = Console.ReadLine();
        Console.WriteLine($"El resultado de la {operacion} es {Calculadora.Calcular(x,y,operacion)}");
    }
}