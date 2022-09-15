using Billetes;
internal class Program
{
    private static void Main(string[] args)
    {
        Euro e = new Euro(1, 1.17);
        Dolar d = new Dolar(1);
        Peso p = new Peso(1, 102.67f);

        Console.WriteLine(((Euro)d).GetCantidad());
        

        Console.ReadKey();
    }
}