using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_05.Class
{
    public class Tablas
    {
        private static int RealizarTablas(int numero, int i)
        {
            return numero * i;
        }
        public static string MostrarTablas(int numero)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Tabla de multiplicar del número {numero}: ");
            for(int i = 1; i < 10; i++)
            {
                sb.AppendLine($"{numero} x {i} = {RealizarTablas(numero,i)}");
            }
            return sb.ToString();
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
}
