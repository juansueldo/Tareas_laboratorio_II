using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralTelefonica
{
    public enum Franja { Franja_1, Franja_2, Franja_3 };
    public class Provincial : Llamada
    {
        #region ATRIBUTOS
        protected Franja franjaHoraria;
        #endregion

        #region CONSTRUCTORES
        public Provincial(Franja miFranja, Llamada llamada)
            : this(llamada.NroOrigen, miFranja ,llamada.Duracion, llamada.NroDestino)
        {

        }
        public Provincial(string origen, Franja miFranja, float duracion, string destino)
            : base(duracion, destino, origen)
        {
            this.franjaHoraria = miFranja;
        }
        #endregion

        #region METODOS
        private float CalcularCosto()
        {
            double retorno = 0;
            double aux = base.Duracion;
            if (this.franjaHoraria == Franja.Franja_1)
            {
                retorno = aux * 0.99;
            }
            else if (this.franjaHoraria == Franja.Franja_2)
            {
                retorno = aux * 1.25;
            }
            else if (this.franjaHoraria == Franja.Franja_3)
            {
                retorno = aux * 0.66;
            }
            return (float)retorno;
        }
        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"{base.Mostrar()}");
            sb.AppendLine($"COSTO TOTAL: {this.CalcularCosto()}");

            return sb.ToString();
        }
        #endregion
    }
}
