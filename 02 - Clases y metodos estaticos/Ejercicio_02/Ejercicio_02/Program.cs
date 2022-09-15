using Ejercicio_02;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Title = "Ejercicio I02 - ¿Desea continuar?";
        int numero;
        int acum = 0;
        string respuesta = "";
        do
        {
            Console.WriteLine("Ingrese un numero: ");
            numero = Validador.ValidarNumero();
            acum += numero;
            Console.WriteLine("¿Desea continuar? (S/N)");
            respuesta = Console.ReadLine();
        } while (Validador.ValidarRespuesta(respuesta));

        Console.WriteLine($"El total ingresador fue: {acum}");
    }
}