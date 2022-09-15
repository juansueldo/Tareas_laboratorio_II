using System;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Title = "Ejercicio I08 - El tiempo pasa...";

        int anio, mes, fecha;
        Console.WriteLine("Ingrese la fecha: ");
        fecha = ValidarNumero();
        Console.WriteLine("Ingrese el mes: ");
        mes = ValidarNumero();
        Console.WriteLine("Ingrese el año: ");
        anio = ValidarNumero();
        
        CalcularFecha(anio, mes, fecha);
    }
    public static void CalcularFecha(int anio, int mes, int fecha)
    {
        DateTime date_2 = DateTime.Now;
        DateTime date_1 = new DateTime(anio, mes, fecha);

        TimeSpan Diff_dates = date_2.Subtract(date_1);
        Console.Write($"Dias transcurridos: {Diff_dates.Days}");
    }
    public static int ValidarNumero()
    {
        int retorno = 0;
        int numero;
        while (!(int.TryParse(Console.ReadLine(), out numero)))
        {
            Console.WriteLine("ERROR! Reingrese un numero válido: ");
        }
        retorno = numero;
        return retorno;
    }
}