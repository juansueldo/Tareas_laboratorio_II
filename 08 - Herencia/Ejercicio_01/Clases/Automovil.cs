using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public abstract class Automovil : VehiculoTerrestre
    {
        public short cantidadMarchas;
        public int cantidadPasajeros;

        protected Automovil(short cantidadRuedas, Colores color, short cantidadPuertas,short cantidadMarchas, int cantidadPasajeros) 
            : base(cantidadRuedas, color, cantidadPuertas)
        {
            this.cantidadMarchas = cantidadMarchas;
            this.cantidadPasajeros = cantidadPasajeros;
        }

       
    }
}
