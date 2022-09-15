internal class Program
{
    private static void Main(string[] args)
    {
        Console.Title = "Ejercicio I06 - Años bisiestos";
        int anio;
        Console.WriteLine("Ingrese el año: ");
        anio = Program.ValidarNumero();
        if (Program.AnioBisiesto(anio))
        {
            Console.WriteLine($"{anio} es bisiesto");
        }
        else
        {
            Console.WriteLine($"{anio} no es bisiesto");
        }
    }
    private static int ValidarNumero()
    {
        int retorno = 0;
        int numero;
        while (!(int.TryParse(Console.ReadLine(), out numero)) || numero <= 0)
        {
            Console.WriteLine("ERROR! Reingrese un numero válido (o escriba ´salir´): ");
            if (Console.ReadLine() == "salir")
            {
                break;
            }
        }
        retorno = numero;
        return retorno;
    }
    private static bool AnioBisiesto(int numero)
    {
        bool esBisiesto = false;
        if((numero % 4 == 0) && (numero % 100 != 0) || (numero % 400 == 0))
        {
            esBisiesto = true;
        }
        return esBisiesto;
    }
}