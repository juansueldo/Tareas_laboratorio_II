using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_01.Class
{
    public class Sumador
    {
        #region ATRIBUTOS
        private int cantidadSumas;
        #endregion

        #region CONSTRUCTORES
        public Sumador(int cantidadSumas)
        {
            this.cantidadSumas = cantidadSumas;
        }
        public Sumador() :this(0)
        {

        }
        #endregion

        #region SOBRECARGAS
        public long Sumar(long a, long b)
        {
            this.cantidadSumas += 1;
            return a + b;
        }    
        public string Sumar(string a, string b)
        {
            this.cantidadSumas += 1;
            return a + b;
        }
        public static explicit operator int(Sumador s)
        {
            return s.cantidadSumas;
        }
        public static bool operator |(Sumador s1, Sumador s2)
        {
            bool retorno = false;
            if(s1.cantidadSumas == s2.cantidadSumas)
            {
                retorno = true;
            }
            return retorno;
        }
        public static long operator +(Sumador s1, Sumador s2)
        {
            long retorno = 0;
            if(s1 != null & s2 != null)
            {
                retorno = s1.cantidadSumas + s2.cantidadSumas;
            }
            return retorno;
        }
        #endregion

    }
}
