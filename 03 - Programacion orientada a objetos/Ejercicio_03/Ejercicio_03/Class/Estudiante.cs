using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_03.Class
{
    public class Estudiante
    {
        #region ATRIBUTOS

        private string _apellido;
        private string _legajo;
        private string _nombre;
        private int _notaPrimerParcial;
        private int _notaSegundoParcial;
        private static Random _random;

        #endregion

        #region CONSTRUCTORES

        private Estudiante()
        {
            Estudiante._random = new Random();
        }
        public Estudiante(string nombre,string apellido, string legajo)  : this()
        {
            _apellido = apellido;
            _legajo = legajo;
            _nombre = nombre;
        }

        #endregion

        #region METODOS

        public void SetNotaPrimerParcial(int nota)
        {
            this._notaPrimerParcial = nota;
        }
        public void SetNotaSgundoParcial(int nota)
        {
            this._notaSegundoParcial = nota;
        }
        private float CalcularPromedio()
        {
            float promedio = (this._notaPrimerParcial + this._notaSegundoParcial) / 2;
            return promedio;
        }
        public double CalcularNotaFinal()
        {
            double retorno = -1;
            if(this._notaPrimerParcial >= 4 && this._notaSegundoParcial >= 4)
            {
                retorno = Estudiante._random.Next(6, 10);
            }
            return retorno;
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            double auxiliarNota = CalcularNotaFinal();
            sb.AppendLine($"NOMBRE:{this._nombre} APELLIDO:{this._apellido} LEGAJO: {this._legajo}");
            sb.AppendLine($"NOTA DEL PRIMER PARCIAL: {this._notaPrimerParcial} NOTA DEL SEGUNDO PARCIAL: {this._notaSegundoParcial}");
            sb.AppendLine($"Promedio: {this.CalcularPromedio()}");
            if(auxiliarNota != -1)
            {
                sb.AppendLine($"NOTA FINAL: {auxiliarNota}");
            }
            else
            {
                sb.AppendLine($"Alumno desaprobado");
            }

            return sb.ToString();
        }
        #endregion

    }
}
