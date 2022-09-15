using Ejercicio_01;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Title = "Ejercicio I01 - Validador de rangos";

        int numero;
        int acumulador = 0;
        float promedio;
        int flag = 0;
        int min = 0;
        int max = 0;
        int cant = 3;
        for(int i = 0; i < cant; i++)
        {
            Console.WriteLine("Ingrese un numero: ");
            numero = Validador.ValidarNumero();
            if ((Validador.Validar(numero,-100,100)) == true)
            {
                acumulador += numero;
                if(flag == 0)
                {
                    min = numero;
                    max = numero;
                    flag = 1;
                }
                else
                {
                    if(numero < min)
                    {
                        min = numero;
                    }
                    if(numero > max)
                    {
                        max = numero;
                    }
                }
            }
            else
            {
                Console.WriteLine("Numero fuera del rango valido.");
                i--;
            }
        }
        promedio = (float)acumulador / cant;
        Console.WriteLine($"Promedio: {promedio}");
        Console.WriteLine($"Numero minimo: {min}");
        Console.WriteLine($"Numero maximo: {max}");
    }
}