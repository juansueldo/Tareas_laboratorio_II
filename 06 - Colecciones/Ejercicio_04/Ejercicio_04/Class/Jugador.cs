using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_04.Class
{
    public class Jugador
    {
        #region ATRIBUTOS
        private int _dni;
        private string _nombre;
        private int _partidosJugados;
        //private float _promedioGoles;
        private int _totalGoles;
        #endregion

        #region PROPIEDADES
        public int PartidosJugados
        {
            get{ return _partidosJugados;}
        }
        public float PromedioDeGoles
        {
            get { return (float)_totalGoles / _partidosJugados; }
        }
        public float TotalGoles
        {
            get { return _totalGoles; }
        }
        public string Nombre
        {
            set { _nombre = value; }
        }
        public int Dni
        {
            set { _dni = value; }
        }
        #endregion

        #region CONSTRUCTORES
        private Jugador()
        {
            _partidosJugados = 0;
            _totalGoles = 0;
        }
        public Jugador(int dni, string nombre) :this()
        {
            _dni = dni;
            _nombre = nombre;
        }
        public Jugador(int dni, string nombre, int partidosJugados, int totalGoles) : this(dni, nombre)
        {
            _partidosJugados = partidosJugados;
            _totalGoles = totalGoles;
        }

        #endregion

        #region METODOS
        /*public float GetPromedioGoles()
        {
            _promedioGoles = (float)_totalGoles / _partidosJugados;
            return _promedioGoles;
        }*/
        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"NOMBRE: {_nombre}");
            sb.AppendLine($"DNI: {_dni}");
            sb.AppendLine($"PARTIDOS JUGADOS: {_partidosJugados} TOTAL GOLES: {_totalGoles}");
            sb.AppendLine($"PROMEDIO GOLES {PromedioDeGoles}");

            return sb.ToString();
        }
        #endregion

        #region SOBRECARGAS
        public static bool operator ==(Jugador j1, Jugador j2)
        {
            bool retorno = false;
            if(j1._dni == j2._dni)
            {
                retorno = true;
            }
            return retorno;
        }
        public static bool operator !=(Jugador j1, Jugador j2)
        {
            return !(j1 == j2);
        }
        #endregion
    }
}
