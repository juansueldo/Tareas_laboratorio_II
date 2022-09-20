using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class MotoCross : VehiculoDeCarrera
    {
        private short cilindrada;

        public short Cilindrada { get => cilindrada; set => cilindrada = value; }

        public MotoCross(short numero, string escuderia)
           : base(numero, escuderia)
        {

        }
        public MotoCross(short numero, string escuderia, short cilindrada)
            : this(numero, escuderia)
        {
            this.cilindrada = cilindrada;
        }
        public static bool operator ==(MotoCross a1, MotoCross a2)
        {
            bool retorno = false;
            if (a1.Numero == a2.Numero && a1.Escuderia == a2.Escuderia && a1.cilindrada == a2.cilindrada)
            {
                retorno = true;
            }
            return retorno;
        }
        public static bool operator !=(MotoCross a1, MotoCross a2)
        {
            return !(a1 == a2);
        }
        public override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"{base.MostrarDatos()}");
            sb.AppendLine($"CILINDRADA: {this.cilindrada}");

            return sb.ToString();

        }
    }
}
