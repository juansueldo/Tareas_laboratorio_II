using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_07.Class
{
    public class Cliente
    {
        #region ATRIBUTOS
        public string domicilio;
        public string nombre;
        public string apellido;
        public double telefono;
        public List<Mascota> mascotas;
        #endregion
        #region CONSTRUCTORES
        public Cliente(string domicilio, string nombre, string apellido, double telefono)
        {
            this.domicilio = domicilio;
            this.nombre = nombre;
            this.apellido = apellido;
            this.telefono = telefono;
            this.mascotas = new List<Mascota>();
        }
        #endregion
        #region METODOS

        public static Cliente operator +(Cliente c,Mascota m)
        {
            c.mascotas.Add(m);
            return c;
        }
        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"NOMBRE Y APELLIDO: {this.nombre} {this.apellido}");
            sb.AppendLine($"DOMICILIO: {this.domicilio}");
            sb.AppendLine($"TELEFONO: {this.telefono}");
            sb.AppendLine($"MASCOTAS:");
            foreach(Mascota m in this.mascotas)
            {
                sb.AppendLine($"{m.Mostrar()}");
            }

            return sb.ToString();
        }
        #endregion
    }
}
