using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_04.Class
{
    public class Calculadora
    {
        public static float Calcular(int x, int y, string operacion)
        {
            float retorno = 0;
            switch (operacion)
            {
                case "+":
                    retorno = Suma(x, y);
                    break;
                case "-":
                    retorno = Resta(x, y);
                    break;
                case "/":
                    retorno = Division(x, y);
                    break;
                case "*":
                    retorno = Multiplicacion(x, y);
                    break;
                default:
                    Console.WriteLine("No se ingreso una operacion valida");
                    break;
            }
            return retorno;
        }
        private static int Suma(int x, int y)
        {
            return x + y;
        }
        private static int Resta(int x, int y)
        {
            return x - y;
        }
        private static int Multiplicacion(int x, int y)
        {
            return x * y;
        }
        private static float Division(int x, int y)
        {
            float retorno = 0;
            if (Validar(y))
            {
                retorno = (float)x / y;

            }
            return retorno;
        }
        public static bool Validar(int x)
        {
            bool retorno = false;
            if(x != 0)
            {
                retorno = true;
            }
            return retorno;
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
