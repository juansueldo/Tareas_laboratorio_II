using Ejercicio_02.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.Title = "Ejercicio I02 - ¿Consultaste el índice?";

        Libro libro = new Libro();

        libro[0] = "Juego de Tronos";
        libro[1] = "Fuego y Sangre";
        libro[2] = "Tormenta de Espadas";
        
        for(int i = 0; i <= 2; i++)
        {
            Console.WriteLine(libro[i]);
        }
    }
}