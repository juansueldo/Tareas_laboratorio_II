using System.Text.RegularExpressions;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Title = "Ejercicio I07 - Recibo de sueldo";
        /*valor hora, el nombre, la antigüedad (en años) y la cantidad de hora*/

        float valorHora;
        string nombre = "";
        int antiguedad;
        float cantHoras;

        Console.WriteLine("Ingrese el valor por hora: ");
        valorHora = Program.ValidarNumeroFlotante("ERROR! Reingrese el valor por hora (o escriba ´salir´)");
        Console.WriteLine("Ingrese el nombre: ");
        nombre = Console.ReadLine();//Program.ValidarNombre("ERROR! Reingrese el nombre (o escriba ´salir´)");
        Console.WriteLine("Ingrese la antiguedad: ");
        antiguedad = Program.ValidarNumero("ERROR! Reingrese la antiguedad (o escriba ´salir´)");
        Console.WriteLine("Ingrese la cantidad de horas: ");
        cantHoras = Program.ValidarNumeroFlotante("ERROR! Reingrese las horas trabajadas (o escriba ´salir´)");


        Console.WriteLine($"RECIBO DE SUELDO \n" +
            $"Nombre: {nombre}\n" +
            $"Antiguedad {antiguedad}\n" +
            $"Valor por hora: {valorHora}\n" +
            $"Sueldo bruto {Program.SueldoBruto(cantHoras, valorHora, antiguedad)}\n" +
            $"Sueldo neto {Program.SueldoNeto(cantHoras, valorHora, antiguedad)}"
            );
    }
    private static int ValidarNumero(string texto)
    {
        int retorno = 0;
        int numero;
        while (!(int.TryParse(Console.ReadLine(), out numero)) || numero <= 0)
        {
            Console.WriteLine($"{texto}");
            if (Console.ReadLine() == "salir")
            {
                break;
            }
        }
        retorno = numero;
        return retorno;
    }
    private static float ValidarNumeroFlotante(string texto)
    {
        float retorno = 0;
        float numero;
        while (!(float.TryParse(Console.ReadLine(), out numero)) || numero <= 0)
        {
            Console.WriteLine($"{texto}");
            if (Console.ReadLine() == "salir")
            {
                break;
            }
        }
        retorno = numero;
        return retorno;
    }
    /*private static string ValidarNombre(string texto)
    {
        string aux = Console.ReadLine();
        Regex regex = new Regex(@"/^[a-zA-Z]+$/");
        string retorno = " ";
        while ((regex.IsMatch(aux)))
        {
            Console.WriteLine($"{texto}");
            if (Console.ReadLine() == "salir")
            {
                break;
            }
        }
        retorno = aux;
        return retorno;
    }*/
    private static float SueldoBruto(float cantidadHoras, float valorHora, int antiguedad)
    {
        return ((cantidadHoras * valorHora) + Program.Antiguedad(antiguedad));
    }
    private static float SueldoNeto(float cantidadHoras, float valorHora, int antiguedad)
    {
        float bruto = Program.SueldoBruto(cantidadHoras,valorHora,antiguedad);
        return Program.Descuentos(bruto);
    }
    private static float Antiguedad(int antiguedad)
    {
        return antiguedad * 150;
    }
    private static float Descuentos(float importe)
    {
        float descuento = (float)(importe * 0.13);

        return importe - descuento;
    }
    
}