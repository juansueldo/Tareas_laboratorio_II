using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Competencia
    {
        #region ATRIBUTOS
        private short _cantidadCompetidores;
        private short _cantidadVueltas;
        private List<AutoF1> _competidores;
        private TipoCompetencia tipo;
        #endregion

        #region CONSTRUCTORES
        private Competencia()
        {
            _competidores = new List<AutoF1>();
        }
        public Competencia(short cantidadVueltas, short cantidadCompetidores, TipoCompetencia tipo) : this()
        {
            _cantidadCompetidores = cantidadCompetidores;
            _cantidadVueltas = cantidadVueltas;
            this.tipo = tipo;
        }

        #endregion

        #region METODOS
        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"CANTIDAD COMPETIDORES: {_cantidadCompetidores}");
            sb.AppendLine($"CANTIDAD VUELTAS: {_cantidadVueltas}");
            foreach (VehiculoDeCarrera item in _competidores)
            {
                if(item.GetType() == typeof(AutoF1))
                {
                    sb.AppendLine($"{(((AutoF1)item).MostrarDatos())}");

                }
                if (item.GetType() == typeof(MotoCross))
                {
                    sb.AppendLine($"{(((MotoCross)item).MostrarDatos())}");

                }
            }

            return sb.ToString();
        }
        #endregion

        #region SOBRECARGAS
        public static bool operator +(Competencia c, VehiculoDeCarrera v)
        {
            bool retorno = true;
            Random rd = new Random();
            if (c._competidores.Count < c._cantidadCompetidores && c != v)
            {

                v.EnCompetencia = true;
                v.VueltasRestantes = c._cantidadVueltas;
                v.CantidadCombustible = (short)rd.Next(15, 100);
                if(c.tipo == TipoCompetencia.F1)
                {
                    c._competidores.Add((AutoF1)v);
                    
                }
                if(c.tipo == TipoCompetencia.MotoCross)
                {
                    c._competidores.Add((MotoCross)v);
                }
            }
            else
            {
                retorno = false;
            }
            return retorno;
        }
        public static bool operator -(Competencia c, VehiculoDeCarrera v)
        {
            bool retorno = true;
            if (c == v)
            {
                c._competidores.Remove(v);
            }
            else
            {
                retorno = false;
            }
            return retorno;
        }
        public static bool operator ==(Competencia c, VehiculoDeCarrera a)
        {
            bool retorno = false;
            if((c.tipo == TipoCompetencia.F1 && a.GetType() == typeof(AutoF1)) 
                || (c.tipo == TipoCompetencia.MotoCross && a.GetType() == typeof(MotoCross)))
            {
                if(c._competidores.Count > 0)
                {
                    foreach(VehiculoDeCarrera item in c._competidores)
                    {
                        if(item == a)
                        {
                            retorno = true;
                            break;
                        }
                    }
                }
            }
            else
            {
                retorno = true;
            }
            return retorno;
        }
        public static bool operator !=(Competencia c, VehiculoDeCarrera a)
        {
            return !(c == a);
        }
        #endregion
    }
}
