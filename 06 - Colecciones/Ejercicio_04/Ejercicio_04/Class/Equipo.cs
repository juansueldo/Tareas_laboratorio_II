using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_04.Class
{
    public class Equipo
    {
        #region ATRIBUTOS
        private short _cantidadDeJugadores;
        private List<Jugador> _jugadores;
        private string _nombre;
        #endregion

        #region CONSTRUCTORES
        private Equipo()
        {
            _jugadores = new List<Jugador>();
        }
        public Equipo(short cantidad, string nombre) :this()
        {
            _cantidadDeJugadores = cantidad;
            _nombre = nombre;
        }
        #endregion

        #region SOBRECARGAS
        public static bool operator +(Equipo e, Jugador j)
        {
            bool retorno = true;
            if(e._jugadores.Count < e._cantidadDeJugadores)
            {
                foreach (Jugador item in e._jugadores)
                {
                    if (item == j)
                    {
                        retorno = false;
                    }
                }
                e._jugadores.Add(j);
            }
            else
            {
                retorno = false;
            }
            
            return retorno;
        }
        #endregion
    }
}
