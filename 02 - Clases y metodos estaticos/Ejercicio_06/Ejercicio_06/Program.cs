using Ejercicio_06.Class;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.Title = "Ejercicio I06 - Calculadora de áreas";

        /* Cuadrado */

        double numero;
        Console.WriteLine("Ingrese el lado para calular el area del cuadrado: ");
        numero = CalculadoraDeArea.ValidarNumero();
        Console.WriteLine($"El area del cuadrado es: {CalculadoraDeArea.CalcularAreaCuadrado(numero)}");

        /*Triangulo*/

        double bases, altura;
        Console.WriteLine("Ingrese la base para calular el area del triangulo: ");
        bases = CalculadoraDeArea.ValidarNumero();
        Console.WriteLine("Ingrese la altura para calular el area del triangulo: ");
        altura = CalculadoraDeArea.ValidarNumero();
        Console.WriteLine($"El area del triangulo es: {CalculadoraDeArea.CalcularAreaTriangulo(bases, altura)}");

        /*Circulo*/

        double radio;
        Console.WriteLine("Ingrese el radio para calular el area del circulo: ");
        radio = CalculadoraDeArea.ValidarNumero();
        Console.WriteLine($"El area del circulo es: {CalculadoraDeArea.CalcularAreaCirculo(radio)}");
    }
}