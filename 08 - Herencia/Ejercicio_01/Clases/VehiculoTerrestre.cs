using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class VehiculoTerrestre
    {
        protected short cantidadRuedas;
        protected Colores color;
        protected short cantidadPuertas;

        public VehiculoTerrestre(short cantidadRuedas, Colores color, short cantidadPuertas)
        {
            this.cantidadRuedas = cantidadRuedas;
            this.color = color;
            this.cantidadPuertas = cantidadPuertas;
        }
        
    }
}
