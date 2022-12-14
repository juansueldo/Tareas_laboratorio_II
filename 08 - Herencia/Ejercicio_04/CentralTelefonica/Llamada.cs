using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralTelefonica
{
    public enum TipoLlamada { Local, Provincial, Todas };
    public abstract class Llamada
    {
        #region ATRIBUTOS
        protected float duracion;
        protected string nroDestino;
        protected string nroOrigen;
        #endregion

        #region PROPIEDADES
        public float Duracion
        {
            get { return this.duracion; }
        }
        public string NroDestino
        {
            get { return this.nroDestino; }
        }
        public string NroOrigen
        {
            get { return this.nroOrigen; }
        }
        #endregion

        #region CONSTRUCTORES
        public Llamada(float duracion, string nroDestino, string nroOrigen)
        {
            this.duracion = duracion;
            this.nroDestino = nroDestino;
            this.nroOrigen = nroOrigen;
        }
        #endregion

        #region METODOS
        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"DURACION: {this.duracion}");
            sb.AppendLine($"NUMERO DE DESTINO: {this.nroDestino}");
            sb.AppendLine($"NUMERO DE ORIGEN: {this.nroOrigen}");

            return sb.ToString();
        }
        public static int OrdenarPorDuracion(Llamada llamada1, Llamada llamada2)
        {
            if(llamada1.duracion > llamada2.duracion)
            {
                return 1;
            }
            return 0;
        }
        #endregion
    }
}
