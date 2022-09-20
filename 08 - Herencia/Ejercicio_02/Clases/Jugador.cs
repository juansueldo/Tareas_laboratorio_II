using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Jugador : Persona
    {
        private int partidosJugados;
        private int totalGoles;
        public Jugador(int dni,string nombre) : base(dni,nombre)
        {
        }
        public Jugador(int dni, string nombre, int totalGoles, int totalPartidos)
            : this(dni, nombre)
        {
            this.totalGoles = totalGoles;
            this.partidosJugados = totalPartidos;
        }
        public override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{base.MostrarDatos()}");
            sb.AppendLine($"TOTAL GOLES: {this.totalGoles}");
            sb.AppendLine($"TOTAL PARTIDOS: {this.partidosJugados}");

            return sb.ToString();
        }
        public static bool operator ==(Jugador jugador1, Jugador jugador2)
        {
            return (jugador1.Dni == jugador2.Dni && jugador1.Nombre == jugador2.Nombre);
        }
        public static bool operator !=(Jugador jugador1, Jugador jugador2)
        {
            return !(jugador1 == jugador2);
        }
    }
}
