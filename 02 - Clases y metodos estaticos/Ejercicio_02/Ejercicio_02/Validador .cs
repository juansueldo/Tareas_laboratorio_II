using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_02
{
    public class Validador
    {
        public static bool ValidarRespuesta(string respuesta)
        {
            bool retorno = false;
            if(respuesta == "S" || respuesta == "s")
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
