internal class Program
{
    private static void Main(string[] args)
    {
        Console.Title = "Ejercicio I09 - Dibujando un triángulo equilátero";
        int tamanio;
        Console.WriteLine("Ingrese el tamaño de la piramide: ");
        tamanio = Program.ValidarNumero();
        Program.TrianguloEquilatero(tamanio);
    }
    private static void TrianguloEquilatero(int tamanio)
    {
        string piramide = "*";
        for (int i = 1; i <= tamanio; i++)
        {
            for (int j = 1; j <= tamanio - i; j++)
            {
                Console.Write(" ");
            }

            for (int k = 1; k <= i; k++)
            {
                Console.Write(piramide);
            }

            for (int l = 1; l <= i - 1; l++)
            {
                Console.Write(piramide);
            }
            Console.WriteLine();
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
}