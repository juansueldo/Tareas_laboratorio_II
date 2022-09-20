using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Moto : VehiculoTerrestre
    {
        public short cilindrada;
        public Moto(short cantidadRuedas, Colores color, short cantidadMarchas, int cantidad, short cilindrada) 
            : base(cantidadRuedas, color, cantidadMarchas)
        {
            this.cilindrada = cilindrada;
        }

    }
}
