using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_03.Class
{
    public class NumeroBinario
    {
        #region ATRIBUTOS
        private string numero;
        #endregion

        #region CONSTRUCTORES
        private NumeroBinario(string numero)
        {
            this.numero = numero;
        }
        #endregion

        #region PROPIEDADES
        public string Numero
        {
            get { return this.numero; }
        }
        #endregion

        #region METODOS
        public double BinarioDecimal(string numero)
        {
            double resultado = 0;
            int cantidadCaracteres = numero.Length;
            foreach(char caracter in numero)
            {
                cantidadCaracteres--;
                if(caracter == '1')
                {
                    resultado += (int)Math.Pow(2, cantidadCaracteres);
                }
            }
            return resultado;
        }
        #endregion

        #region SOBRECARGAS

        #region SOBRECARGAS EXPLICITAS
        public static explicit operator NumeroBinario(string numero)
        {
            return new NumeroBinario(numero);
        }
        public static explicit operator NumeroDecimal(NumeroBinario numero)
        {
            return (NumeroDecimal)numero.BinarioDecimal(numero.Numero);
        }
        #endregion

        #region SOBRECARGAS OPERADORES
        public static string operator + (NumeroBinario n1, NumeroDecimal n2)
        {
            return n2.DecimalBinario(((NumeroDecimal)n1).Numero + n2.Numero);
        }
        public static string operator - (NumeroBinario n1, NumeroDecimal n2)
        {
            return n2.DecimalBinario(((NumeroDecimal)n1).Numero - n2.Numero);
        }
        #endregion

        #region SOBRECARGAS COMPARACION
        public static bool operator == (NumeroBinario n1, NumeroDecimal n2)
        {
            bool retorno = false;
            if(n1.numero == ((NumeroBinario)n2).numero)
            {
                retorno = true;
            }
            return retorno;
        }
        public static bool operator != (NumeroBinario n1, NumeroDecimal n2)
        {
            return !(n1 == n2);
        }
        #endregion

        #endregion
    }
}
