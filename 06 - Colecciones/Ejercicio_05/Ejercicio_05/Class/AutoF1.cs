using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_05.Class
{
    internal class AutoF1
    {
        #region ATRIBUTOS
        private short _cantidadCombustible;
        private bool _enCompetencia;
        private string _escuderia;
        private short _numero;
        private short _vueltasRestantes;
        #endregion

        #region CONSTRUCTOR
        public AutoF1(short numero, string escuderia)
        {
            this._numero = numero;
            this._escuderia = escuderia;
            this._enCompetencia = false;
            this._cantidadCombustible = 0;
            this._vueltasRestantes = 0;
        }
        #endregion

        #region PROPIEDADES
        public short Combustible
        { 
            get { return _cantidadCombustible; }
            set { _cantidadCombustible = value; } 
        }
        public short Vueltas
        {
            get { return _vueltasRestantes; }
            set { _vueltasRestantes = value; }
        }
        public bool Competencia
        {
            get { return _enCompetencia; }
            set { _enCompetencia = value; }
        }
        #endregion

        #region METODOS
        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"ESCUDERIA: {_escuderia}");
            sb.AppendLine($"NUMERO: {_numero}");
            sb.AppendLine($"COMBUSTIBLE: {_cantidadCombustible}");
            sb.AppendLine($"VUELTAS RESTANTES: {_vueltasRestantes}");
            sb.AppendLine($"EN COMPETENCIA? {_enCompetencia.ToString()}");

            return sb.ToString();
        }
        #endregion

        #region SOBRECARGAS
        public static bool operator ==(AutoF1 a1, AutoF1 a2)
        {
            bool retorno = false;
            if(a1._numero == a2._numero && a1._escuderia == a2._escuderia)
            {
                retorno = true;
            }
            return retorno;
        }
        public static bool operator !=(AutoF1 a1, AutoF1 a2)
        {
            return !(a1 == a2);
        }
        #endregion

    }
}
