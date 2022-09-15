using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_06.Class
{
    public class CalculadoraDeArea
    {
        public static double CalcularAreaCuadrado(double longitudLado) 
        {
            return longitudLado * 4;
        }
        public static double CalcularAreaTriangulo(double bases, double altura) 
        {
            return bases * altura / 2;
        }
        public static double CalcularAreaCirculo(double radio)
        {
            return 3.14 * (Math.Pow(radio, 2));
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
