internal class Program
{
    private static void Main(string[] args)
    {
        Console.Title = "Ejercicio I01 - Máximo, mínimo y promedio";

        int numero;
        int acumulador = 0;
        int cantidad = 5;
        int min = 0;
        int max = 0;
        int flag = 0;
        float promedio;

        for(int i = 0; i < cantidad; i++)
        {
            Console.WriteLine("Ingrese un numero: ");
            numero = Program.ValidarNumero();
            acumulador = numero;

            if (flag == 0)
            {
                min = numero;
                max = numero;
                flag = 1;
            }
            else
            {
                if (numero < min)
                {
                    min = numero;
                }
                if (numero > max)
                {
                    max = numero;
                }
            }
        }
        promedio = (float)acumulador / cantidad;

        Console.WriteLine($"El promedio de los numeros ingresados es {promedio}");
        Console.WriteLine($"El valor maximo ingresado es {max}");
        Console.WriteLine($"El valor minimo ingresado es {min}");
    }
    private static int ValidarNumero()
    {
        int retorno = 0;
        int numero;
        while(!(int.TryParse(Console.ReadLine(), out numero)))
        {
            Console.WriteLine("ERROR! Reingrese un numero válido: ");
        }
        retorno = numero;
        return retorno;
    }
}