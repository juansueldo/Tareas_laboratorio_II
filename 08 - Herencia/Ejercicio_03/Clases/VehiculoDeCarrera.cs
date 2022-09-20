using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public abstract class VehiculoDeCarrera
    {
        private short cantidadCombustible;
        private bool enCompetencia;
        private string escuderia;
        private short numero;
        private short vueltasRestantes;
        
        public VehiculoDeCarrera(short numero,string escuderia)
        {
            this.Numero = numero;
            this.Escuderia = escuderia;
        }

        public short CantidadCombustible { get => cantidadCombustible; set => cantidadCombustible = value; }
        public bool EnCompetencia { get => enCompetencia; set => enCompetencia = value; }
        public string Escuderia { get => escuderia; set => escuderia = value; }
        public short Numero { get => numero; set => numero = value; }
        public short VueltasRestantes { get => vueltasRestantes; set => vueltasRestantes = value; }
        
        public virtual string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"NUMERO: {this.numero}");
            sb.AppendLine($"ESCUDERIA: {this.escuderia}");
            sb.AppendLine($"VUELTAS RESTANTES: {this.vueltasRestantes}");
            sb.AppendLine($"EN COMPETENCIA? {this.enCompetencia}");
            sb.AppendLine($"COMBUSTIBLE {this.cantidadCombustible}");

            return sb.ToString();

        }
    }
}
