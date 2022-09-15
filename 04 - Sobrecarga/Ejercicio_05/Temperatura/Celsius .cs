using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperatura
{
    public class Celsius
    {
        #region ATRIBUTOS
        private double celsius;
        #endregion

        #region CONSTRUCTORES
        public Celsius(double celsius)
        {
            this.celsius = celsius;
        }
        #endregion

        #region PROPIEDADES
        public double GetCelsius
        {
            get { return this.celsius; }
        }
        #endregion

        #region CONVERSIONES

        public static implicit operator Celsius(double numero)
        {
            return new Celsius(numero);
        }
        public static explicit operator Fahrenheit(Celsius c)
        {
            return new Fahrenheit(c.GetCelsius * 9 / 5 + 32);
        }
        public static explicit operator Kelvin(Celsius c)
        {
            return (Kelvin)((Fahrenheit)c);
        }
        #endregion

        #region OPERACIONES
        public static Celsius operator +(Celsius c, Fahrenheit f)
        {
            return new Celsius(c.GetCelsius + ((Celsius)f).GetCelsius);
        }
        public static Celsius operator -(Celsius c, Fahrenheit f)
        {
            return new Celsius(c.GetCelsius - ((Celsius)f).GetCelsius);
        }
        public static Celsius operator +(Celsius c, Kelvin k)
        {
            return new Celsius(c.GetCelsius + ((Celsius)k).GetCelsius);
        }
        public static Celsius operator -(Celsius c, Kelvin k)
        {
            return new Celsius(c.GetCelsius - ((Celsius)k).GetCelsius);
        }
        #endregion

        #region COMPRARACIONES
        public static bool operator ==(Celsius c, Fahrenheit f)
        {
            bool retorno = false;
            if (c.GetCelsius  == ((Celsius)f).GetCelsius)
            {
                retorno = true;
            }
            return retorno;
        }
        public static bool operator !=(Celsius c, Fahrenheit f)
        {
            return !(c == f);
        }
        public static bool operator ==(Celsius c, Kelvin k)
        {
            bool retorno = false;
            if (c.GetCelsius == ((Celsius)k).GetCelsius)
            {
                retorno = true;
            }
            return retorno;
        }
        public static bool operator !=(Celsius c, Kelvin k)
        {
            return !(c == k);
        }
        #endregion
    }
}
