using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_01.Class
{
    public class Cliente
    {
        #region ATRIBUTOS
        private string _nombre;
        private int _numero;
        #endregion

        #region PROPIEDADES
        public string Nombre 
        {
            get { return _nombre; }
            set { _nombre = value; } 
        }
        public int Numero
        {
            get { return _numero; }
        }
        #endregion

        #region CONSTRUCTOR
        public Cliente(int numero)
        {
            _numero = numero;
        }
        public Cliente(int numero, string nombre) : this(numero)
        {
            _nombre = nombre;
        }
        #endregion

        #region SOBRECARGAS
        public static bool operator ==(Cliente c1, Cliente c2)
        {
            bool retono = false;
            if(c1._numero == c2._numero)
            {
                retono = true;
            }
            return retono;
        }
        public static bool operator !=(Cliente c1, Cliente c2)
        {
            return !(c1 == c2);
        }
        #endregion
    }
}
