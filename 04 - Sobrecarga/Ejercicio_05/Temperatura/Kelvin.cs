using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperatura
{
    public class Kelvin
    {
        #region ATRIBUTOS
        private double kelvin;
        #endregion

        #region CONSTRUCTORES
        public Kelvin(double kelvin)
        {
            this.kelvin = kelvin;
        }
        #endregion

        #region PROPIEDADES

        public double GetKelvin
        {
            get { return this.kelvin; }
        }

        #endregion

        #region CONVERSIONES
        public static implicit operator Kelvin(double numero)
        {
            return new Kelvin(numero);
        }
        public static explicit operator Celsius(Kelvin k)
        {
            return (Celsius)((Fahrenheit)k);
        }
        public static explicit operator Fahrenheit(Kelvin k)
        {
            return new Fahrenheit((k.GetKelvin * 9 / 5) - 459.67);
        }
        #endregion

        #region OPERACIONES
        public static Kelvin operator +(Kelvin K, Celsius c)
        {
            return new Kelvin(K.GetKelvin + ((Kelvin)c).GetKelvin);
        }
        public static Kelvin operator -(Kelvin K, Celsius c)
        {
            return new Kelvin(K.GetKelvin - ((Kelvin)c).GetKelvin);
        }
        public static Kelvin operator +(Kelvin K, Fahrenheit f)
        {
            return new Kelvin(K.GetKelvin + ((Kelvin)f).GetKelvin);
        }
        public static Kelvin operator -(Kelvin K, Fahrenheit f)
        {
            return new Kelvin(K.GetKelvin - ((Kelvin)f).GetKelvin);
        }
        #endregion

        #region COMPRARACIONES
        public static bool operator ==(Kelvin k, Celsius c)
        {
            bool retorno = false;
            if (k.GetKelvin == ((Kelvin)c).GetKelvin)
            {
                retorno = true;
            }
            return retorno;
        }
        public static bool operator !=(Kelvin k, Celsius c)
        {
            return !(k == c);
        }
        public static bool operator ==(Kelvin k,Fahrenheit f)
        {
            bool retorno = false;
            if (k.GetKelvin == ((Kelvin)f).GetKelvin)
            {
                retorno = true;
            }
            return retorno;
        }
        public static bool operator !=(Kelvin k, Fahrenheit f)
        {
            return !(k == f);
        }
        #endregion
    }
}
