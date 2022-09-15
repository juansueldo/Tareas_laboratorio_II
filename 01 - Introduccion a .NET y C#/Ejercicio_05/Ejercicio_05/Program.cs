internal class Program
{
    private static void Main(string[] args)
    {
        Console.Title = "Ejercicio I05 - Tirame un centro";

        int numero;

        Console.WriteLine("Ingrese un numero: ");
        numero = Program.ValidarNumero();
        Program.CetroNumerico(numero);
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
    public static void CetroNumerico(int numero)
    {
        int aumento = 1, sumaAtras, sumaAdelante, i,j;
        while (aumento < numero)
        {

            aumento++;
            sumaAtras = 0;
            sumaAdelante = 0;
            for (i = 1; i < aumento; i++)
            {
                sumaAtras = sumaAtras + i;
            }
            for (j = aumento + 1; j <= sumaAtras; j++)
            {
                if ((sumaAdelante == sumaAtras) || (sumaAdelante > sumaAtras))
                    break;
                sumaAdelante = sumaAdelante + j;
            }
            if (sumaAtras == sumaAdelante)
                Console.WriteLine("Es centro numerico: {0}", aumento);
        }
    }
}