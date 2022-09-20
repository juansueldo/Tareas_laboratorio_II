using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public abstract class Persona
    {
        private long dni;
        private string nombre;

        public Persona(string nombre)
        {
            this.nombre = nombre;
        }
        public Persona(long dni, string nombre) : this(nombre)
        {
            this.dni = dni;
        }

        public long Dni 
        { 
            get { return dni; }
            set { dni = value; }
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public virtual string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"NOMBRE: {this.nombre}");
            sb.AppendLine($"DNI: {this.dni}");

            return sb.ToString();
        }
    }
}
