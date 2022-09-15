using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_03.Class
{
    public class NumeroDecimal
    {
        #region ATRIBUTOS
        private double numero;
        #endregion

        #region CONSTRUCTORES
        private NumeroDecimal(double numero)
        {
            this.numero = numero;
        }
        #endregion

        #region PROPIEDADES
        public double Numero
        {
            get { return this.numero; }
        }
        #endregion

        #region METODOS
        public string DecimalBinario(double numero)
        {
            string numBinario = string.Empty;
            int resultadoDivision = (int)numero;
            int restoDivision;

            if (resultadoDivision >= 0)
            {
                do
                {
                    restoDivision = resultadoDivision % 2;
                    resultadoDivision /= 2;
                    numBinario = restoDivision.ToString() + numBinario;
                } while (resultadoDivision > 0);
            }
            return numBinario;
        }
        #endregion

        #region SOBRECARGAS

        #region SOBRECARGAS EXPLICITAS
        public static explicit operator NumeroDecimal(double numero)
        {
            return new NumeroDecimal(numero);
        }
        public static explicit operator NumeroBinario(NumeroDecimal numero)
        {
            return (NumeroBinario)numero.DecimalBinario(numero.Numero);
        }
        #endregion

        #region SOBRECARGAS OPERADORES
        public static double operator + (NumeroDecimal n1, NumeroBinario n2)
        {
            return n1.Numero + ((NumeroDecimal)n2).Numero;
        }
        public static double operator -(NumeroDecimal n1, NumeroBinario n2) 
        {
            return n1.Numero - ((NumeroDecimal)n2).Numero;
        }
        #endregion

        #region SOBRECARGAS COMPRACION
        public static bool operator == (NumeroDecimal n1, NumeroBinario n2)
        {
            bool retorno = false;
            if(n1.Numero == ((NumeroDecimal)n2).Numero)
            {
                retorno = true;
            }
            return retorno;
        }
        public static bool operator != (NumeroDecimal n1, NumeroBinario n2)
        {
            return !(n1 == n2);
        }
        #endregion

        #endregion
    }
}
