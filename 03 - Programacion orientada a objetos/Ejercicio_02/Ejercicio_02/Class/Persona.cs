using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_02.Class
{
    public class Persona
    {
        #region ATRIBUTOS

        private string _nombre;
        private DateTime _fechaDeNacimiento;
        private string _dni;

        #endregion

        #region CONSTRUCTOR

        public Persona(string nombre, DateTime fechaDeNacimiento, string dni)
        {
            _nombre = nombre;
            _fechaDeNacimiento = fechaDeNacimiento;
            _dni = dni;
        }

        #endregion

        #region PROPIEDADES

        public string Nombre
        {
            get { return this._nombre; }
            set { this._nombre = value; }
        }
        public DateTime FechaDeNacimiento
        {
            get { return this._fechaDeNacimiento; }
            set { this._fechaDeNacimiento = value; }
        }
        public string Dni
        {
            get { return this._dni; }
            set { this._dni = value; }
        }

        #endregion

        private int CalcularEdad()
        {
            int edad = DateTime.Now.AddTicks(-this.FechaDeNacimiento.Ticks).Year - 1;
            return edad;
        }
        public string EsMayorDeEdad()
        {
            int edad = CalcularEdad();
            string retorno = "";
            if(edad >= 18)
            {
                retorno = "Es mayor de edad";
            }
            else
            {
                retorno = "Es menor";
            }
            return retorno;
        }
        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"NOMBRE: {this._nombre}");
            sb.AppendLine($"FECHA DE NACIMIENTO: {this.FechaDeNacimiento.Date}");
            sb.AppendLine($"DNI:{this._dni}");
            sb.AppendLine($"EDAD:{this.CalcularEdad()}");

            return sb.ToString();
        }
    }
}
