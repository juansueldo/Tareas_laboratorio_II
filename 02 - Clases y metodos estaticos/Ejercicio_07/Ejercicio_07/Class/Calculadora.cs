using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_07.Class
{
    public class Calculadora
    {
        public static double CalcularHipotenusa(double bases, double altura)
        {
            double retorno = Math.Sqrt(Math.Pow(bases, 2) + Math.Pow(altura, 2));
            return retorno;
        }
        public static double ValidarNumero()
        {
            double retorno = 0;
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
