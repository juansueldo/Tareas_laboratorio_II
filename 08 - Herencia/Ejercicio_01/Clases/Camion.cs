using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Camion : VehiculoTerrestre
    {
        public short cantidadMarchas;
        public int pesoCarga;
        public Camion(short cantidadRuedas, Colores color, short cantidadPuertas, short cantidadMarchas, int pesoCarga) 
            : base(cantidadRuedas, color, cantidadPuertas)
        {
            this.cantidadMarchas = cantidadMarchas;
            this.pesoCarga = pesoCarga;
        }

    }
}
