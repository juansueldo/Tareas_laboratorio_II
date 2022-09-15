using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_01.Class
{
    public class Cuenta
    {
        #region ATRIBUTOS

        private string _titular;
        private int _cantidad;

        #endregion

        #region CONSTRUCTOR
        public Cuenta(string titular, int cantidad)
        {
            this._titular = titular;
            this._cantidad = cantidad;
        }

        #endregion

        #region PROPIEDADES

        public string Titular
        {
            get
            {
                return this._titular;
            }
        }
        public int Cantidad
        {
            get
            {
                return this._cantidad;
            }
        }

        #endregion

        #region METODOS
        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Titular: {this.Titular}");
            sb.AppendLine($"Cantidad: {this.Cantidad}");

            return sb.ToString();
        }

        public void Ingresar(int ingreso)
        {
            this._cantidad += ingreso;
        }

        public void Retirar(int retirar)
        {
            this._cantidad -= retirar;
        }
        #endregion

    }
}
