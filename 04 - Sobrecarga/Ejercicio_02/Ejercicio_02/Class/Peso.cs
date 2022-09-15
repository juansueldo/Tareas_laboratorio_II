using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    public class Peso
    {
        #region ATRIBUTOS
        private double _cantidad;
        private static double _cotzRespectoDolar;
        #endregion

        #region CONSTRUCTORES
        static Peso()
        {
            _cotzRespectoDolar = 1 / 102.65;
        }
        public Peso(double cantidad)
        {
            this._cantidad = cantidad;
        }
        public Peso(double cantidad, double cotizacion) : this(cantidad)
        {
            _cotzRespectoDolar = cotizacion;
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
        public static explicit operator Euro(Peso p)
        {
            return (Euro)((Dolar)p);
        }
        public static explicit operator Dolar(Peso p)
        {
            return new Dolar(p._cantidad / Peso.GetCotizacion());
        }
        public static implicit operator Peso(double p)
        {
            return new Peso(p);
        }
        #endregion

        #region SOBRECARGAS_OPERADORES

        #region COMPARACION
        public static bool operator !=(Peso p, Euro e)
        {
            return !(p == e);
        }
        public static bool operator ==(Peso p, Euro e)
        {
            bool retorno = false;
            if (p._cantidad == e.GetCantidad())
            {
                retorno = true;
            }
            return retorno;
        }
        public static bool operator !=(Peso p, Dolar d)
        {
            return !(p == d);
        }
        public static bool operator ==(Peso p, Dolar d)
        {
            bool retorno = false;
            if (p._cantidad == d.GetCantidad())
            {
                retorno = true;
            }
            return retorno;
        }
        public static bool operator !=(Peso p1, Peso p2)
        {
            return !(p1 == p2);
        }
        public static bool operator ==(Peso p1, Peso p2)
        {
            bool retorno = false;
            if (p1._cantidad == p2._cantidad)
            {
                retorno = true;
            }
            return retorno;
        }
        #endregion

        #region ADICION_RESTA
        public static Peso operator -(Peso p, Euro e)
        {
            return new Peso(p._cantidad - ((Peso)e)._cantidad);
        }
        public static Peso operator +(Peso p, Euro e)
        {
            return new Peso(p._cantidad + ((Peso)e)._cantidad);
        }
        public static Peso operator -(Peso p, Dolar d)
        {
            return new Peso(p._cantidad - ((Peso)d)._cantidad);
        }
        public static Peso operator +(Peso p, Dolar d)
        {
            return new Peso(p._cantidad + ((Peso)d)._cantidad);
        }
        public static Peso operator -(Peso p1, Peso p2)
        {
            return new Peso(p1._cantidad - p2._cantidad);
        }
        public static Peso operator +(Peso p1, Peso p2)
        {
            return new Peso(p1._cantidad + p2._cantidad);
        }
        #endregion

        #endregion
    }
}
