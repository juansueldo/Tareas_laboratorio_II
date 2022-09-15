using Ejercicio_07.Class;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.Title = "Ejercicio I07 - Pitágoras estaría orgulloso";
        double bases;
        double altura;
        Console.WriteLine("Ingrese la base del triangulo: ");
        bases = Calculadora.ValidarNumero();
        Console.WriteLine("Ingrese la altura  del triangulo: ");
        altura = Calculadora.ValidarNumero();
        Console.WriteLine($"{Calculadora.CalcularHipotenusa(bases, altura)}");
    }
}