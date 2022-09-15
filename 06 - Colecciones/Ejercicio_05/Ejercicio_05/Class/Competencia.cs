using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_05.Class
{
    internal class Competencia
    {
        #region ATRIBUTOS
        private short _cantidadCompetidores;
        private short _cantidadVueltas;
        private List<AutoF1> _competidores;
        #endregion

        #region CONSTRUCTORES
        private Competencia()
        {
            _competidores = new List<AutoF1>();
        }
        public Competencia(short cantidadCompetidores, short cantidadVueltas) :this()
        {
            _cantidadCompetidores = cantidadCompetidores;
            _cantidadVueltas = cantidadVueltas;
        }

        #endregion

        #region METODOS
        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"CANTIDAD COMPETIDORES: {_cantidadCompetidores}");
            sb.AppendLine($"CANTIDAD VUELTAS: {_cantidadVueltas}");
            foreach(AutoF1 item in _competidores)
            {
                sb.AppendLine($"{item.MostrarDatos()}");
            }

            return sb.ToString();
        }
        #endregion

        #region SOBRECARGAS
        public static bool operator +(Competencia c, AutoF1 a)
        {
            bool retorno = true;
            Random rd = new Random();
            if(c._competidores.Count < c._cantidadCompetidores && c != a)
            {
                c._competidores.Add(a);
                a.Competencia = true;
                a.Vueltas = c._cantidadVueltas;
                a.Combustible = (short)rd.Next(15, 100);
            }
            else
            {
                retorno = false;
            }
            return retorno;
        }
        public static bool operator -(Competencia c, AutoF1 a)
        {
            bool retorno = true;
            if (c == a)
            {
               c._competidores.Remove(a);
            }
            else
            {
               retorno = false;
            }
            return retorno;
        }
        public static bool operator ==(Competencia c, AutoF1 a)
        {
            bool retorno = false;
            foreach(AutoF1 item in c._competidores)
            {
                if(item == a)
                {
                    retorno = true;
                }
            }
            return retorno;
        }
        public static bool operator !=(Competencia c, AutoF1 a)
        {
            return !(c == a);
        }
        #endregion
    }
}
