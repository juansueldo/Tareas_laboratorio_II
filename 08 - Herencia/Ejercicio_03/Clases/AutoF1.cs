using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class AutoF1 : VehiculoDeCarrera
    {
        private short caballosDeFuerza;

        public short CaballosDeFuerza { get => caballosDeFuerza; set => caballosDeFuerza = value; }

        public AutoF1(short numero, string escuderia)
            : base(numero, escuderia)
        {

        }
        public AutoF1(short numero, string escuderia, short caballosDeFuerza)
            : this(numero, escuderia) 
        {
            this.CaballosDeFuerza = caballosDeFuerza;
        }
        public static bool operator ==(AutoF1 a1, AutoF1 a2)
        {
            bool retorno = false;
            if (a1.Numero == a2.Numero && a1.Escuderia == a2.Escuderia && a1.caballosDeFuerza == a2.caballosDeFuerza)
            {
                retorno = true;
            }
            return retorno;
        }
        public static bool operator !=(AutoF1 a1, AutoF1 a2)
        {
            return !(a1 == a2);
        }
        public override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"{base.MostrarDatos()}");
            sb.AppendLine($"CABALLOS DE FUERZA: {this.CaballosDeFuerza}");

            return sb.ToString();

        }
    }
}
