using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    public class Euro
    {
        #region ATRIBUTOS
        private double _cantidad;
        private static double _cotzRespectoDolar;
        #endregion

        #region CONSTRUCTORES
        static Euro()
        {
            _cotzRespectoDolar = 1 / 1.17;
        }
        public Euro(double cantidad)
        {
            this._cantidad = cantidad;
        }
        public Euro(double cantidad, double cotizacion) :this(cantidad)
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
        public static explicit operator Dolar(Euro e)
        {
            return new Dolar(e._cantidad / _cotzRespectoDolar);
        }
        public static explicit operator Peso(Euro e)
        {
            return (Peso)((Dolar)e);
        }
        public static implicit operator Euro(double e)
        {
            return new Euro(e);
        }
        #endregion

        #region SOBRECARGAS_OPERADORES

        #region COMPARACION
        public static bool operator !=(Euro e, Dolar d)
        {
            return !(e == d);
        }
        public static bool operator ==(Euro e, Dolar d)
        {
            bool retorno = false;
            if (e._cantidad == d.GetCantidad())
            {
                retorno = true;
            }
            return retorno;
        }
        public static bool operator !=(Euro e, Peso p)
        {
            return !(e == p);
        }
        public static bool operator ==(Euro e, Peso p)
        {
            bool retorno = false;
            if (e._cantidad == p.GetCantidad())
            {
                retorno = true;
            }
            return retorno;
        }
        public static bool operator !=(Euro e1, Euro e2)
        {
            return !(e1 == e2);
        }
        public static bool operator ==(Euro e1, Euro e2)
        {
            bool retorno = false;
            if (e1._cantidad == e2._cantidad)
            {
                retorno = true;
            }
            return retorno;
        }
        #endregion

        #region ADICION_RESTA
        public static Euro operator -(Euro e, Dolar d)
        {
            return new Euro(e._cantidad - ((Euro)d)._cantidad);
        }
        public static Euro operator +(Euro e, Dolar d)
        {
            return new Euro(e._cantidad + ((Euro)d)._cantidad);
        }
        public static Euro operator -(Euro e, Peso p)
        {
            return new Euro(e._cantidad - ((Euro)p)._cantidad);
        }
        public static Euro operator +(Euro e, Peso p)
        {
            return new Euro(e._cantidad + ((Euro)p)._cantidad);
        }
        public static Euro operator -(Euro e1, Euro e2)
        {
            return new Euro(e1._cantidad - e2._cantidad);
        }
        public static Euro operator +(Euro e1, Euro e2)
        {
            return new Euro(e1._cantidad + e2._cantidad);
        }
        #endregion

        #endregion

    }
}
