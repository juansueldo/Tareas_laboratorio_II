internal class Program
{
    private static void Main(string[] args)
    {
        Console.Title = "Ejercicio I08 - Dibujando un triángulo rectángulo";
        int tamanio;
        Console.WriteLine("Ingrese el tamaño de la piramide: ");
        tamanio = Program.ValidarNumero();
        Program.DibujarTriangulo(tamanio);
    }
    private static void DibujarTriangulo(int tamanio)
    {
        string piramide = "*";
        for(int i = 1; i <= tamanio; i++)
        {
            for(int j = 1; j <= i; j++)
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