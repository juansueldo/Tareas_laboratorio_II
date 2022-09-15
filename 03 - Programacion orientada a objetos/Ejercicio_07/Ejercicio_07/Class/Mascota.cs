using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_07.Class
{
    public class Mascota
    {
        #region ATRIBUTOS
        public string especie;
        public string nombre;
        public DateTime fechaDeNacimiento;
        public string historialVacunacion;
        #endregion

        #region CONSTRUCTORES
        public Mascota(string especie, string nombre, DateTime fechaDeNacimiento)
        {
            this.especie = especie;
            this.nombre = nombre;
            this.fechaDeNacimiento = fechaDeNacimiento;
        }
        #endregion
        #region METODOS
        public void Vacuna(string vacuna)
        {
            this.historialVacunacion += vacuna;
        }
        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"ESPECIE: {this.especie}");
            sb.AppendLine($"NOMBRE: {this.nombre}");
            sb.AppendLine($"FECHA DE NACIMIENTO: {this.fechaDeNacimiento}");
            if(this.historialVacunacion != null)
            {
                sb.AppendLine($"HISTORIAL DE VACUNACION: {this.historialVacunacion}");
            }
            else
            {
                sb.AppendLine("NO RECIBIO VACUNAS");
            }

            return sb.ToString();
        }
        #endregion
    }
}
