using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    public class Dolar
    {
        #region ATRIBUTOS
        private double _cantidad;
        private static double _cotzRespectoDolar;
        #endregion

        #region CONSTRUCTORES
        static Dolar()
        {
            _cotzRespectoDolar = 1;
        }
        public Dolar (double cantidad)
        {
            this._cantidad = cantidad;
        }
        #endregion

        #region PROPIEDADES
        public double GetCantidad()
        {
            return this._cantidad;
        }
        public static double GetCotizacion()
        {
            return _cotzRespectoDolar;
        }
        #endregion

        #region SOBRECARGAS_CONVERSIONES
        public static explicit operator Euro(Dolar d)
        {
            return new Euro(Dolar.GetCotizacion() * d._cantidad);
        }
        public static explicit operator Peso(Dolar d)
        {
            return new Peso(Dolar.GetCotizacion() * d._cantidad);
        }
        public static implicit operator Dolar(double d)
        {
            return new Dolar(d);
        }
        #endregion

        #region SOBRECARGAS_OPERADORES

        #region COMPARACION
        public static bool operator !=(Dolar d, Euro e)
        {
            return !(d == e);
        }
        public static bool operator ==(Dolar d, Euro e)
        {
            bool retorno = false;
            if(d._cantidad == e.GetCantidad())
            {
                retorno = true;
            }
            return retorno;
        }
        public static bool operator !=(Dolar d, Peso p)
        {
            return !(d == p);
        }
        public static bool operator ==(Dolar d, Peso p)
        {
            bool retorno = false;
            if (d._cantidad == p.GetCantidad())
            {
                retorno = true;
            }
            return retorno;
        }
        public static bool operator !=(Dolar d1, Dolar d2)
        {
            return !(d1 == d2);
        }
        public static bool operator ==(Dolar d1, Dolar d2)
        {
            bool retorno = false;
            if (d1._cantidad == d2._cantidad)
            {
                retorno = true;
            }
            return retorno;
        }
        #endregion

        #region ADICION_RESTA
        public static Dolar operator -(Dolar d, Euro e)
        {
            return new Dolar(d._cantidad - ((Dolar)e)._cantidad);
        }
        public static Dolar operator +(Dolar d, Euro e)
        {
            return new Dolar(d._cantidad + ((Dolar)e)._cantidad);
        }
        public static Dolar operator -(Dolar d, Peso p)
        {
            return new Dolar(d._cantidad - ((Dolar)p)._cantidad);
        }
        public static Dolar operator +(Dolar d, Peso p)
        {
            return new Dolar(d._cantidad + ((Dolar)p)._cantidad);
        }
        public static Dolar operator -(Dolar d1, Dolar d2)
        {
            return new Dolar(d1._cantidad - d2._cantidad);
        }
        public static Dolar operator +(Dolar d1, Dolar d2)
        {
            return new Dolar(d1._cantidad + d2._cantidad);
        }
        #endregion

        #endregion

    }
}
