using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class DirectorTecnico : Persona
    {
        private DateTime fechaNacimiento;
        private DirectorTecnico(string nombre) : base(nombre)
        {
        }
        public DirectorTecnico(string nombre, DateTime fechaNacimiento)
            :this(nombre)
        {
            this.fechaNacimiento = fechaNacimiento;
        }
        public override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{base.MostrarDatos()}");
            sb.AppendLine($"FECHA DE NACIMIENTO: {this.fechaNacimiento}");

            return sb.ToString();
        }
        public static bool operator ==(DirectorTecnico dt1, DirectorTecnico dt2)
        {
            return (dt1.Dni == dt2.Dni && dt1.Nombre == dt2.Nombre);
        }
        public static bool operator !=(DirectorTecnico dt1, DirectorTecnico dt2)
        {
            return !(dt1 == dt2);
        }
    }
}
