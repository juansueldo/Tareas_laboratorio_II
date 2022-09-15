using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralTelefonica
{
    public class Local : Llamada
    {
        #region ATRIBUTOS
        protected float costo;
        #endregion

        #region PROPIEDADES
        public float CostoLlamada
        {
            get { return this.costo; }
        }
        #endregion

        #region CONSTRUCTORES
        public Local(Llamada llamada, float costo)
            :this(llamada.NroOrigen, llamada.Duracion, llamada.NroDestino, costo)
        {

        }
        public Local(string origen, float duracion, string destino, float costo)
            : base(duracion, destino, origen)
        {
            this.costo = costo;
        }
        #endregion

        #region METODOS
        private float CalcularCosto()
        {
            return base.Duracion * this.costo;
        }
        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"{base.Mostrar()}");
            sb.AppendLine($"COSTO: {this.costo}");
            sb.AppendLine($"COSTO TOTAL: {this.CalcularCosto()}");

            return sb.ToString();
        }
        #endregion

    }
}
