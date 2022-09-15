using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_03.Class
{
    public class Validador
    {
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
