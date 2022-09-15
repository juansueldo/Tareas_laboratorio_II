using Ejercicio_01.Class;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.Title = "Ejercicio I01 - Sumador";
        Sumador s1 = new Sumador();
        Sumador s2 = new Sumador(3);
        s1.Sumar(5, 3);
        s2.Sumar("Juan ", "Sueldo");
        if(s1 | s2)
        {
            Console.WriteLine("Son iguales");
        }
        else
        {
            Console.WriteLine("Son distintos");
        }
        long aux = s1 + s2;
        Console.WriteLine($"{aux}");
    }
}